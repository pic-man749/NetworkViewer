namespace NetworkViewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbUdpSend = new System.Windows.Forms.GroupBox();
            this.btnUdpSendClear = new System.Windows.Forms.Button();
            this.cbUdpSendHexMode = new System.Windows.Forms.CheckBox();
            this.cbUdpSendAddLn = new System.Windows.Forms.CheckBox();
            this.tbUdpSend = new System.Windows.Forms.TextBox();
            this.tbnUdpSend = new System.Windows.Forms.Button();
            this.tbUdpSendPayload = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUdpSendPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUdpSendIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUdpRecv = new System.Windows.Forms.GroupBox();
            this.cbUdpRecvShowHexData = new System.Windows.Forms.CheckBox();
            this.tbUdpRecv = new System.Windows.Forms.TextBox();
            this.btnUdpRecvClear = new System.Windows.Forms.Button();
            this.btnUdpRecvListen = new System.Windows.Forms.Button();
            this.tbUdpRecvPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.UdpAsClient = new System.Windows.Forms.GroupBox();
            this.cbUdpClientHexMode = new System.Windows.Forms.CheckBox();
            this.cbUdpClientShowHexData = new System.Windows.Forms.CheckBox();
            this.tbUdpClientResponse = new System.Windows.Forms.TextBox();
            this.btnUdpClientClear = new System.Windows.Forms.Button();
            this.cbUdpClientAddTailLn = new System.Windows.Forms.CheckBox();
            this.btnUdpClientSend = new System.Windows.Forms.Button();
            this.tbUdpClientRequest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUdpClientPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUdpClientIp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UdpAsServer = new System.Windows.Forms.GroupBox();
            this.cbUdpServerShowHexData = new System.Windows.Forms.CheckBox();
            this.cbUdpServerAddTailLn = new System.Windows.Forms.CheckBox();
            this.cbUdpServerEchoMode = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUdpServerResponse = new System.Windows.Forms.TextBox();
            this.tbUdpServerLog = new System.Windows.Forms.TextBox();
            this.btnUdpServerClear = new System.Windows.Forms.Button();
            this.btnUdpServerListen = new System.Windows.Forms.Button();
            this.tbUdpServerPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.TcpAsClient = new System.Windows.Forms.GroupBox();
            this.cbTcpClientHexMode = new System.Windows.Forms.CheckBox();
            this.cbTcpClientShowHexData = new System.Windows.Forms.CheckBox();
            this.tbTcpClientResponse = new System.Windows.Forms.TextBox();
            this.btnTcpClientClear = new System.Windows.Forms.Button();
            this.cbTcpClientAddTailLn = new System.Windows.Forms.CheckBox();
            this.btnTcpClientSend = new System.Windows.Forms.Button();
            this.tbTcpClientRequest = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTcpClientPort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTcpClientIp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TcpAsServer = new System.Windows.Forms.GroupBox();
            this.cbTcpServerShowHexData = new System.Windows.Forms.CheckBox();
            this.cbTcpServerAddTailLn = new System.Windows.Forms.CheckBox();
            this.cbTcpServerEchoMode = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTcpServerResponse = new System.Windows.Forms.TextBox();
            this.tbTcpServerRequest = new System.Windows.Forms.TextBox();
            this.btnTcpServerClear = new System.Windows.Forms.Button();
            this.btnTcpServerListen = new System.Windows.Forms.Button();
            this.tbTcpServerPort = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbUdpSend.SuspendLayout();
            this.gbUdpRecv.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.UdpAsClient.SuspendLayout();
            this.UdpAsServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.TcpAsClient.SuspendLayout();
            this.TcpAsServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 751);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1166, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sender/receiver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbUdpSend);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbUdpRecv);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 714);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbUdpSend
            // 
            this.gbUdpSend.Controls.Add(this.btnUdpSendClear);
            this.gbUdpSend.Controls.Add(this.cbUdpSendHexMode);
            this.gbUdpSend.Controls.Add(this.cbUdpSendAddLn);
            this.gbUdpSend.Controls.Add(this.tbUdpSend);
            this.gbUdpSend.Controls.Add(this.tbnUdpSend);
            this.gbUdpSend.Controls.Add(this.tbUdpSendPayload);
            this.gbUdpSend.Controls.Add(this.label3);
            this.gbUdpSend.Controls.Add(this.tbUdpSendPort);
            this.gbUdpSend.Controls.Add(this.label2);
            this.gbUdpSend.Controls.Add(this.tbUdpSendIp);
            this.gbUdpSend.Controls.Add(this.label1);
            this.gbUdpSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUdpSend.Location = new System.Drawing.Point(0, 0);
            this.gbUdpSend.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.gbUdpSend.Name = "gbUdpSend";
            this.gbUdpSend.Padding = new System.Windows.Forms.Padding(4);
            this.gbUdpSend.Size = new System.Drawing.Size(585, 714);
            this.gbUdpSend.TabIndex = 1;
            this.gbUdpSend.TabStop = false;
            this.gbUdpSend.Text = "UDP send";
            // 
            // btnUdpSendClear
            // 
            this.btnUdpSendClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUdpSendClear.Location = new System.Drawing.Point(500, 85);
            this.btnUdpSendClear.Name = "btnUdpSendClear";
            this.btnUdpSendClear.Size = new System.Drawing.Size(75, 25);
            this.btnUdpSendClear.TabIndex = 7;
            this.btnUdpSendClear.Text = "clear";
            this.btnUdpSendClear.UseVisualStyleBackColor = true;
            this.btnUdpSendClear.Click += new System.EventHandler(this.btnUdpSendClear_Click);
            // 
            // cbUdpSendHexMode
            // 
            this.cbUdpSendHexMode.AutoSize = true;
            this.cbUdpSendHexMode.Location = new System.Drawing.Point(183, 87);
            this.cbUdpSendHexMode.Name = "cbUdpSendHexMode";
            this.cbUdpSendHexMode.Size = new System.Drawing.Size(81, 22);
            this.cbUdpSendHexMode.TabIndex = 6;
            this.cbUdpSendHexMode.Text = "HexMode";
            this.cbUdpSendHexMode.UseVisualStyleBackColor = true;
            // 
            // cbUdpSendAddLn
            // 
            this.cbUdpSendAddLn.AutoSize = true;
            this.cbUdpSendAddLn.Checked = true;
            this.cbUdpSendAddLn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUdpSendAddLn.Location = new System.Drawing.Point(89, 87);
            this.cbUdpSendAddLn.Name = "cbUdpSendAddLn";
            this.cbUdpSendAddLn.Size = new System.Drawing.Size(88, 22);
            this.cbUdpSendAddLn.TabIndex = 5;
            this.cbUdpSendAddLn.Text = "add tail \\n";
            this.cbUdpSendAddLn.UseVisualStyleBackColor = true;
            // 
            // tbUdpSend
            // 
            this.tbUdpSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpSend.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUdpSend.HideSelection = false;
            this.tbUdpSend.Location = new System.Drawing.Point(7, 116);
            this.tbUdpSend.Multiline = true;
            this.tbUdpSend.Name = "tbUdpSend";
            this.tbUdpSend.ReadOnly = true;
            this.tbUdpSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUdpSend.Size = new System.Drawing.Size(571, 592);
            this.tbUdpSend.TabIndex = 8;
            // 
            // tbnUdpSend
            // 
            this.tbnUdpSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnUdpSend.Location = new System.Drawing.Point(500, 56);
            this.tbnUdpSend.Name = "tbnUdpSend";
            this.tbnUdpSend.Size = new System.Drawing.Size(75, 25);
            this.tbnUdpSend.TabIndex = 4;
            this.tbnUdpSend.Text = "send";
            this.tbnUdpSend.UseVisualStyleBackColor = true;
            this.tbnUdpSend.Click += new System.EventHandler(this.btnUdpSend_Click);
            // 
            // tbUdpSendPayload
            // 
            this.tbUdpSendPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpSendPayload.Location = new System.Drawing.Point(89, 56);
            this.tbUdpSendPayload.Name = "tbUdpSendPayload";
            this.tbUdpSendPayload.Size = new System.Drawing.Size(405, 25);
            this.tbUdpSendPayload.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "payload:";
            // 
            // tbUdpSendPort
            // 
            this.tbUdpSendPort.Location = new System.Drawing.Point(245, 25);
            this.tbUdpSendPort.MaxLength = 5;
            this.tbUdpSendPort.Name = "tbUdpSendPort";
            this.tbUdpSendPort.Size = new System.Drawing.Size(131, 25);
            this.tbUdpSendPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // tbUdpSendIp
            // 
            this.tbUdpSendIp.Location = new System.Drawing.Point(89, 25);
            this.tbUdpSendIp.MaxLength = 15;
            this.tbUdpSendIp.Name = "tbUdpSendIp";
            this.tbUdpSendIp.Size = new System.Drawing.Size(131, 25);
            this.tbUdpSendIp.TabIndex = 1;
            this.tbUdpSendIp.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip : port";
            // 
            // gbUdpRecv
            // 
            this.gbUdpRecv.Controls.Add(this.cbUdpRecvShowHexData);
            this.gbUdpRecv.Controls.Add(this.tbUdpRecv);
            this.gbUdpRecv.Controls.Add(this.btnUdpRecvClear);
            this.gbUdpRecv.Controls.Add(this.btnUdpRecvListen);
            this.gbUdpRecv.Controls.Add(this.tbUdpRecvPort);
            this.gbUdpRecv.Controls.Add(this.label4);
            this.gbUdpRecv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUdpRecv.Location = new System.Drawing.Point(0, 0);
            this.gbUdpRecv.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.gbUdpRecv.Name = "gbUdpRecv";
            this.gbUdpRecv.Padding = new System.Windows.Forms.Padding(4);
            this.gbUdpRecv.Size = new System.Drawing.Size(570, 714);
            this.gbUdpRecv.TabIndex = 1;
            this.gbUdpRecv.TabStop = false;
            this.gbUdpRecv.Text = "UDP receive";
            // 
            // cbUdpRecvShowHexData
            // 
            this.cbUdpRecvShowHexData.AutoSize = true;
            this.cbUdpRecvShowHexData.Checked = true;
            this.cbUdpRecvShowHexData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUdpRecvShowHexData.Location = new System.Drawing.Point(367, 27);
            this.cbUdpRecvShowHexData.Name = "cbUdpRecvShowHexData";
            this.cbUdpRecvShowHexData.Size = new System.Drawing.Size(112, 22);
            this.cbUdpRecvShowHexData.TabIndex = 3;
            this.cbUdpRecvShowHexData.Text = "show HexData";
            this.cbUdpRecvShowHexData.UseVisualStyleBackColor = true;
            // 
            // tbUdpRecv
            // 
            this.tbUdpRecv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpRecv.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUdpRecv.HideSelection = false;
            this.tbUdpRecv.Location = new System.Drawing.Point(12, 56);
            this.tbUdpRecv.Multiline = true;
            this.tbUdpRecv.Name = "tbUdpRecv";
            this.tbUdpRecv.ReadOnly = true;
            this.tbUdpRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUdpRecv.Size = new System.Drawing.Size(551, 651);
            this.tbUdpRecv.TabIndex = 4;
            // 
            // btnUdpRecvClear
            // 
            this.btnUdpRecvClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUdpRecvClear.Location = new System.Drawing.Point(485, 25);
            this.btnUdpRecvClear.Name = "btnUdpRecvClear";
            this.btnUdpRecvClear.Size = new System.Drawing.Size(75, 25);
            this.btnUdpRecvClear.TabIndex = 4;
            this.btnUdpRecvClear.Text = "clear";
            this.btnUdpRecvClear.UseVisualStyleBackColor = true;
            this.btnUdpRecvClear.Click += new System.EventHandler(this.btnUdpRecvClear_Click);
            // 
            // btnUdpRecvListen
            // 
            this.btnUdpRecvListen.Location = new System.Drawing.Point(213, 25);
            this.btnUdpRecvListen.Name = "btnUdpRecvListen";
            this.btnUdpRecvListen.Size = new System.Drawing.Size(75, 25);
            this.btnUdpRecvListen.TabIndex = 2;
            this.btnUdpRecvListen.Text = "listen";
            this.btnUdpRecvListen.UseVisualStyleBackColor = true;
            this.btnUdpRecvListen.Click += new System.EventHandler(this.btnUdpListen_Click);
            // 
            // tbUdpRecvPort
            // 
            this.tbUdpRecvPort.Location = new System.Drawing.Point(76, 25);
            this.tbUdpRecvPort.MaxLength = 5;
            this.tbUdpRecvPort.Name = "tbUdpRecvPort";
            this.tbUdpRecvPort.Size = new System.Drawing.Size(131, 25);
            this.tbUdpRecvPort.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1166, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "client/server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer4.Size = new System.Drawing.Size(1160, 714);
            this.splitContainer4.SplitterDistance = 583;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.UdpAsClient);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.UdpAsServer);
            this.splitContainer5.Size = new System.Drawing.Size(583, 714);
            this.splitContainer5.SplitterDistance = 302;
            this.splitContainer5.TabIndex = 0;
            // 
            // UdpAsClient
            // 
            this.UdpAsClient.Controls.Add(this.cbUdpClientHexMode);
            this.UdpAsClient.Controls.Add(this.cbUdpClientShowHexData);
            this.UdpAsClient.Controls.Add(this.tbUdpClientResponse);
            this.UdpAsClient.Controls.Add(this.btnUdpClientClear);
            this.UdpAsClient.Controls.Add(this.cbUdpClientAddTailLn);
            this.UdpAsClient.Controls.Add(this.btnUdpClientSend);
            this.UdpAsClient.Controls.Add(this.tbUdpClientRequest);
            this.UdpAsClient.Controls.Add(this.label9);
            this.UdpAsClient.Controls.Add(this.tbUdpClientPort);
            this.UdpAsClient.Controls.Add(this.label10);
            this.UdpAsClient.Controls.Add(this.tbUdpClientIp);
            this.UdpAsClient.Controls.Add(this.label11);
            this.UdpAsClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UdpAsClient.Location = new System.Drawing.Point(0, 0);
            this.UdpAsClient.Name = "UdpAsClient";
            this.UdpAsClient.Size = new System.Drawing.Size(583, 302);
            this.UdpAsClient.TabIndex = 0;
            this.UdpAsClient.TabStop = false;
            this.UdpAsClient.Text = "UDP client";
            // 
            // cbUdpClientHexMode
            // 
            this.cbUdpClientHexMode.AutoSize = true;
            this.cbUdpClientHexMode.Location = new System.Drawing.Point(177, 88);
            this.cbUdpClientHexMode.Name = "cbUdpClientHexMode";
            this.cbUdpClientHexMode.Size = new System.Drawing.Size(81, 22);
            this.cbUdpClientHexMode.TabIndex = 6;
            this.cbUdpClientHexMode.Text = "HexMode";
            this.cbUdpClientHexMode.UseVisualStyleBackColor = true;
            // 
            // cbUdpClientShowHexData
            // 
            this.cbUdpClientShowHexData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUdpClientShowHexData.AutoSize = true;
            this.cbUdpClientShowHexData.Checked = true;
            this.cbUdpClientShowHexData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUdpClientShowHexData.Location = new System.Drawing.Point(385, 89);
            this.cbUdpClientShowHexData.Name = "cbUdpClientShowHexData";
            this.cbUdpClientShowHexData.Size = new System.Drawing.Size(112, 22);
            this.cbUdpClientShowHexData.TabIndex = 7;
            this.cbUdpClientShowHexData.Text = "show HexData";
            this.cbUdpClientShowHexData.UseVisualStyleBackColor = true;
            // 
            // tbUdpClientResponse
            // 
            this.tbUdpClientResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpClientResponse.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUdpClientResponse.HideSelection = false;
            this.tbUdpClientResponse.Location = new System.Drawing.Point(6, 118);
            this.tbUdpClientResponse.Multiline = true;
            this.tbUdpClientResponse.Name = "tbUdpClientResponse";
            this.tbUdpClientResponse.ReadOnly = true;
            this.tbUdpClientResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUdpClientResponse.Size = new System.Drawing.Size(571, 178);
            this.tbUdpClientResponse.TabIndex = 8;
            // 
            // btnUdpClientClear
            // 
            this.btnUdpClientClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUdpClientClear.Location = new System.Drawing.Point(502, 86);
            this.btnUdpClientClear.Name = "btnUdpClientClear";
            this.btnUdpClientClear.Size = new System.Drawing.Size(75, 25);
            this.btnUdpClientClear.TabIndex = 8;
            this.btnUdpClientClear.Text = "clear";
            this.btnUdpClientClear.UseVisualStyleBackColor = true;
            this.btnUdpClientClear.Click += new System.EventHandler(this.btnUdpClientClear_Click);
            // 
            // cbUdpClientAddTailLn
            // 
            this.cbUdpClientAddTailLn.AutoSize = true;
            this.cbUdpClientAddTailLn.Checked = true;
            this.cbUdpClientAddTailLn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUdpClientAddTailLn.Location = new System.Drawing.Point(83, 89);
            this.cbUdpClientAddTailLn.Name = "cbUdpClientAddTailLn";
            this.cbUdpClientAddTailLn.Size = new System.Drawing.Size(88, 22);
            this.cbUdpClientAddTailLn.TabIndex = 5;
            this.cbUdpClientAddTailLn.Text = "add tail \\n";
            this.cbUdpClientAddTailLn.UseVisualStyleBackColor = true;
            // 
            // btnUdpClientSend
            // 
            this.btnUdpClientSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUdpClientSend.Location = new System.Drawing.Point(503, 55);
            this.btnUdpClientSend.Name = "btnUdpClientSend";
            this.btnUdpClientSend.Size = new System.Drawing.Size(74, 25);
            this.btnUdpClientSend.TabIndex = 4;
            this.btnUdpClientSend.Text = "send";
            this.btnUdpClientSend.UseVisualStyleBackColor = true;
            this.btnUdpClientSend.Click += new System.EventHandler(this.btnUdpClientSend_Click);
            // 
            // tbUdpClientRequest
            // 
            this.tbUdpClientRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpClientRequest.Location = new System.Drawing.Point(83, 55);
            this.tbUdpClientRequest.Name = "tbUdpClientRequest";
            this.tbUdpClientRequest.Size = new System.Drawing.Size(414, 25);
            this.tbUdpClientRequest.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "request:";
            // 
            // tbUdpClientPort
            // 
            this.tbUdpClientPort.Location = new System.Drawing.Point(239, 24);
            this.tbUdpClientPort.MaxLength = 5;
            this.tbUdpClientPort.Name = "tbUdpClientPort";
            this.tbUdpClientPort.Size = new System.Drawing.Size(131, 25);
            this.tbUdpClientPort.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = ":";
            // 
            // tbUdpClientIp
            // 
            this.tbUdpClientIp.Location = new System.Drawing.Point(83, 24);
            this.tbUdpClientIp.MaxLength = 15;
            this.tbUdpClientIp.Name = "tbUdpClientIp";
            this.tbUdpClientIp.Size = new System.Drawing.Size(131, 25);
            this.tbUdpClientIp.TabIndex = 1;
            this.tbUdpClientIp.Text = "127.0.0.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "ip : port";
            // 
            // UdpAsServer
            // 
            this.UdpAsServer.Controls.Add(this.cbUdpServerShowHexData);
            this.UdpAsServer.Controls.Add(this.cbUdpServerAddTailLn);
            this.UdpAsServer.Controls.Add(this.cbUdpServerEchoMode);
            this.UdpAsServer.Controls.Add(this.label13);
            this.UdpAsServer.Controls.Add(this.tbUdpServerResponse);
            this.UdpAsServer.Controls.Add(this.tbUdpServerLog);
            this.UdpAsServer.Controls.Add(this.btnUdpServerClear);
            this.UdpAsServer.Controls.Add(this.btnUdpServerListen);
            this.UdpAsServer.Controls.Add(this.tbUdpServerPort);
            this.UdpAsServer.Controls.Add(this.label12);
            this.UdpAsServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UdpAsServer.Location = new System.Drawing.Point(0, 0);
            this.UdpAsServer.Name = "UdpAsServer";
            this.UdpAsServer.Size = new System.Drawing.Size(583, 408);
            this.UdpAsServer.TabIndex = 0;
            this.UdpAsServer.TabStop = false;
            this.UdpAsServer.Text = "UDP server";
            // 
            // cbUdpServerShowHexData
            // 
            this.cbUdpServerShowHexData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUdpServerShowHexData.AutoSize = true;
            this.cbUdpServerShowHexData.Checked = true;
            this.cbUdpServerShowHexData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUdpServerShowHexData.Location = new System.Drawing.Point(384, 88);
            this.cbUdpServerShowHexData.Name = "cbUdpServerShowHexData";
            this.cbUdpServerShowHexData.Size = new System.Drawing.Size(112, 22);
            this.cbUdpServerShowHexData.TabIndex = 6;
            this.cbUdpServerShowHexData.Text = "show HexData";
            this.cbUdpServerShowHexData.UseVisualStyleBackColor = true;
            // 
            // cbUdpServerAddTailLn
            // 
            this.cbUdpServerAddTailLn.AutoSize = true;
            this.cbUdpServerAddTailLn.Checked = true;
            this.cbUdpServerAddTailLn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUdpServerAddTailLn.Location = new System.Drawing.Point(83, 88);
            this.cbUdpServerAddTailLn.Name = "cbUdpServerAddTailLn";
            this.cbUdpServerAddTailLn.Size = new System.Drawing.Size(88, 22);
            this.cbUdpServerAddTailLn.TabIndex = 4;
            this.cbUdpServerAddTailLn.Text = "add tail \\n";
            this.cbUdpServerAddTailLn.UseVisualStyleBackColor = true;
            // 
            // cbUdpServerEchoMode
            // 
            this.cbUdpServerEchoMode.AutoSize = true;
            this.cbUdpServerEchoMode.Location = new System.Drawing.Point(177, 88);
            this.cbUdpServerEchoMode.Name = "cbUdpServerEchoMode";
            this.cbUdpServerEchoMode.Size = new System.Drawing.Size(85, 22);
            this.cbUdpServerEchoMode.TabIndex = 5;
            this.cbUdpServerEchoMode.Text = "EchoMode";
            this.cbUdpServerEchoMode.UseVisualStyleBackColor = true;
            this.cbUdpServerEchoMode.CheckedChanged += new System.EventHandler(this.cbUdpServerEchoMode_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "response:";
            // 
            // tbUdpServerResponse
            // 
            this.tbUdpServerResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpServerResponse.HideSelection = false;
            this.tbUdpServerResponse.Location = new System.Drawing.Point(83, 55);
            this.tbUdpServerResponse.Name = "tbUdpServerResponse";
            this.tbUdpServerResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUdpServerResponse.Size = new System.Drawing.Size(414, 25);
            this.tbUdpServerResponse.TabIndex = 2;
            // 
            // tbUdpServerLog
            // 
            this.tbUdpServerLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpServerLog.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUdpServerLog.HideSelection = false;
            this.tbUdpServerLog.Location = new System.Drawing.Point(6, 117);
            this.tbUdpServerLog.Multiline = true;
            this.tbUdpServerLog.Name = "tbUdpServerLog";
            this.tbUdpServerLog.ReadOnly = true;
            this.tbUdpServerLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUdpServerLog.Size = new System.Drawing.Size(571, 285);
            this.tbUdpServerLog.TabIndex = 9;
            // 
            // btnUdpServerClear
            // 
            this.btnUdpServerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUdpServerClear.Location = new System.Drawing.Point(502, 86);
            this.btnUdpServerClear.Name = "btnUdpServerClear";
            this.btnUdpServerClear.Size = new System.Drawing.Size(75, 25);
            this.btnUdpServerClear.TabIndex = 7;
            this.btnUdpServerClear.Text = "clear";
            this.btnUdpServerClear.UseVisualStyleBackColor = true;
            this.btnUdpServerClear.Click += new System.EventHandler(this.btnUdpServerClear_Click);
            // 
            // btnUdpServerListen
            // 
            this.btnUdpServerListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUdpServerListen.Location = new System.Drawing.Point(502, 55);
            this.btnUdpServerListen.Name = "btnUdpServerListen";
            this.btnUdpServerListen.Size = new System.Drawing.Size(75, 25);
            this.btnUdpServerListen.TabIndex = 3;
            this.btnUdpServerListen.Text = "listen";
            this.btnUdpServerListen.UseVisualStyleBackColor = true;
            this.btnUdpServerListen.Click += new System.EventHandler(this.btnUdpServerListen_Click);
            // 
            // tbUdpServerPort
            // 
            this.tbUdpServerPort.Location = new System.Drawing.Point(83, 24);
            this.tbUdpServerPort.MaxLength = 5;
            this.tbUdpServerPort.Name = "tbUdpServerPort";
            this.tbUdpServerPort.Size = new System.Drawing.Size(131, 25);
            this.tbUdpServerPort.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "port:";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.TcpAsClient);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.TcpAsServer);
            this.splitContainer6.Size = new System.Drawing.Size(573, 714);
            this.splitContainer6.SplitterDistance = 302;
            this.splitContainer6.TabIndex = 0;
            // 
            // TcpAsClient
            // 
            this.TcpAsClient.Controls.Add(this.cbTcpClientHexMode);
            this.TcpAsClient.Controls.Add(this.cbTcpClientShowHexData);
            this.TcpAsClient.Controls.Add(this.tbTcpClientResponse);
            this.TcpAsClient.Controls.Add(this.btnTcpClientClear);
            this.TcpAsClient.Controls.Add(this.cbTcpClientAddTailLn);
            this.TcpAsClient.Controls.Add(this.btnTcpClientSend);
            this.TcpAsClient.Controls.Add(this.tbTcpClientRequest);
            this.TcpAsClient.Controls.Add(this.label14);
            this.TcpAsClient.Controls.Add(this.tbTcpClientPort);
            this.TcpAsClient.Controls.Add(this.label15);
            this.TcpAsClient.Controls.Add(this.tbTcpClientIp);
            this.TcpAsClient.Controls.Add(this.label16);
            this.TcpAsClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcpAsClient.Location = new System.Drawing.Point(0, 0);
            this.TcpAsClient.Name = "TcpAsClient";
            this.TcpAsClient.Size = new System.Drawing.Size(573, 302);
            this.TcpAsClient.TabIndex = 0;
            this.TcpAsClient.TabStop = false;
            this.TcpAsClient.Text = "TCP client";
            // 
            // cbTcpClientHexMode
            // 
            this.cbTcpClientHexMode.AutoSize = true;
            this.cbTcpClientHexMode.Location = new System.Drawing.Point(169, 88);
            this.cbTcpClientHexMode.Name = "cbTcpClientHexMode";
            this.cbTcpClientHexMode.Size = new System.Drawing.Size(81, 22);
            this.cbTcpClientHexMode.TabIndex = 6;
            this.cbTcpClientHexMode.Text = "HexMode";
            this.cbTcpClientHexMode.UseVisualStyleBackColor = true;
            // 
            // cbTcpClientShowHexData
            // 
            this.cbTcpClientShowHexData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTcpClientShowHexData.AutoSize = true;
            this.cbTcpClientShowHexData.Checked = true;
            this.cbTcpClientShowHexData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTcpClientShowHexData.Location = new System.Drawing.Point(378, 88);
            this.cbTcpClientShowHexData.Name = "cbTcpClientShowHexData";
            this.cbTcpClientShowHexData.Size = new System.Drawing.Size(112, 22);
            this.cbTcpClientShowHexData.TabIndex = 7;
            this.cbTcpClientShowHexData.Text = "show HexData";
            this.cbTcpClientShowHexData.UseVisualStyleBackColor = true;
            // 
            // tbTcpClientResponse
            // 
            this.tbTcpClientResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTcpClientResponse.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTcpClientResponse.HideSelection = false;
            this.tbTcpClientResponse.Location = new System.Drawing.Point(6, 118);
            this.tbTcpClientResponse.Multiline = true;
            this.tbTcpClientResponse.Name = "tbTcpClientResponse";
            this.tbTcpClientResponse.ReadOnly = true;
            this.tbTcpClientResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTcpClientResponse.Size = new System.Drawing.Size(561, 178);
            this.tbTcpClientResponse.TabIndex = 8;
            // 
            // btnTcpClientClear
            // 
            this.btnTcpClientClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTcpClientClear.Location = new System.Drawing.Point(496, 86);
            this.btnTcpClientClear.Name = "btnTcpClientClear";
            this.btnTcpClientClear.Size = new System.Drawing.Size(74, 25);
            this.btnTcpClientClear.TabIndex = 8;
            this.btnTcpClientClear.Text = "clear";
            this.btnTcpClientClear.UseVisualStyleBackColor = true;
            this.btnTcpClientClear.Click += new System.EventHandler(this.btnTcpClientClear_Click_1);
            // 
            // cbTcpClientAddTailLn
            // 
            this.cbTcpClientAddTailLn.AutoSize = true;
            this.cbTcpClientAddTailLn.Checked = true;
            this.cbTcpClientAddTailLn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTcpClientAddTailLn.Location = new System.Drawing.Point(75, 88);
            this.cbTcpClientAddTailLn.Name = "cbTcpClientAddTailLn";
            this.cbTcpClientAddTailLn.Size = new System.Drawing.Size(88, 22);
            this.cbTcpClientAddTailLn.TabIndex = 5;
            this.cbTcpClientAddTailLn.Text = "add tail \\n";
            this.cbTcpClientAddTailLn.UseVisualStyleBackColor = true;
            // 
            // btnTcpClientSend
            // 
            this.btnTcpClientSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTcpClientSend.Location = new System.Drawing.Point(496, 55);
            this.btnTcpClientSend.Name = "btnTcpClientSend";
            this.btnTcpClientSend.Size = new System.Drawing.Size(74, 25);
            this.btnTcpClientSend.TabIndex = 4;
            this.btnTcpClientSend.Text = "send";
            this.btnTcpClientSend.UseVisualStyleBackColor = true;
            this.btnTcpClientSend.Click += new System.EventHandler(this.btnTcpClientSend_Click);
            // 
            // tbTcpClientRequest
            // 
            this.tbTcpClientRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTcpClientRequest.Location = new System.Drawing.Point(75, 55);
            this.tbTcpClientRequest.Name = "tbTcpClientRequest";
            this.tbTcpClientRequest.Size = new System.Drawing.Size(415, 25);
            this.tbTcpClientRequest.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "request:";
            // 
            // tbTcpClientPort
            // 
            this.tbTcpClientPort.Location = new System.Drawing.Point(231, 24);
            this.tbTcpClientPort.MaxLength = 5;
            this.tbTcpClientPort.Name = "tbTcpClientPort";
            this.tbTcpClientPort.Size = new System.Drawing.Size(131, 25);
            this.tbTcpClientPort.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = ":";
            // 
            // tbTcpClientIp
            // 
            this.tbTcpClientIp.Location = new System.Drawing.Point(75, 24);
            this.tbTcpClientIp.MaxLength = 15;
            this.tbTcpClientIp.Name = "tbTcpClientIp";
            this.tbTcpClientIp.Size = new System.Drawing.Size(131, 25);
            this.tbTcpClientIp.TabIndex = 1;
            this.tbTcpClientIp.Text = "127.0.0.1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "ip : port";
            // 
            // TcpAsServer
            // 
            this.TcpAsServer.Controls.Add(this.cbTcpServerShowHexData);
            this.TcpAsServer.Controls.Add(this.cbTcpServerAddTailLn);
            this.TcpAsServer.Controls.Add(this.cbTcpServerEchoMode);
            this.TcpAsServer.Controls.Add(this.label17);
            this.TcpAsServer.Controls.Add(this.tbTcpServerResponse);
            this.TcpAsServer.Controls.Add(this.tbTcpServerRequest);
            this.TcpAsServer.Controls.Add(this.btnTcpServerClear);
            this.TcpAsServer.Controls.Add(this.btnTcpServerListen);
            this.TcpAsServer.Controls.Add(this.tbTcpServerPort);
            this.TcpAsServer.Controls.Add(this.label18);
            this.TcpAsServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcpAsServer.Location = new System.Drawing.Point(0, 0);
            this.TcpAsServer.Name = "TcpAsServer";
            this.TcpAsServer.Size = new System.Drawing.Size(573, 408);
            this.TcpAsServer.TabIndex = 0;
            this.TcpAsServer.TabStop = false;
            this.TcpAsServer.Text = "TCP server";
            // 
            // cbTcpServerShowHexData
            // 
            this.cbTcpServerShowHexData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTcpServerShowHexData.AutoSize = true;
            this.cbTcpServerShowHexData.Checked = true;
            this.cbTcpServerShowHexData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTcpServerShowHexData.Location = new System.Drawing.Point(374, 88);
            this.cbTcpServerShowHexData.Name = "cbTcpServerShowHexData";
            this.cbTcpServerShowHexData.Size = new System.Drawing.Size(112, 22);
            this.cbTcpServerShowHexData.TabIndex = 6;
            this.cbTcpServerShowHexData.Text = "show HexData";
            this.cbTcpServerShowHexData.UseVisualStyleBackColor = true;
            // 
            // cbTcpServerAddTailLn
            // 
            this.cbTcpServerAddTailLn.AutoSize = true;
            this.cbTcpServerAddTailLn.Checked = true;
            this.cbTcpServerAddTailLn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTcpServerAddTailLn.Location = new System.Drawing.Point(83, 88);
            this.cbTcpServerAddTailLn.Name = "cbTcpServerAddTailLn";
            this.cbTcpServerAddTailLn.Size = new System.Drawing.Size(88, 22);
            this.cbTcpServerAddTailLn.TabIndex = 4;
            this.cbTcpServerAddTailLn.Text = "add tail \\n";
            this.cbTcpServerAddTailLn.UseVisualStyleBackColor = true;
            // 
            // cbTcpServerEchoMode
            // 
            this.cbTcpServerEchoMode.AutoSize = true;
            this.cbTcpServerEchoMode.Location = new System.Drawing.Point(177, 88);
            this.cbTcpServerEchoMode.Name = "cbTcpServerEchoMode";
            this.cbTcpServerEchoMode.Size = new System.Drawing.Size(85, 22);
            this.cbTcpServerEchoMode.TabIndex = 5;
            this.cbTcpServerEchoMode.Text = "EchoMode";
            this.cbTcpServerEchoMode.UseVisualStyleBackColor = true;
            this.cbTcpServerEchoMode.CheckedChanged += new System.EventHandler(this.cbTcpServerEchoMode_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 18);
            this.label17.TabIndex = 27;
            this.label17.Text = "response:";
            // 
            // tbTcpServerResponse
            // 
            this.tbTcpServerResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTcpServerResponse.HideSelection = false;
            this.tbTcpServerResponse.Location = new System.Drawing.Point(83, 55);
            this.tbTcpServerResponse.Name = "tbTcpServerResponse";
            this.tbTcpServerResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTcpServerResponse.Size = new System.Drawing.Size(404, 25);
            this.tbTcpServerResponse.TabIndex = 2;
            // 
            // tbTcpServerRequest
            // 
            this.tbTcpServerRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTcpServerRequest.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTcpServerRequest.HideSelection = false;
            this.tbTcpServerRequest.Location = new System.Drawing.Point(6, 117);
            this.tbTcpServerRequest.Multiline = true;
            this.tbTcpServerRequest.Name = "tbTcpServerRequest";
            this.tbTcpServerRequest.ReadOnly = true;
            this.tbTcpServerRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTcpServerRequest.Size = new System.Drawing.Size(561, 285);
            this.tbTcpServerRequest.TabIndex = 25;
            // 
            // btnTcpServerClear
            // 
            this.btnTcpServerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTcpServerClear.Location = new System.Drawing.Point(492, 86);
            this.btnTcpServerClear.Name = "btnTcpServerClear";
            this.btnTcpServerClear.Size = new System.Drawing.Size(75, 25);
            this.btnTcpServerClear.TabIndex = 7;
            this.btnTcpServerClear.Text = "clear";
            this.btnTcpServerClear.UseVisualStyleBackColor = true;
            this.btnTcpServerClear.Click += new System.EventHandler(this.btnTcpServerClear_Click);
            // 
            // btnTcpServerListen
            // 
            this.btnTcpServerListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTcpServerListen.Location = new System.Drawing.Point(492, 55);
            this.btnTcpServerListen.Name = "btnTcpServerListen";
            this.btnTcpServerListen.Size = new System.Drawing.Size(75, 25);
            this.btnTcpServerListen.TabIndex = 3;
            this.btnTcpServerListen.Text = "listen";
            this.btnTcpServerListen.UseVisualStyleBackColor = true;
            this.btnTcpServerListen.Click += new System.EventHandler(this.btnTcpServerListen_Click);
            // 
            // tbTcpServerPort
            // 
            this.tbTcpServerPort.Location = new System.Drawing.Point(83, 24);
            this.tbTcpServerPort.MaxLength = 5;
            this.tbTcpServerPort.Name = "tbTcpServerPort";
            this.tbTcpServerPort.Size = new System.Drawing.Size(131, 25);
            this.tbTcpServerPort.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 18);
            this.label18.TabIndex = 21;
            this.label18.Text = "port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::NetworkViewer.Properties.Settings.Default, "NVLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Location = global::NetworkViewer.Properties.Settings.Default.NVLocation;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "NetworkView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbUdpSend.ResumeLayout(false);
            this.gbUdpSend.PerformLayout();
            this.gbUdpRecv.ResumeLayout(false);
            this.gbUdpRecv.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.UdpAsClient.ResumeLayout(false);
            this.UdpAsClient.PerformLayout();
            this.UdpAsServer.ResumeLayout(false);
            this.UdpAsServer.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.TcpAsClient.ResumeLayout(false);
            this.TcpAsClient.PerformLayout();
            this.TcpAsServer.ResumeLayout(false);
            this.TcpAsServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox UdpAsClient;
        private System.Windows.Forms.GroupBox UdpAsServer;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox TcpAsClient;
        private System.Windows.Forms.GroupBox TcpAsServer;
        private System.Windows.Forms.Button btnUdpClientClear;
        private System.Windows.Forms.CheckBox cbUdpClientAddTailLn;
        private System.Windows.Forms.Button btnUdpClientSend;
        private System.Windows.Forms.TextBox tbUdpClientRequest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUdpClientPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUdpClientIp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUdpClientResponse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUdpServerResponse;
        private System.Windows.Forms.TextBox tbUdpServerLog;
        private System.Windows.Forms.Button btnUdpServerListen;
        private System.Windows.Forms.TextBox tbUdpServerPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUdpServerClear;
        private System.Windows.Forms.CheckBox cbUdpServerEchoMode;
        private System.Windows.Forms.CheckBox cbUdpServerAddTailLn;
        private System.Windows.Forms.CheckBox cbUdpClientShowHexData;
        private System.Windows.Forms.CheckBox cbUdpServerShowHexData;
        private System.Windows.Forms.CheckBox cbTcpClientShowHexData;
        private System.Windows.Forms.TextBox tbTcpClientResponse;
        private System.Windows.Forms.Button btnTcpClientClear;
        private System.Windows.Forms.CheckBox cbTcpClientAddTailLn;
        private System.Windows.Forms.Button btnTcpClientSend;
        private System.Windows.Forms.TextBox tbTcpClientRequest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTcpClientPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTcpClientIp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbTcpServerShowHexData;
        private System.Windows.Forms.CheckBox cbTcpServerAddTailLn;
        private System.Windows.Forms.CheckBox cbTcpServerEchoMode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTcpServerResponse;
        private System.Windows.Forms.TextBox tbTcpServerRequest;
        private System.Windows.Forms.Button btnTcpServerClear;
        private System.Windows.Forms.Button btnTcpServerListen;
        private System.Windows.Forms.TextBox tbTcpServerPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbUdpSend;
        private System.Windows.Forms.Button btnUdpSendClear;
        private System.Windows.Forms.CheckBox cbUdpSendHexMode;
        private System.Windows.Forms.CheckBox cbUdpSendAddLn;
        private System.Windows.Forms.TextBox tbUdpSend;
        private System.Windows.Forms.Button tbnUdpSend;
        private System.Windows.Forms.TextBox tbUdpSendPayload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUdpSendPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUdpSendIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUdpRecv;
        private System.Windows.Forms.CheckBox cbUdpRecvShowHexData;
        private System.Windows.Forms.TextBox tbUdpRecv;
        private System.Windows.Forms.Button btnUdpRecvClear;
        private System.Windows.Forms.Button btnUdpRecvListen;
        private System.Windows.Forms.TextBox tbUdpRecvPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbUdpClientHexMode;
        private System.Windows.Forms.CheckBox cbTcpClientHexMode;
    }
}

