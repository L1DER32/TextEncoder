namespace TextEncoder
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CopyDate = new System.Windows.Forms.Button();
            this.textBoxAuthorSrc = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDateSrc = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAnalytic = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEditionSrc = new System.Windows.Forms.RichTextBox();
            this.textBoxTitleSrc = new System.Windows.Forms.RichTextBox();
            this.textBoxBiblCitation = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDistr = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.RichTextBox();
            this.textBoxPublisher = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPublisherPlace = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTitle = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.checkBoxSentences = new System.Windows.Forms.CheckBox();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.checkBoxPunc = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // InputBox
            // 
            this.InputBox.ContextMenuStrip = this.contextMenuStrip1;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(488, 474);
            this.InputBox.TabIndex = 21;
            this.InputBox.Text = "";
            this.InputBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 474);
            this.panel1.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxSentences);
            this.tabPage2.Controls.Add(this.checkBoxOpen);
            this.tabPage2.Controls.Add(this.checkBoxPunc);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SourceDesc and Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CopyDate);
            this.groupBox3.Controls.Add(this.textBoxAuthorSrc);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxDateSrc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxAnalytic);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxEditionSrc);
            this.groupBox3.Controls.Add(this.textBoxTitleSrc);
            this.groupBox3.Controls.Add(this.textBoxBiblCitation);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 373);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SourceDesc Information";
            // 
            // btn_CopyDate
            // 
            this.btn_CopyDate.Location = new System.Drawing.Point(289, 329);
            this.btn_CopyDate.Name = "btn_CopyDate";
            this.btn_CopyDate.Size = new System.Drawing.Size(134, 35);
            this.btn_CopyDate.TabIndex = 34;
            this.btn_CopyDate.Text = "Copy date from PubStmt";
            this.btn_CopyDate.UseVisualStyleBackColor = true;
            this.btn_CopyDate.Click += new System.EventHandler(this.btn_CopyDate_Click);
            // 
            // textBoxAuthorSrc
            // 
            this.textBoxAuthorSrc.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxAuthorSrc.Location = new System.Drawing.Point(101, 146);
            this.textBoxAuthorSrc.Name = "textBoxAuthorSrc";
            this.textBoxAuthorSrc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxAuthorSrc.Size = new System.Drawing.Size(389, 55);
            this.textBoxAuthorSrc.TabIndex = 33;
            this.textBoxAuthorSrc.TabStop = false;
            this.textBoxAuthorSrc.Text = "";
            this.textBoxAuthorSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(11, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 32);
            this.label14.TabIndex = 32;
            this.label14.Text = "Bibliographic\r\n citation:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(56, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Date:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDateSrc
            // 
            this.textBoxDateSrc.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxDateSrc.Location = new System.Drawing.Point(101, 329);
            this.textBoxDateSrc.Name = "textBoxDateSrc";
            this.textBoxDateSrc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxDateSrc.Size = new System.Drawing.Size(169, 35);
            this.textBoxDateSrc.TabIndex = 29;
            this.textBoxDateSrc.TabStop = false;
            this.textBoxDateSrc.Text = "";
            this.textBoxDateSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(34, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Analytic:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAnalytic
            // 
            this.textBoxAnalytic.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxAnalytic.Location = new System.Drawing.Point(101, 268);
            this.textBoxAnalytic.Name = "textBoxAnalytic";
            this.textBoxAnalytic.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxAnalytic.Size = new System.Drawing.Size(389, 55);
            this.textBoxAnalytic.TabIndex = 27;
            this.textBoxAnalytic.TabStop = false;
            this.textBoxAnalytic.Text = "";
            this.textBoxAnalytic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(40, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Edition:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxEditionSrc
            // 
            this.textBoxEditionSrc.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxEditionSrc.Location = new System.Drawing.Point(101, 207);
            this.textBoxEditionSrc.Name = "textBoxEditionSrc";
            this.textBoxEditionSrc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxEditionSrc.Size = new System.Drawing.Size(389, 55);
            this.textBoxEditionSrc.TabIndex = 25;
            this.textBoxEditionSrc.TabStop = false;
            this.textBoxEditionSrc.Text = "";
            this.textBoxEditionSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // textBoxTitleSrc
            // 
            this.textBoxTitleSrc.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxTitleSrc.Location = new System.Drawing.Point(101, 85);
            this.textBoxTitleSrc.Name = "textBoxTitleSrc";
            this.textBoxTitleSrc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxTitleSrc.Size = new System.Drawing.Size(389, 55);
            this.textBoxTitleSrc.TabIndex = 24;
            this.textBoxTitleSrc.TabStop = false;
            this.textBoxTitleSrc.Text = "";
            this.textBoxTitleSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // textBoxBiblCitation
            // 
            this.textBoxBiblCitation.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxBiblCitation.Location = new System.Drawing.Point(101, 19);
            this.textBoxBiblCitation.Name = "textBoxBiblCitation";
            this.textBoxBiblCitation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxBiblCitation.Size = new System.Drawing.Size(389, 60);
            this.textBoxBiblCitation.TabIndex = 14;
            this.textBoxBiblCitation.TabStop = false;
            this.textBoxBiblCitation.Text = "";
            this.textBoxBiblCitation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(43, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Author:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(57, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Title:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TitleStmt and PubStmt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxDistr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxAddress);
            this.groupBox2.Controls.Add(this.textBoxPublisher);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPublisherPlace);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDate);
            this.groupBox2.Location = new System.Drawing.Point(20, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 273);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PubStmt Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Distributor:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDistr
            // 
            this.textBoxDistr.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxDistr.Location = new System.Drawing.Point(90, 198);
            this.textBoxDistr.Name = "textBoxDistr";
            this.textBoxDistr.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxDistr.Size = new System.Drawing.Size(370, 65);
            this.textBoxDistr.TabIndex = 21;
            this.textBoxDistr.TabStop = false;
            this.textBoxDistr.Text = "";
            this.textBoxDistr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(226, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxAddress.Location = new System.Drawing.Point(289, 161);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxAddress.Size = new System.Drawing.Size(171, 32);
            this.textBoxAddress.TabIndex = 19;
            this.textBoxAddress.TabStop = false;
            this.textBoxAddress.Text = "";
            this.textBoxAddress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxPublisher.Location = new System.Drawing.Point(90, 19);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxPublisher.Size = new System.Drawing.Size(370, 65);
            this.textBoxPublisher.TabIndex = 9;
            this.textBoxPublisher.TabStop = false;
            this.textBoxPublisher.Text = "";
            this.textBoxPublisher.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Publisher\r\nplace:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPublisherPlace
            // 
            this.textBoxPublisherPlace.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxPublisherPlace.Location = new System.Drawing.Point(90, 90);
            this.textBoxPublisherPlace.Name = "textBoxPublisherPlace";
            this.textBoxPublisherPlace.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxPublisherPlace.Size = new System.Drawing.Size(370, 65);
            this.textBoxPublisherPlace.TabIndex = 17;
            this.textBoxPublisherPlace.TabStop = false;
            this.textBoxPublisherPlace.Text = "";
            this.textBoxPublisherPlace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Publisher:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDate
            // 
            this.textBoxDate.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxDate.Location = new System.Drawing.Point(90, 161);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxDate.Size = new System.Drawing.Size(133, 32);
            this.textBoxDate.TabIndex = 14;
            this.textBoxDate.TabStop = false;
            this.textBoxDate.Text = "";
            this.textBoxDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(17, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 46);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.TabStop = false;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncode.Location = new System.Drawing.Point(17, 92);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(125, 46);
            this.btnEncode.TabIndex = 22;
            this.btnEncode.Text = "Encode text";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(158, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 155);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TitleStmt Information";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxTitle.Location = new System.Drawing.Point(54, 20);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxTitle.Size = new System.Drawing.Size(268, 62);
            this.textBoxTitle.TabIndex = 7;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.Text = "";
            this.textBoxTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxAuthor.Location = new System.Drawing.Point(54, 88);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxAuthor.Size = new System.Drawing.Size(268, 48);
            this.textBoxAuthor.TabIndex = 8;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.Text = "";
            this.textBoxAuthor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TxtBox_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(488, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 474);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.TabStop = false;
            // 
            // checkBoxSentences
            // 
            this.checkBoxSentences.AutoSize = true;
            this.checkBoxSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSentences.Location = new System.Drawing.Point(40, 420);
            this.checkBoxSentences.Name = "checkBoxSentences";
            this.checkBoxSentences.Size = new System.Drawing.Size(139, 20);
            this.checkBoxSentences.TabIndex = 36;
            this.checkBoxSentences.Text = "Encode sentenses";
            this.checkBoxSentences.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Checked = true;
            this.checkBoxOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOpen.Location = new System.Drawing.Point(40, 382);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(148, 20);
            this.checkBoxOpen.TabIndex = 35;
            this.checkBoxOpen.Text = "Open after encoding";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // checkBoxPunc
            // 
            this.checkBoxPunc.AutoSize = true;
            this.checkBoxPunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPunc.Location = new System.Drawing.Point(292, 382);
            this.checkBoxPunc.Name = "checkBoxPunc";
            this.checkBoxPunc.Size = new System.Drawing.Size(168, 20);
            this.checkBoxPunc.TabIndex = 34;
            this.checkBoxPunc.Text = "Encode text punctuation";
            this.checkBoxPunc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 512);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encoder";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_CopyDate;
        private System.Windows.Forms.RichTextBox textBoxAuthorSrc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox textBoxDateSrc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox textBoxAnalytic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox textBoxEditionSrc;
        private System.Windows.Forms.RichTextBox textBoxTitleSrc;
        private System.Windows.Forms.RichTextBox textBoxBiblCitation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox textBoxDistr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox textBoxAddress;
        private System.Windows.Forms.RichTextBox textBoxPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox textBoxPublisherPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBoxDate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBoxAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox checkBoxSentences;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private System.Windows.Forms.CheckBox checkBoxPunc;


    }
}

