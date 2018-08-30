namespace downMovieTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTyep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbdaoyan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbzhuyan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbstat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(13, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 411);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 405);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "形式:";
            // 
            // cmbShape
            // 
            this.cmbShape.Font = new System.Drawing.Font("宋体", 13F);
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Items.AddRange(new object[] {
            "电影",
            "电视剧",
            "综艺",
            "动画",
            "纪录片",
            "短片"});
            this.cmbShape.Location = new System.Drawing.Point(63, 13);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(121, 25);
            this.cmbShape.TabIndex = 1;
            this.cmbShape.Text = "电影";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbPeople);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbNum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbCountry);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbTyep);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbShape);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(472, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 411);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 25F);
            this.button1.Location = new System.Drawing.Point(10, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPeople
            // 
            this.tbPeople.Font = new System.Drawing.Font("宋体", 13F);
            this.tbPeople.Location = new System.Drawing.Point(63, 140);
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(121, 27);
            this.tbPeople.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13F);
            this.label5.Location = new System.Drawing.Point(7, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "人数:";
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("宋体", 13F);
            this.tbNum.Location = new System.Drawing.Point(63, 107);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(121, 27);
            this.tbNum.TabIndex = 7;
            this.tbNum.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "评分:";
            // 
            // cmbCountry
            // 
            this.cmbCountry.Font = new System.Drawing.Font("宋体", 13F);
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "中国大陆",
            "美国",
            "香港",
            "台湾",
            "日本",
            "韩国",
            "英国",
            "法国",
            "德国",
            "意大利",
            "西班牙",
            "印度",
            "泰国",
            "俄罗斯",
            "伊朗",
            "加拿大",
            "澳大利亚",
            "爱尔兰",
            "瑞典",
            "巴西",
            "丹麦"});
            this.cmbCountry.Location = new System.Drawing.Point(63, 75);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 25);
            this.cmbCountry.TabIndex = 5;
            this.cmbCountry.Text = "中国大陆";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "地区:";
            // 
            // cmbTyep
            // 
            this.cmbTyep.Font = new System.Drawing.Font("宋体", 13F);
            this.cmbTyep.FormattingEnabled = true;
            this.cmbTyep.Items.AddRange(new object[] {
            "剧情",
            "喜剧",
            "动作",
            "爱情",
            "科幻",
            "悬疑",
            "惊悚",
            "恐怖",
            "犯罪",
            "同性",
            "音乐",
            "歌舞",
            "传记",
            "历史",
            "战争",
            "西部",
            "奇幻",
            "冒险",
            "灾难",
            "武侠",
            "情色"});
            this.cmbTyep.Location = new System.Drawing.Point(63, 44);
            this.cmbTyep.Name = "cmbTyep";
            this.cmbTyep.Size = new System.Drawing.Size(121, 25);
            this.cmbTyep.TabIndex = 3;
            this.cmbTyep.Text = "喜剧";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型:";
            // 
            // tbdaoyan
            // 
            this.tbdaoyan.Font = new System.Drawing.Font("宋体", 13F);
            this.tbdaoyan.Location = new System.Drawing.Point(63, 8);
            this.tbdaoyan.Name = "tbdaoyan";
            this.tbdaoyan.Size = new System.Drawing.Size(159, 27);
            this.tbdaoyan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13F);
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "导演:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13F);
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "主演:";
            // 
            // tbzhuyan
            // 
            this.tbzhuyan.Font = new System.Drawing.Font("宋体", 13F);
            this.tbzhuyan.Location = new System.Drawing.Point(63, 41);
            this.tbzhuyan.Name = "tbzhuyan";
            this.tbzhuyan.Size = new System.Drawing.Size(159, 27);
            this.tbzhuyan.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 25F);
            this.button2.Location = new System.Drawing.Point(228, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbstat);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbzhuyan);
            this.panel3.Controls.Add(this.tbdaoyan);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(13, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 112);
            this.panel3.TabIndex = 0;
            // 
            // tbstat
            // 
            this.tbstat.Font = new System.Drawing.Font("宋体", 13F);
            this.tbstat.Location = new System.Drawing.Point(63, 73);
            this.tbstat.Name = "tbstat";
            this.tbstat.Size = new System.Drawing.Size(159, 27);
            this.tbstat.TabIndex = 14;
            this.tbstat.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13F);
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "评分:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(939, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 452);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(663, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 408);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 25F);
            this.button4.Location = new System.Drawing.Point(939, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(297, 76);
            this.button4.TabIndex = 12;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 505);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 53);
            this.progressBar1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13F);
            this.label9.Location = new System.Drawing.Point(462, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "电影名称:";
            // 
            // tbMovieName
            // 
            this.tbMovieName.Font = new System.Drawing.Font("宋体", 13F);
            this.tbMovieName.Location = new System.Drawing.Point(557, 454);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(230, 27);
            this.tbMovieName.TabIndex = 15;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(847, 951);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(505, 53);
            this.progressBar2.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 25F);
            this.button3.Location = new System.Drawing.Point(803, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Serach";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 570);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTyep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbdaoyan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbzhuyan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbstat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button3;
    }
}

