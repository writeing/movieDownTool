using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downMovieTool
{
    public partial class Form1 : Form
    {
        List<moiveInfo> g_listAllMovie = new List<moiveInfo>();
        AutoCompleteStringCollection daoyansource = new AutoCompleteStringCollection();
        AutoCompleteStringCollection zhuyansource = new AutoCompleteStringCollection();
        AutoCompleteStringCollection dianyingsource = new AutoCompleteStringCollection();
        List<moviedownLinkInfo> g_moviedownlinkinfo = new List<moviedownLinkInfo>();
        public string g_sheetRpy = "";
        public MovieSetInfo g_moviesetinfo = new MovieSetInfo();
        formSet fs;
        public Form1()
        {
            InitializeComponent();
        }
        private void initFaceData()
        {
            // listviw init
            this.listView1.View = View.LargeIcon;
            this.listView1.LargeImageList = this.imageList1;
            //this.listView1.
            //textbox
            //tbdaoyan.AutoCompleteCustomSource = source;
            tbdaoyan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbdaoyan.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //tbzhuyan.AutoCompleteCustomSource = source;
            tbzhuyan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbzhuyan.AutoCompleteSource = AutoCompleteSource.CustomSource;


            tbMovieName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbMovieName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            fs = new formSet(g_moviesetinfo.downToolFileName);
            //
        }

        private moiveInfo converJaToMovieInfo(JObject jo)
        {
            moiveInfo temp = new moiveInfo();
            temp.star = jo["star"].ToString();
            temp.title = jo["title"].ToString();
            temp.movieUrl = jo["url"].ToString();
            temp.listCasts = jo["casts"].ToObject<List<string>>();
           // richTextBox1.AppendText(jo["casts"].GetType().ToString());        
            temp.rate = jo["rate"].ToString();
            temp.movieID = jo["id"].ToString();
            temp.listDirectors = jo["directors"].ToObject<List<string>>();
            temp.coverlink = jo["cover"].ToString();
            foreach (string daoyan in temp.listDirectors)
            {
                daoyansource.Add(daoyan);
            }
            foreach (string zhuyan in temp.listCasts)
            {
                zhuyansource.Add(zhuyan);
            }
            dianyingsource.Add(temp.title);
            return temp;
        }
        private void initLoadJson()
        {
            string jsonData = File.ReadAllText("douban.json");
            JObject jaObj = (JObject)JsonConvert.DeserializeObject(jsonData);
            var obj = JArray.Parse(jaObj["movie"].ToString());
            foreach (var jo in obj)
            {               
                g_listAllMovie.Add(converJaToMovieInfo((JObject)jo));                
            }
            tbdaoyan.AutoCompleteCustomSource = daoyansource;

            tbzhuyan.AutoCompleteCustomSource = zhuyansource;

            tbMovieName.AutoCompleteCustomSource = dianyingsource;

            try
            {
                //movieSet.txt
                string revJsonData = File.ReadAllText("movieSet.txt");
                g_moviesetinfo = JsonConvert.DeserializeObject<MovieSetInfo>(revJsonData);
            }
            catch (Exception)
            {
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initFaceData();
            initLoadJson();
        }
        private void readFileToShow(string filename)
        {
            string jsonData = File.ReadAllText(filename); 
            JObject jaObj = (JObject)JsonConvert.DeserializeObject(jsonData);
            var obj = JArray.Parse(jaObj["movie"].ToString());
            List<moiveInfo> listsrotMovie = new List<moiveInfo>();
            foreach (var jo in obj)
            {
                listsrotMovie.Add(converJaToMovieInfo((JObject)jo));
            }
            _showListMovieImage(listsrotMovie);
        }
        private string strloadJson = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (strloadJson.IndexOf("end") > -1)
                {
                    shouMessage("movie info get finish\r\n");
                    strloadJson = "";
                    readFileToShow("jsonMovie.json");
                }
                if (strloadJson.IndexOf("readfinish") > -1)
                {
                    shouMessage("movie info get finish\r\n");
                    strloadJson = "";
                    //initLoadJson();
                    if (g_sheetRpy.Length > 0)
                    {
                        string data = g_sheetRpy;
                        g_sheetRpy = "";
                        int len = data.Length;                        
                        try
                        {
                            JObject jaObj = (JObject)JsonConvert.DeserializeObject(data);
                            var obj = JArray.Parse(jaObj["movie"].ToString());
                            foreach(var ob in obj)
                            {
                                moviedownLinkInfo temp = new moviedownLinkInfo();
                                temp.name = ob["name"].ToString();
                                temp.link = ob["link"].ToString();
                                //byte[] uni = Encoding.Unicode.GetBytes(temp.name);

                                //temp.name = Encoding.ASCII.GetString(uni);
                                g_moviedownlinkinfo.Add(temp);
                            }                            
                            foreach(var linkinfo in g_moviedownlinkinfo)
                            {
                                if(linkinfo.name == "showLink")
                                {
                                    shouMessage(linkinfo.link);
                                }
                                else
                                {
                                    cmbDownLink.Items.Add(linkinfo.name);
                                }
                                
                            }
                        }
                        catch (Exception)
                        {
                            shouMessage(data);                            
                        }                       
                    }
                }
                
            }
            catch (Exception)
            {                
            }            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Shape = cmbShape.Text;
            string Tyep = cmbTyep.Text;
            string country = cmbCountry.Text;
            string stat = tbNum.Text;
            string people = tbPeople.Text;
            string urlshape = System.Web.HttpUtility.UrlEncode(Shape);
            string urlTyep = System.Web.HttpUtility.UrlEncode(Tyep);
            string urlcountry = System.Web.HttpUtility.UrlEncode(country);

            setProgressBar(0);
            shouMessage("");
            string getUrl = string.Format("https://movie.douban.com/j/new_search_subjects?sort=T&range={0},10&tags={1}&start=index&genres={2}&countries={3}", stat,urlshape,urlTyep,urlcountry);
            string jsonIndex = _getMovieJsonInDouban(getUrl, "getjsonbeurl.py");
            
            //ansy  jsondata to show
        }
        
        private string _getMovieJsonInDouban(string url,string filename)
        {
            ProcessStartInfo si = new ProcessStartInfo(@"python");
            si.WindowStyle = ProcessWindowStyle.Hidden;
            si.CreateNoWindow = true;
            si.UseShellExecute = false;
            si.RedirectStandardOutput = true;
            
            si.Arguments = " " + Environment.CurrentDirectory + "\\"+ filename +" " + url;
           // shouMessage(si.Arguments);        
            Process pp = Process.Start(si);
            pp.OutputDataReceived += new DataReceivedEventHandler(pp_OutputDataReceived);
            pp.BeginOutputReadLine();            
            return strloadJson;
        }
        private void pp_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
           // shouMessage(e.Data);
            //strloadJson = e.Data;
            if(e.Data!= null && e.Data.IndexOf("end") > -1)
            {
                strloadJson = "end";
                return;
            }//readend
            if (e.Data != null && e.Data == "none serach")
            {
                strloadJson = "readfinish";
                return;
            }//readend
            if (e.Data != null && e.Data == "readfinish")
            {
                strloadJson = "readfinish";
                return;
            }//readend
            if (e.Data != null)
            {
                g_sheetRpy += e.Data;
            }            
        }
        private Image _getImageForRemmote(string url)
        {
            WebRequest myrequest = WebRequest.Create(url);
            WebResponse myresponse = myrequest.GetResponse();
            Stream imgstream = myresponse.GetResponseStream();            
            Image img = Image.FromStream(imgstream);
            return img;
        }
        private void _getMovieImage(List<moiveInfo> temp)
        {
            string url = "";
            foreach (var tt in temp)
            {
                Image img = null;
                try
                {
                    img = Image.FromFile("image\\" + tt.movieID);                                        
                }
                catch (Exception)
                {                    
                }
                if(img == null)
                {                
                    url = tt.coverlink;
                    img = _getImageForRemmote(url);
                    img.Save("image\\" + tt.movieID);
                }                                
                imageList1.Images.Add(img);

                //imageList1.ImageSize = new Size(30, 30);
            }
        }
        private void _showListMovieImage(List<moiveInfo> temp)
        {
            this.listView1.BeginUpdate();
            this.listView1.Items.Clear();
            if (temp == null)
            {
                this.listView1.EndUpdate();
                return;
            }
            _getMovieImage(temp);
            shouMessage("movie count = " + temp.Count + "\r\n");
            for (int i = 0; i < temp.Count; i++)
            {
                setProgressBar((int)((double)(i + 1) / temp.Count) * 100);
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = i;

                lvi.Text = temp[i].title;

                lvi.Tag = temp[i];
                this.listView1.Items.Add(lvi);
            }
            this.listView1.EndUpdate();

        }
        private List<moiveInfo> _findMovieInList(string[] name , string[] type )
        {
            List<moiveInfo> rpyList = new List<moiveInfo>();
            List<moiveInfo> forList = g_listAllMovie;
            for (int i = 0; i < name.Length; i ++)
            {
                if(name[i] == "" && rpyList != g_listAllMovie)
                {                    
                    continue;
                }                
                if(rpyList.Count > 0)
                {
                    forList = rpyList.ToList<moiveInfo>();
                    rpyList.Clear();
                }
                foreach (moiveInfo mi in forList)
                {
                    switch (type[i])
                    {
                        case "rate":
                            try
                            {
                                if (Convert.ToDouble(mi.rate) >= Convert.ToDouble(name[i]))
                                {
                                    rpyList.Add(mi);
                                    continue;
                                }                                
                            }
                            catch (Exception)
                            {                                
                            }
                            break;
                        case "title":
                            break;
                        case "Casts":
                            if (mi.listCasts.IndexOf(name[i]) > -1)
                            {
                                rpyList.Add(mi);
                                continue;
                            }
                            break;
                        case "Directors":
                            if (mi.listDirectors.IndexOf(name[i]) > -1)
                            {
                                rpyList.Add(mi);
                                continue;
                            }
                            break;
                        default: rpyList.Add(mi); break;
                    }
                }

            }       
            return rpyList;
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            string[] name = new string[3];
            string[] type = new string[3] { "Directors", "Casts", "rate" };

            name[0] = tbdaoyan.Text;
            name[1] = tbzhuyan.Text;
            name[2] = tbstat.Text;
            
            List<moiveInfo> temp;
            temp = _findMovieInList(name, type);
            _showListMovieImage(temp);
            
        }
        private void shouMessage(string value)
        {
            if (value == null)
            {
                return;
            }
            if(value == "")
            {
                richTextBox1.Invoke(new Action(() => { richTextBox1.Text = (value); }));
                return;
            }
            richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText(value); }));
        }
        
        private void setProgressBar(int value)
        {
            if (value > 100)
            {
                value = 100;
            }            
            progressBar1.Invoke(new Action(() => { progressBar1.Value = (value); }));
        }
        Dictionary<string, string> dictMovieInfo = new Dictionary<string, string>();
        private Dictionary<string,string> _getMovieinfoForDouban(string url)
        {
            ProcessStartInfo si = new ProcessStartInfo(@"python");
            si.WindowStyle = ProcessWindowStyle.Hidden;
            si.CreateNoWindow = false;
            si.UseShellExecute = false;
            si.RedirectStandardOutput = true;

            si.Arguments = " fenleiJson.py";
            Process po = Process.Start(si);
            po.OutputDataReceived += new DataReceivedEventHandler(Po_OutputDataReceived);
            po.BeginOutputReadLine();
            po.WaitForExit();
            return dictMovieInfo;
        }
        private void Po_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            shouMessage(e.Data);
        }
        moiveInfo g_currentMovieInfo;
        private void _showMovieInfo(moiveInfo temp)
        {
            g_currentMovieInfo = temp;
            Image img = null;
            img = Image.FromFile("image\\" + temp.movieID);
            if(img == null)
            {
                img = _getImageForRemmote(temp.coverlink);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = img.Size;
            pictureBox1.Image = img;
            shouMessage("");

            shouMessage("title:" + temp.title + "\n");
            shouMessage("导演" + ":");
            foreach (var daoyan in temp.listDirectors)
            {
                shouMessage(daoyan + ",");
            }
            shouMessage("\n");
            shouMessage("主演" + ":");
            foreach (var zhuyan in temp.listCasts)
            {
                shouMessage(zhuyan + " ");
            }
            shouMessage("\n");

            shouMessage("评分:" + temp.rate + "\n");
            shouMessage("链接:" + temp.movieUrl + "\n");


            //foreach(KeyValuePair<string, string> pair in  _getMovieinfoForDouban(temp.movieUrl))
            //{
            //    richTextBox1.AppendText(pair.Key + ":" + pair.Value + "\r\n");
            //}
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                _showMovieInfo((moiveInfo)this.listView1.SelectedItems[0].Tag);
            }
            catch (Exception exe)
            {
                shouMessage(exe.Data.ToString());
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _showMovieInfo(g_listAllMovie[10]);
        }
        /// <summary>
        /// 根据选择的电影名称，对电影进行下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            cmbDownLink.Items.Clear();
            shouMessage(g_currentMovieInfo.title);

            string urltitle = System.Web.HttpUtility.UrlEncode(g_currentMovieInfo.title, Encoding.GetEncoding("gbk"));           
            _getMovieJsonInDouban(urltitle, "getMovie_dytt.py");
            //todo:对接收到的数据做拆分
            //urltitle = System.Web.HttpUtility.UrlEncode(g_currentMovieInfo.title, Encoding.GetEncoding("utf-8"));
            //_getMovieJsonInDouban(urltitle, "getMovie_qj.py");
        }
        /// <summary>
        /// 通过电影名称，查找电影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            string movieName = tbMovieName.Text;
            List<moiveInfo> temp = new List<moiveInfo>();
            foreach (var vi in g_listAllMovie)
            {
                if (vi.title == tbMovieName.Text)
                {
                    temp.Add(vi);
                }
            }
            _showListMovieImage(temp);
            try
            {
                _showMovieInfo(temp[0]);
            }
            catch (Exception)
            {                
            }
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {            
            if(e.KeyData == Keys.Enter)
            {
                if(tbMovieName.Focused == true)
                {
                    button3_Click_1(this, null);
                }
                else if(tbdaoyan.Focused || tbzhuyan.Focused || tbstat.Focused)
                {
                    button2_Click(this, null);
                }
                else
                {
                    button1_Click(this, null);
                }
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fs.ShowDialog();
            g_moviesetinfo.downToolFileName = formSet.xunleiLink;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            string jsonData = JsonConvert.SerializeObject(g_moviesetinfo);
            File.WriteAllText("movieSet.txt", jsonData);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(g_moviesetinfo.downToolFileName == "")
            {
                fs.ShowDialog();
                return;
            }
            int index = cmbDownLink.SelectedIndex;
            _startXunleiDownMovie(g_moviesetinfo.downToolFileName,g_moviedownlinkinfo[index].link , MovieSetInfo.xunlei);
        }
        private void _startXunleiDownMovie(string filename, string args,string funcName)
        {
            ProcessStartInfo si = new ProcessStartInfo(filename + "\\" + funcName);
            si.WindowStyle = ProcessWindowStyle.Hidden;
            si.CreateNoWindow = true;
            si.UseShellExecute = false;
            si.RedirectStandardOutput = true;

            si.Arguments = " " + args;
            // shouMessage(si.Arguments);        
            Process pp = Process.Start(si);                       
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _getMovieJsonInDouban("", "getjson.py");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shouMessage(System.Text.Encoding.Default.HeaderName.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (g_moviesetinfo.downToolFileName == "")
            {
                fs.ShowDialog();
                return;
            }
            foreach (var downlink in g_moviedownlinkinfo)
            {
                _startXunleiDownMovie(g_moviesetinfo.downToolFileName, downlink.link, MovieSetInfo.xunlei);
            }
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    public class moiveInfo
    {        
        public string star;
        public string title;
        public string movieUrl;
        public List<string> listCasts = new List<string>();
        public string coverlink;
        public string rate;
        public List<string> listDirectors = new List<string>();
        public string cover_x;
        public string movieID;
        public string cover_y;
   
    }
    public class MovieSetInfo
    {
        public string downToolFileName;
        public const string xunlei = "Thunder.exe";
    }
    public class moviedownLinkInfo
    {
        public string name;
        public string link;
    }
}
