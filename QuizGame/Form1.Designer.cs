namespace QuizGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.quizdisplaypanel = new System.Windows.Forms.Panel();
            this.quizdisplaypane = new System.Windows.Forms.FlowLayoutPanel();
            this.questlb = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.wronglb = new System.Windows.Forms.Label();
            this.correctlb = new System.Windows.Forms.Label();
            this.optionA = new System.Windows.Forms.RadioButton();
            this.quizpanel = new System.Windows.Forms.Panel();
            this.curnamequizlb = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.countdownbar = new System.Windows.Forms.ProgressBar();
            this.curnumscorelb = new System.Windows.Forms.Label();
            this.questtotallb = new System.Windows.Forms.Label();
            this.questoflb = new System.Windows.Forms.Label();
            this.questnumlb = new System.Windows.Forms.Label();
            this.questionlb = new System.Windows.Forms.Label();
            this.currentscorelb = new System.Windows.Forms.Label();
            this.optionsgrid = new System.Windows.Forms.TableLayoutPanel();
            this.optionB = new System.Windows.Forms.RadioButton();
            this.optionC = new System.Windows.Forms.RadioButton();
            this.optionD = new System.Windows.Forms.RadioButton();
            this.chooselb = new System.Windows.Forms.Label();
            this.flowpaneA = new System.Windows.Forms.FlowLayoutPanel();
            this.option1lb = new System.Windows.Forms.Label();
            this.flowpaneB = new System.Windows.Forms.FlowLayoutPanel();
            this.option2lb = new System.Windows.Forms.Label();
            this.flowpaneC = new System.Windows.Forms.FlowLayoutPanel();
            this.option3lb = new System.Windows.Forms.Label();
            this.flowpaneD = new System.Windows.Forms.FlowLayoutPanel();
            this.option4lb = new System.Windows.Forms.Label();
            this.menupanel = new System.Windows.Forms.Panel();
            this.dropdownpanel = new System.Windows.Forms.Panel();
            this.setkeybtn = new System.Windows.Forms.Button();
            this.changeplayerbtn = new System.Windows.Forms.Button();
            this.topmenupanel = new System.Windows.Forms.Panel();
            this.playernamebtn = new System.Windows.Forms.Button();
            this.vlinelb = new System.Windows.Forms.Label();
            this.playerlb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quitbtn = new System.Windows.Forms.Button();
            this.highscorebtn = new System.Windows.Forms.Button();
            this.historypanel = new System.Windows.Forms.Panel();
            this.highestscorelb = new System.Windows.Forms.Label();
            this.highplayernamelb = new System.Windows.Forms.Label();
            this.lastgamescorelb = new System.Windows.Forms.Label();
            this.lastplayernamelb = new System.Windows.Forms.Label();
            this.lastscorelb = new System.Windows.Forms.Label();
            this.highscorelb = new System.Windows.Forms.Label();
            this.highplayerlb = new System.Windows.Forms.Label();
            this.lastplayerlb = new System.Windows.Forms.Label();
            this.highscorepanel = new System.Windows.Forms.Panel();
            this.backmenubtn = new System.Windows.Forms.Button();
            this.scorecontentpanel = new System.Windows.Forms.Panel();
            this.highscoretable = new System.Windows.Forms.TableLayoutPanel();
            this.avgtimehdlb = new System.Windows.Forms.Label();
            this.scorehdlb = new System.Windows.Forms.Label();
            this.namehdscorelb = new System.Windows.Forms.Label();
            this.numhdscorelb = new System.Windows.Forms.Label();
            this.highscoreheaderlb = new System.Windows.Forms.Label();
            this.currentscorepanel = new System.Windows.Forms.Panel();
            this.tryagainbtn = new System.Windows.Forms.Button();
            this.curscorelb = new System.Windows.Forms.Label();
            this.yourscorelb = new System.Windows.Forms.Label();
            this.curplayernamelb = new System.Windows.Forms.Label();
            this.dropdowntimer = new System.Windows.Forms.Timer(this.components);
            this.quizdisplaypanel.SuspendLayout();
            this.quizdisplaypane.SuspendLayout();
            this.quizpanel.SuspendLayout();
            this.optionsgrid.SuspendLayout();
            this.flowpaneA.SuspendLayout();
            this.flowpaneB.SuspendLayout();
            this.flowpaneC.SuspendLayout();
            this.flowpaneD.SuspendLayout();
            this.menupanel.SuspendLayout();
            this.dropdownpanel.SuspendLayout();
            this.topmenupanel.SuspendLayout();
            this.historypanel.SuspendLayout();
            this.highscorepanel.SuspendLayout();
            this.scorecontentpanel.SuspendLayout();
            this.highscoretable.SuspendLayout();
            this.currentscorepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // quizdisplaypanel
            // 
            this.quizdisplaypanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizdisplaypanel.AutoScroll = true;
            this.quizdisplaypanel.BackColor = System.Drawing.Color.Cornsilk;
            this.quizdisplaypanel.Controls.Add(this.quizdisplaypane);
            this.quizdisplaypanel.Location = new System.Drawing.Point(83, 91);
            this.quizdisplaypanel.Name = "quizdisplaypanel";
            this.quizdisplaypanel.Size = new System.Drawing.Size(516, 186);
            this.quizdisplaypanel.TabIndex = 1;
            // 
            // quizdisplaypane
            // 
            this.quizdisplaypane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizdisplaypane.Controls.Add(this.questlb);
            this.quizdisplaypane.Location = new System.Drawing.Point(167, 15);
            this.quizdisplaypane.Name = "quizdisplaypane";
            this.quizdisplaypane.Size = new System.Drawing.Size(497, 157);
            this.quizdisplaypane.TabIndex = 1;
            // 
            // questlb
            // 
            this.questlb.AutoSize = true;
            this.questlb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questlb.Location = new System.Drawing.Point(20, 20);
            this.questlb.Margin = new System.Windows.Forms.Padding(20);
            this.questlb.Name = "questlb";
            this.questlb.Size = new System.Drawing.Size(19, 23);
            this.questlb.TabIndex = 0;
            this.questlb.Text = "_";
            // 
            // startbtn
            // 
            this.startbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.startbtn.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.startbtn.FlatAppearance.BorderSize = 2;
            this.startbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.startbtn.Location = new System.Drawing.Point(250, 120);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(194, 52);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "Play";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // wronglb
            // 
            this.wronglb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wronglb.Image = ((System.Drawing.Image)(resources.GetObject("wronglb.Image")));
            this.wronglb.Location = new System.Drawing.Point(469, 63);
            this.wronglb.Name = "wronglb";
            this.wronglb.Size = new System.Drawing.Size(39, 27);
            this.wronglb.TabIndex = 5;
            // 
            // correctlb
            // 
            this.correctlb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.correctlb.Image = ((System.Drawing.Image)(resources.GetObject("correctlb.Image")));
            this.correctlb.Location = new System.Drawing.Point(469, 28);
            this.correctlb.Name = "correctlb";
            this.correctlb.Size = new System.Drawing.Size(39, 30);
            this.correctlb.TabIndex = 4;
            // 
            // optionA
            // 
            this.optionA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionA.Location = new System.Drawing.Point(8, 29);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(19, 28);
            this.optionA.TabIndex = 0;
            this.optionA.UseVisualStyleBackColor = true;
            this.optionA.Click += new System.EventHandler(this.choosedOption);
            // 
            // quizpanel
            // 
            this.quizpanel.AutoScroll = true;
            this.quizpanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.quizpanel.Controls.Add(this.curnamequizlb);
            this.quizpanel.Controls.Add(this.closebtn);
            this.quizpanel.Controls.Add(this.countdownbar);
            this.quizpanel.Controls.Add(this.curnumscorelb);
            this.quizpanel.Controls.Add(this.questtotallb);
            this.quizpanel.Controls.Add(this.questoflb);
            this.quizpanel.Controls.Add(this.questnumlb);
            this.quizpanel.Controls.Add(this.questionlb);
            this.quizpanel.Controls.Add(this.currentscorelb);
            this.quizpanel.Controls.Add(this.optionsgrid);
            this.quizpanel.Controls.Add(this.quizdisplaypanel);
            this.quizpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizpanel.Location = new System.Drawing.Point(0, 0);
            this.quizpanel.Name = "quizpanel";
            this.quizpanel.Size = new System.Drawing.Size(684, 525);
            this.quizpanel.TabIndex = 4;
            // 
            // curnamequizlb
            // 
            this.curnamequizlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.curnamequizlb.AutoSize = true;
            this.curnamequizlb.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curnamequizlb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.curnamequizlb.Location = new System.Drawing.Point(552, 47);
            this.curnamequizlb.Name = "curnamequizlb";
            this.curnamequizlb.Size = new System.Drawing.Size(43, 17);
            this.curnamequizlb.TabIndex = 15;
            this.curnamequizlb.Text = "Guest";
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.Snow;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(614, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(58, 49);
            this.closebtn.TabIndex = 14;
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closelb_Click);
            // 
            // countdownbar
            // 
            this.countdownbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countdownbar.BackColor = System.Drawing.Color.LightSlateGray;
            this.countdownbar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.countdownbar.Location = new System.Drawing.Point(83, 74);
            this.countdownbar.Name = "countdownbar";
            this.countdownbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countdownbar.Size = new System.Drawing.Size(516, 11);
            this.countdownbar.TabIndex = 13;
            // 
            // curnumscorelb
            // 
            this.curnumscorelb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.curnumscorelb.AutoSize = true;
            this.curnumscorelb.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curnumscorelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.curnumscorelb.Location = new System.Drawing.Point(362, 47);
            this.curnumscorelb.Name = "curnumscorelb";
            this.curnumscorelb.Size = new System.Drawing.Size(14, 17);
            this.curnumscorelb.TabIndex = 12;
            this.curnumscorelb.Text = "_";
            // 
            // questtotallb
            // 
            this.questtotallb.AutoSize = true;
            this.questtotallb.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questtotallb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.questtotallb.Location = new System.Drawing.Point(193, 45);
            this.questtotallb.Name = "questtotallb";
            this.questtotallb.Size = new System.Drawing.Size(14, 17);
            this.questtotallb.TabIndex = 11;
            this.questtotallb.Text = "_";
            // 
            // questoflb
            // 
            this.questoflb.AutoSize = true;
            this.questoflb.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questoflb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.questoflb.Location = new System.Drawing.Point(169, 47);
            this.questoflb.Name = "questoflb";
            this.questoflb.Size = new System.Drawing.Size(18, 15);
            this.questoflb.TabIndex = 10;
            this.questoflb.Text = "of";
            // 
            // questnumlb
            // 
            this.questnumlb.AutoSize = true;
            this.questnumlb.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questnumlb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.questnumlb.Location = new System.Drawing.Point(148, 45);
            this.questnumlb.Name = "questnumlb";
            this.questnumlb.Size = new System.Drawing.Size(14, 17);
            this.questnumlb.TabIndex = 9;
            this.questnumlb.Text = "_";
            // 
            // questionlb
            // 
            this.questionlb.AutoSize = true;
            this.questionlb.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.questionlb.Location = new System.Drawing.Point(80, 44);
            this.questionlb.Name = "questionlb";
            this.questionlb.Size = new System.Drawing.Size(71, 17);
            this.questionlb.TabIndex = 8;
            this.questionlb.Text = "Question: ";
            // 
            // currentscorelb
            // 
            this.currentscorelb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentscorelb.AutoSize = true;
            this.currentscorelb.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentscorelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.currentscorelb.Location = new System.Drawing.Point(309, 47);
            this.currentscorelb.Name = "currentscorelb";
            this.currentscorelb.Size = new System.Drawing.Size(47, 17);
            this.currentscorelb.TabIndex = 7;
            this.currentscorelb.Text = "Score:";
            // 
            // optionsgrid
            // 
            this.optionsgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsgrid.AutoSize = true;
            this.optionsgrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionsgrid.BackColor = System.Drawing.Color.DarkSlateGray;
            this.optionsgrid.ColumnCount = 3;
            this.optionsgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.optionsgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.optionsgrid.Controls.Add(this.wronglb, 2, 2);
            this.optionsgrid.Controls.Add(this.optionA, 0, 1);
            this.optionsgrid.Controls.Add(this.optionB, 0, 2);
            this.optionsgrid.Controls.Add(this.optionC, 0, 3);
            this.optionsgrid.Controls.Add(this.optionD, 0, 4);
            this.optionsgrid.Controls.Add(this.chooselb, 0, 0);
            this.optionsgrid.Controls.Add(this.flowpaneA, 1, 1);
            this.optionsgrid.Controls.Add(this.correctlb, 2, 1);
            this.optionsgrid.Controls.Add(this.flowpaneB, 1, 2);
            this.optionsgrid.Controls.Add(this.flowpaneC, 1, 3);
            this.optionsgrid.Controls.Add(this.flowpaneD, 1, 4);
            this.optionsgrid.Location = new System.Drawing.Point(83, 299);
            this.optionsgrid.Name = "optionsgrid";
            this.optionsgrid.Padding = new System.Windows.Forms.Padding(5);
            this.optionsgrid.RowCount = 5;
            this.optionsgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.optionsgrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsgrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsgrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsgrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsgrid.Size = new System.Drawing.Size(516, 167);
            this.optionsgrid.TabIndex = 6;
            // 
            // optionB
            // 
            this.optionB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionB.Location = new System.Drawing.Point(8, 63);
            this.optionB.Name = "optionB";
            this.optionB.Size = new System.Drawing.Size(19, 28);
            this.optionB.TabIndex = 1;
            this.optionB.UseVisualStyleBackColor = true;
            this.optionB.Click += new System.EventHandler(this.choosedOption);
            // 
            // optionC
            // 
            this.optionC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionC.Location = new System.Drawing.Point(8, 97);
            this.optionC.Name = "optionC";
            this.optionC.Size = new System.Drawing.Size(19, 28);
            this.optionC.TabIndex = 2;
            this.optionC.UseVisualStyleBackColor = true;
            this.optionC.Click += new System.EventHandler(this.choosedOption);
            // 
            // optionD
            // 
            this.optionD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionD.Location = new System.Drawing.Point(8, 131);
            this.optionD.Name = "optionD";
            this.optionD.Size = new System.Drawing.Size(18, 28);
            this.optionD.TabIndex = 4;
            this.optionD.UseVisualStyleBackColor = true;
            this.optionD.Click += new System.EventHandler(this.choosedOption);
            // 
            // chooselb
            // 
            this.chooselb.AutoSize = true;
            this.optionsgrid.SetColumnSpan(this.chooselb, 2);
            this.chooselb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooselb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooselb.Location = new System.Drawing.Point(8, 5);
            this.chooselb.Name = "chooselb";
            this.chooselb.Size = new System.Drawing.Size(97, 13);
            this.chooselb.TabIndex = 0;
            this.chooselb.Text = "Choose answer:";
            // 
            // flowpaneA
            // 
            this.flowpaneA.AutoSize = true;
            this.flowpaneA.Controls.Add(this.option1lb);
            this.flowpaneA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneA.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpaneA.Location = new System.Drawing.Point(33, 29);
            this.flowpaneA.Name = "flowpaneA";
            this.flowpaneA.Size = new System.Drawing.Size(430, 28);
            this.flowpaneA.TabIndex = 1;
            // 
            // option1lb
            // 
            this.option1lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.option1lb.AutoSize = true;
            this.option1lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option1lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.option1lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option1lb.Location = new System.Drawing.Point(3, 0);
            this.option1lb.Name = "option1lb";
            this.option1lb.Padding = new System.Windows.Forms.Padding(5);
            this.option1lb.Size = new System.Drawing.Size(71, 28);
            this.option1lb.TabIndex = 1;
            this.option1lb.Text = "OptionA";
            this.option1lb.Click += new System.EventHandler(this.option1lb_Click);
            // 
            // flowpaneB
            // 
            this.flowpaneB.AutoSize = true;
            this.flowpaneB.Controls.Add(this.option2lb);
            this.flowpaneB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneB.Location = new System.Drawing.Point(33, 63);
            this.flowpaneB.Name = "flowpaneB";
            this.flowpaneB.Size = new System.Drawing.Size(430, 28);
            this.flowpaneB.TabIndex = 2;
            // 
            // option2lb
            // 
            this.option2lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option2lb.AutoSize = true;
            this.option2lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option2lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.option2lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option2lb.Location = new System.Drawing.Point(3, 0);
            this.option2lb.Name = "option2lb";
            this.option2lb.Padding = new System.Windows.Forms.Padding(4);
            this.option2lb.Size = new System.Drawing.Size(70, 26);
            this.option2lb.TabIndex = 1;
            this.option2lb.Text = "OptionB";
            this.option2lb.Click += new System.EventHandler(this.option1lb_Click);
            // 
            // flowpaneC
            // 
            this.flowpaneC.AutoSize = true;
            this.flowpaneC.Controls.Add(this.option3lb);
            this.flowpaneC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneC.Location = new System.Drawing.Point(33, 97);
            this.flowpaneC.Name = "flowpaneC";
            this.flowpaneC.Size = new System.Drawing.Size(430, 28);
            this.flowpaneC.TabIndex = 3;
            // 
            // option3lb
            // 
            this.option3lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option3lb.AutoSize = true;
            this.option3lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option3lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option3lb.Location = new System.Drawing.Point(3, 0);
            this.option3lb.Name = "option3lb";
            this.option3lb.Padding = new System.Windows.Forms.Padding(4);
            this.option3lb.Size = new System.Drawing.Size(71, 26);
            this.option3lb.TabIndex = 1;
            this.option3lb.Text = "OptionC";
            this.option3lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.option3lb.Click += new System.EventHandler(this.option1lb_Click);
            // 
            // flowpaneD
            // 
            this.flowpaneD.AutoSize = true;
            this.flowpaneD.Controls.Add(this.option4lb);
            this.flowpaneD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpaneD.Location = new System.Drawing.Point(33, 131);
            this.flowpaneD.Name = "flowpaneD";
            this.flowpaneD.Size = new System.Drawing.Size(430, 28);
            this.flowpaneD.TabIndex = 4;
            // 
            // option4lb
            // 
            this.option4lb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.option4lb.AutoSize = true;
            this.option4lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option4lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.option4lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option4lb.Location = new System.Drawing.Point(3, 0);
            this.option4lb.Name = "option4lb";
            this.option4lb.Padding = new System.Windows.Forms.Padding(4);
            this.option4lb.Size = new System.Drawing.Size(71, 26);
            this.option4lb.TabIndex = 1;
            this.option4lb.Text = "OptionD";
            this.option4lb.Click += new System.EventHandler(this.option1lb_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menupanel.Controls.Add(this.dropdownpanel);
            this.menupanel.Controls.Add(this.topmenupanel);
            this.menupanel.Controls.Add(this.quitbtn);
            this.menupanel.Controls.Add(this.highscorebtn);
            this.menupanel.Controls.Add(this.historypanel);
            this.menupanel.Controls.Add(this.startbtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(684, 525);
            this.menupanel.TabIndex = 0;
            // 
            // dropdownpanel
            // 
            this.dropdownpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdownpanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dropdownpanel.Controls.Add(this.setkeybtn);
            this.dropdownpanel.Controls.Add(this.changeplayerbtn);
            this.dropdownpanel.Location = new System.Drawing.Point(537, 59);
            this.dropdownpanel.MaximumSize = new System.Drawing.Size(122, 75);
            this.dropdownpanel.MinimumSize = new System.Drawing.Size(122, 0);
            this.dropdownpanel.Name = "dropdownpanel";
            this.dropdownpanel.Size = new System.Drawing.Size(122, 0);
            this.dropdownpanel.TabIndex = 6;
            // 
            // setkeybtn
            // 
            this.setkeybtn.BackColor = System.Drawing.Color.Teal;
            this.setkeybtn.Enabled = false;
            this.setkeybtn.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.setkeybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setkeybtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setkeybtn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.setkeybtn.Location = new System.Drawing.Point(0, 36);
            this.setkeybtn.Name = "setkeybtn";
            this.setkeybtn.Size = new System.Drawing.Size(122, 36);
            this.setkeybtn.TabIndex = 11;
            this.setkeybtn.Text = "Set key";
            this.setkeybtn.UseVisualStyleBackColor = false;
            this.setkeybtn.Click += new System.EventHandler(this.setkeybtn_Click);
            // 
            // changeplayerbtn
            // 
            this.changeplayerbtn.BackColor = System.Drawing.Color.Teal;
            this.changeplayerbtn.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.changeplayerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeplayerbtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeplayerbtn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.changeplayerbtn.Location = new System.Drawing.Point(0, 0);
            this.changeplayerbtn.Name = "changeplayerbtn";
            this.changeplayerbtn.Size = new System.Drawing.Size(122, 36);
            this.changeplayerbtn.TabIndex = 10;
            this.changeplayerbtn.Text = "Change Player";
            this.changeplayerbtn.UseVisualStyleBackColor = false;
            this.changeplayerbtn.Click += new System.EventHandler(this.changeplayerbtn_Click);
            // 
            // topmenupanel
            // 
            this.topmenupanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.topmenupanel.Controls.Add(this.playernamebtn);
            this.topmenupanel.Controls.Add(this.vlinelb);
            this.topmenupanel.Controls.Add(this.playerlb);
            this.topmenupanel.Controls.Add(this.label6);
            this.topmenupanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topmenupanel.Location = new System.Drawing.Point(0, 0);
            this.topmenupanel.Name = "topmenupanel";
            this.topmenupanel.Size = new System.Drawing.Size(684, 72);
            this.topmenupanel.TabIndex = 1;
            // 
            // playernamebtn
            // 
            this.playernamebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playernamebtn.AutoSize = true;
            this.playernamebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playernamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernamebtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.playernamebtn.Location = new System.Drawing.Point(537, 29);
            this.playernamebtn.Name = "playernamebtn";
            this.playernamebtn.Size = new System.Drawing.Size(122, 29);
            this.playernamebtn.TabIndex = 9;
            this.playernamebtn.Text = "Guest";
            this.playernamebtn.UseVisualStyleBackColor = true;
            this.playernamebtn.Click += new System.EventHandler(this.playernamebtn_Click);
            // 
            // vlinelb
            // 
            this.vlinelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vlinelb.BackColor = System.Drawing.Color.LemonChiffon;
            this.vlinelb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vlinelb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vlinelb.Location = new System.Drawing.Point(508, 0);
            this.vlinelb.Name = "vlinelb";
            this.vlinelb.Size = new System.Drawing.Size(3, 72);
            this.vlinelb.TabIndex = 8;
            // 
            // playerlb
            // 
            this.playerlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerlb.AutoSize = true;
            this.playerlb.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerlb.Location = new System.Drawing.Point(574, 9);
            this.playerlb.Name = "playerlb";
            this.playerlb.Size = new System.Drawing.Size(49, 17);
            this.playerlb.TabIndex = 6;
            this.playerlb.Text = "Player";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(27, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "QuizIt";
            // 
            // quitbtn
            // 
            this.quitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.quitbtn.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.quitbtn.FlatAppearance.BorderSize = 2;
            this.quitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbtn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.quitbtn.Location = new System.Drawing.Point(249, 289);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(194, 52);
            this.quitbtn.TabIndex = 5;
            this.quitbtn.Text = "Quit";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // highscorebtn
            // 
            this.highscorebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highscorebtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.highscorebtn.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.highscorebtn.FlatAppearance.BorderSize = 2;
            this.highscorebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.highscorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscorebtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscorebtn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.highscorebtn.Location = new System.Drawing.Point(250, 204);
            this.highscorebtn.Name = "highscorebtn";
            this.highscorebtn.Size = new System.Drawing.Size(194, 52);
            this.highscorebtn.TabIndex = 4;
            this.highscorebtn.Text = "High Scores";
            this.highscorebtn.UseVisualStyleBackColor = false;
            this.highscorebtn.Click += new System.EventHandler(this.highscorebtn_Click);
            // 
            // historypanel
            // 
            this.historypanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.historypanel.Controls.Add(this.highestscorelb);
            this.historypanel.Controls.Add(this.highplayernamelb);
            this.historypanel.Controls.Add(this.lastgamescorelb);
            this.historypanel.Controls.Add(this.lastplayernamelb);
            this.historypanel.Controls.Add(this.lastscorelb);
            this.historypanel.Controls.Add(this.highscorelb);
            this.historypanel.Controls.Add(this.highplayerlb);
            this.historypanel.Controls.Add(this.lastplayerlb);
            this.historypanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.historypanel.Location = new System.Drawing.Point(0, 403);
            this.historypanel.Name = "historypanel";
            this.historypanel.Size = new System.Drawing.Size(684, 122);
            this.historypanel.TabIndex = 3;
            // 
            // highestscorelb
            // 
            this.highestscorelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highestscorelb.AutoSize = true;
            this.highestscorelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestscorelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.highestscorelb.Location = new System.Drawing.Point(497, 52);
            this.highestscorelb.Name = "highestscorelb";
            this.highestscorelb.Size = new System.Drawing.Size(13, 13);
            this.highestscorelb.TabIndex = 7;
            this.highestscorelb.Text = "_";
            // 
            // highplayernamelb
            // 
            this.highplayernamelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highplayernamelb.AutoSize = true;
            this.highplayernamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highplayernamelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.highplayernamelb.Location = new System.Drawing.Point(497, 25);
            this.highplayernamelb.Name = "highplayernamelb";
            this.highplayernamelb.Size = new System.Drawing.Size(13, 13);
            this.highplayernamelb.TabIndex = 6;
            this.highplayernamelb.Text = "_";
            // 
            // lastgamescorelb
            // 
            this.lastgamescorelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastgamescorelb.AutoSize = true;
            this.lastgamescorelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastgamescorelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lastgamescorelb.Location = new System.Drawing.Point(186, 52);
            this.lastgamescorelb.Name = "lastgamescorelb";
            this.lastgamescorelb.Size = new System.Drawing.Size(13, 13);
            this.lastgamescorelb.TabIndex = 5;
            this.lastgamescorelb.Text = "_";
            // 
            // lastplayernamelb
            // 
            this.lastplayernamelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastplayernamelb.AutoSize = true;
            this.lastplayernamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastplayernamelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lastplayernamelb.Location = new System.Drawing.Point(174, 25);
            this.lastplayernamelb.Name = "lastplayernamelb";
            this.lastplayernamelb.Size = new System.Drawing.Size(13, 13);
            this.lastplayernamelb.TabIndex = 4;
            this.lastplayernamelb.Text = "_";
            // 
            // lastscorelb
            // 
            this.lastscorelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastscorelb.AutoSize = true;
            this.lastscorelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lastscorelb.Location = new System.Drawing.Point(88, 52);
            this.lastscorelb.Name = "lastscorelb";
            this.lastscorelb.Size = new System.Drawing.Size(92, 13);
            this.lastscorelb.TabIndex = 3;
            this.lastscorelb.Text = "Last Game Score:";
            // 
            // highscorelb
            // 
            this.highscorelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highscorelb.AutoSize = true;
            this.highscorelb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.highscorelb.Location = new System.Drawing.Point(414, 52);
            this.highscorelb.Name = "highscorelb";
            this.highscorelb.Size = new System.Drawing.Size(77, 13);
            this.highscorelb.TabIndex = 2;
            this.highscorelb.Text = "Highest Score:";
            // 
            // highplayerlb
            // 
            this.highplayerlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highplayerlb.AutoSize = true;
            this.highplayerlb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.highplayerlb.Location = new System.Drawing.Point(411, 25);
            this.highplayerlb.Name = "highplayerlb";
            this.highplayerlb.Size = new System.Drawing.Size(80, 13);
            this.highplayerlb.TabIndex = 1;
            this.highplayerlb.Text = "Highest Scorer:";
            // 
            // lastplayerlb
            // 
            this.lastplayerlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastplayerlb.AutoSize = true;
            this.lastplayerlb.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lastplayerlb.Location = new System.Drawing.Point(88, 25);
            this.lastplayerlb.Name = "lastplayerlb";
            this.lastplayerlb.Size = new System.Drawing.Size(80, 13);
            this.lastplayerlb.TabIndex = 0;
            this.lastplayerlb.Text = "Last Played By:";
            // 
            // highscorepanel
            // 
            this.highscorepanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.highscorepanel.Controls.Add(this.backmenubtn);
            this.highscorepanel.Controls.Add(this.scorecontentpanel);
            this.highscorepanel.Controls.Add(this.highscoreheaderlb);
            this.highscorepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highscorepanel.Location = new System.Drawing.Point(0, 0);
            this.highscorepanel.Name = "highscorepanel";
            this.highscorepanel.Size = new System.Drawing.Size(684, 525);
            this.highscorepanel.TabIndex = 6;
            // 
            // backmenubtn
            // 
            this.backmenubtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backmenubtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.backmenubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backmenubtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backmenubtn.ForeColor = System.Drawing.Color.Yellow;
            this.backmenubtn.Location = new System.Drawing.Point(266, 462);
            this.backmenubtn.Name = "backmenubtn";
            this.backmenubtn.Size = new System.Drawing.Size(178, 41);
            this.backmenubtn.TabIndex = 4;
            this.backmenubtn.Text = "<< Back to menu >>";
            this.backmenubtn.UseVisualStyleBackColor = false;
            this.backmenubtn.Click += new System.EventHandler(this.backmenubtn_Click);
            // 
            // scorecontentpanel
            // 
            this.scorecontentpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scorecontentpanel.AutoScroll = true;
            this.scorecontentpanel.Controls.Add(this.highscoretable);
            this.scorecontentpanel.Location = new System.Drawing.Point(95, 141);
            this.scorecontentpanel.Name = "scorecontentpanel";
            this.scorecontentpanel.Size = new System.Drawing.Size(504, 303);
            this.scorecontentpanel.TabIndex = 3;
            // 
            // highscoretable
            // 
            this.highscoretable.AutoSize = true;
            this.highscoretable.BackColor = System.Drawing.Color.LemonChiffon;
            this.highscoretable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.highscoretable.ColumnCount = 4;
            this.highscoretable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.highscoretable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.highscoretable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.highscoretable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.highscoretable.Controls.Add(this.avgtimehdlb, 3, 0);
            this.highscoretable.Controls.Add(this.scorehdlb, 2, 0);
            this.highscoretable.Controls.Add(this.namehdscorelb, 1, 0);
            this.highscoretable.Controls.Add(this.numhdscorelb, 0, 0);
            this.highscoretable.Dock = System.Windows.Forms.DockStyle.Top;
            this.highscoretable.Location = new System.Drawing.Point(0, 0);
            this.highscoretable.Name = "highscoretable";
            this.highscoretable.Padding = new System.Windows.Forms.Padding(2);
            this.highscoretable.RowCount = 1;
            this.highscoretable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.highscoretable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.highscoretable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.highscoretable.Size = new System.Drawing.Size(504, 36);
            this.highscoretable.TabIndex = 2;
            // 
            // avgtimehdlb
            // 
            this.avgtimehdlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avgtimehdlb.AutoSize = true;
            this.avgtimehdlb.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgtimehdlb.Location = new System.Drawing.Point(377, 8);
            this.avgtimehdlb.Name = "avgtimehdlb";
            this.avgtimehdlb.Size = new System.Drawing.Size(115, 19);
            this.avgtimehdlb.TabIndex = 3;
            this.avgtimehdlb.Text = "Total Time(s)";
            // 
            // scorehdlb
            // 
            this.scorehdlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scorehdlb.AutoSize = true;
            this.scorehdlb.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorehdlb.Location = new System.Drawing.Point(276, 8);
            this.scorehdlb.Name = "scorehdlb";
            this.scorehdlb.Size = new System.Drawing.Size(52, 19);
            this.scorehdlb.TabIndex = 2;
            this.scorehdlb.Text = "Score";
            // 
            // namehdscorelb
            // 
            this.namehdscorelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namehdscorelb.AutoSize = true;
            this.namehdscorelb.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namehdscorelb.Location = new System.Drawing.Point(77, 8);
            this.namehdscorelb.Name = "namehdscorelb";
            this.namehdscorelb.Size = new System.Drawing.Size(120, 19);
            this.namehdscorelb.TabIndex = 1;
            this.namehdscorelb.Text = "Player\'s Name";
            // 
            // numhdscorelb
            // 
            this.numhdscorelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numhdscorelb.AutoSize = true;
            this.numhdscorelb.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numhdscorelb.Location = new System.Drawing.Point(11, 8);
            this.numhdscorelb.Name = "numhdscorelb";
            this.numhdscorelb.Size = new System.Drawing.Size(18, 19);
            this.numhdscorelb.TabIndex = 0;
            this.numhdscorelb.Text = "#";
            // 
            // highscoreheaderlb
            // 
            this.highscoreheaderlb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highscoreheaderlb.AutoSize = true;
            this.highscoreheaderlb.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreheaderlb.ForeColor = System.Drawing.Color.Beige;
            this.highscoreheaderlb.Location = new System.Drawing.Point(293, 109);
            this.highscoreheaderlb.Name = "highscoreheaderlb";
            this.highscoreheaderlb.Size = new System.Drawing.Size(118, 24);
            this.highscoreheaderlb.TabIndex = 1;
            this.highscoreheaderlb.Text = "Top Scorers";
            // 
            // currentscorepanel
            // 
            this.currentscorepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentscorepanel.BackColor = System.Drawing.Color.Ivory;
            this.currentscorepanel.Controls.Add(this.tryagainbtn);
            this.currentscorepanel.Controls.Add(this.curscorelb);
            this.currentscorepanel.Controls.Add(this.yourscorelb);
            this.currentscorepanel.Controls.Add(this.curplayernamelb);
            this.currentscorepanel.Location = new System.Drawing.Point(140, 16);
            this.currentscorepanel.Name = "currentscorepanel";
            this.currentscorepanel.Size = new System.Drawing.Size(420, 67);
            this.currentscorepanel.TabIndex = 5;
            // 
            // tryagainbtn
            // 
            this.tryagainbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tryagainbtn.BackColor = System.Drawing.Color.Teal;
            this.tryagainbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tryagainbtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryagainbtn.ForeColor = System.Drawing.Color.LightYellow;
            this.tryagainbtn.Location = new System.Drawing.Point(313, 32);
            this.tryagainbtn.Name = "tryagainbtn";
            this.tryagainbtn.Size = new System.Drawing.Size(98, 26);
            this.tryagainbtn.TabIndex = 3;
            this.tryagainbtn.Text = "Try Again";
            this.tryagainbtn.UseVisualStyleBackColor = false;
            this.tryagainbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // curscorelb
            // 
            this.curscorelb.AutoSize = true;
            this.curscorelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curscorelb.Location = new System.Drawing.Point(132, 39);
            this.curscorelb.Name = "curscorelb";
            this.curscorelb.Size = new System.Drawing.Size(36, 19);
            this.curscorelb.TabIndex = 2;
            this.curscorelb.Text = "650";
            // 
            // yourscorelb
            // 
            this.yourscorelb.AutoSize = true;
            this.yourscorelb.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourscorelb.Location = new System.Drawing.Point(22, 38);
            this.yourscorelb.Name = "yourscorelb";
            this.yourscorelb.Size = new System.Drawing.Size(110, 20);
            this.yourscorelb.TabIndex = 1;
            this.yourscorelb.Text = "Your score is: ";
            // 
            // curplayernamelb
            // 
            this.curplayernamelb.AutoSize = true;
            this.curplayernamelb.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curplayernamelb.Location = new System.Drawing.Point(22, 9);
            this.curplayernamelb.Name = "curplayernamelb";
            this.curplayernamelb.Size = new System.Drawing.Size(44, 20);
            this.curplayernamelb.TabIndex = 0;
            this.curplayernamelb.Text = "Meta";
            // 
            // dropdowntimer
            // 
            this.dropdowntimer.Interval = 20;
            this.dropdowntimer.Tick += new System.EventHandler(this.dropdownTransition);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 525);
            this.Controls.Add(this.menupanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizMania";
            this.quizdisplaypanel.ResumeLayout(false);
            this.quizdisplaypane.ResumeLayout(false);
            this.quizdisplaypane.PerformLayout();
            this.quizpanel.ResumeLayout(false);
            this.quizpanel.PerformLayout();
            this.optionsgrid.ResumeLayout(false);
            this.optionsgrid.PerformLayout();
            this.flowpaneA.ResumeLayout(false);
            this.flowpaneA.PerformLayout();
            this.flowpaneB.ResumeLayout(false);
            this.flowpaneB.PerformLayout();
            this.flowpaneC.ResumeLayout(false);
            this.flowpaneC.PerformLayout();
            this.flowpaneD.ResumeLayout(false);
            this.flowpaneD.PerformLayout();
            this.menupanel.ResumeLayout(false);
            this.dropdownpanel.ResumeLayout(false);
            this.topmenupanel.ResumeLayout(false);
            this.topmenupanel.PerformLayout();
            this.historypanel.ResumeLayout(false);
            this.historypanel.PerformLayout();
            this.highscorepanel.ResumeLayout(false);
            this.highscorepanel.PerformLayout();
            this.scorecontentpanel.ResumeLayout(false);
            this.scorecontentpanel.PerformLayout();
            this.highscoretable.ResumeLayout(false);
            this.highscoretable.PerformLayout();
            this.currentscorepanel.ResumeLayout(false);
            this.currentscorepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel quizdisplaypanel;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.RadioButton optionA;
        private System.Windows.Forms.Label correctlb;
        private System.Windows.Forms.Label wronglb;
        private System.Windows.Forms.Panel quizpanel;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.TableLayoutPanel optionsgrid;
        private System.Windows.Forms.Label chooselb;
        private System.Windows.Forms.Label questlb;
        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.Button highscorebtn;
        private System.Windows.Forms.Panel historypanel;
        private System.Windows.Forms.Label lastscorelb;
        private System.Windows.Forms.Label highscorelb;
        private System.Windows.Forms.Label highplayerlb;
        private System.Windows.Forms.Label lastplayerlb;
        private System.Windows.Forms.Panel highscorepanel;
        private System.Windows.Forms.Label highscoreheaderlb;
        private System.Windows.Forms.TableLayoutPanel highscoretable;
        private System.Windows.Forms.Label avgtimehdlb;
        private System.Windows.Forms.Label scorehdlb;
        private System.Windows.Forms.Label namehdscorelb;
        private System.Windows.Forms.Label numhdscorelb;
        private System.Windows.Forms.Panel scorecontentpanel;
        private System.Windows.Forms.Button backmenubtn;
        private System.Windows.Forms.Panel currentscorepanel;
        private System.Windows.Forms.Label curscorelb;
        private System.Windows.Forms.Label yourscorelb;
        private System.Windows.Forms.Label curplayernamelb;
        private System.Windows.Forms.Button tryagainbtn;
        private System.Windows.Forms.Label currentscorelb;
        private System.Windows.Forms.Label curnumscorelb;
        private System.Windows.Forms.Label questtotallb;
        private System.Windows.Forms.Label questoflb;
        private System.Windows.Forms.Label questnumlb;
        private System.Windows.Forms.Label questionlb;
        private System.Windows.Forms.Label option1lb;
        private System.Windows.Forms.RadioButton optionD;
        private System.Windows.Forms.Label option4lb;
        private System.Windows.Forms.RadioButton optionC;
        private System.Windows.Forms.Label option3lb;
        private System.Windows.Forms.RadioButton optionB;
        private System.Windows.Forms.Label option2lb;
        private System.Windows.Forms.FlowLayoutPanel flowpaneA;
        private System.Windows.Forms.FlowLayoutPanel flowpaneB;
        private System.Windows.Forms.FlowLayoutPanel flowpaneC;
        private System.Windows.Forms.FlowLayoutPanel flowpaneD;
        private System.Windows.Forms.ProgressBar countdownbar;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel topmenupanel;
        private System.Windows.Forms.Label playerlb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button playernamebtn;
        private System.Windows.Forms.Label vlinelb;
        private System.Windows.Forms.FlowLayoutPanel quizdisplaypane;
        private System.Windows.Forms.Label highestscorelb;
        private System.Windows.Forms.Label highplayernamelb;
        private System.Windows.Forms.Label lastgamescorelb;
        private System.Windows.Forms.Label lastplayernamelb;
        private System.Windows.Forms.Panel dropdownpanel;
        private System.Windows.Forms.Button changeplayerbtn;
        private System.Windows.Forms.Timer dropdowntimer;
        private System.Windows.Forms.Button setkeybtn;
        private System.Windows.Forms.Label curnamequizlb;
    }
}

