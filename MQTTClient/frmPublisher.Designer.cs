namespace MQTTClient
{
    partial class frmPublisher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtxtMessage = new RichTextBox();
            btnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIPBroker = new TextBox();
            txtPort = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            groupBox1 = new GroupBox();
            btnConnect = new Button();
            btnDisconnect = new Button();
            rtxtCrypto = new RichTextBox();
            groupBox2 = new GroupBox();
            txtTopic = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rtxtMessage
            // 
            rtxtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtMessage.Location = new Point(6, 22);
            rtxtMessage.Name = "rtxtMessage";
            rtxtMessage.Size = new Size(300, 98);
            rtxtMessage.TabIndex = 0;
            rtxtMessage.Text = "\"Olá do C#! 🚀\"";
            // 
            // btnButton
            // 
            btnButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnButton.Location = new Point(249, 427);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(75, 23);
            btnButton.TabIndex = 1;
            btnButton.Text = "Publish";
            btnButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "IP MQTT Broker:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtIPBroker
            // 
            txtIPBroker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIPBroker.Location = new Point(109, 6);
            txtIPBroker.Name = "txtIPBroker";
            txtIPBroker.Size = new Size(215, 23);
            txtIPBroker.TabIndex = 6;
            txtIPBroker.Text = "10.11.102.123";
            // 
            // txtPort
            // 
            txtPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPort.Location = new Point(109, 35);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(215, 23);
            txtPort.TabIndex = 7;
            txtPort.Text = "8883";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(109, 64);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(215, 23);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(109, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(215, 23);
            txtPassword.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(rtxtMessage);
            groupBox1.Location = new Point(12, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 129);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Message";
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnect.Location = new Point(247, 263);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 11;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(166, 263);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 12;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // rtxtCrypto
            // 
            rtxtCrypto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtCrypto.Location = new Point(6, 22);
            rtxtCrypto.Name = "rtxtCrypto";
            rtxtCrypto.Size = new Size(300, 78);
            rtxtCrypto.TabIndex = 13;
            rtxtCrypto.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(rtxtCrypto);
            groupBox2.Location = new Point(12, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 106);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "TLS/SSL";
            // 
            // txtTopic
            // 
            txtTopic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTopic.Location = new Point(109, 122);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(215, 23);
            txtTopic.TabIndex = 15;
            txtTopic.Text = "teste/topico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "Topic:";
            // 
            // frmPublisher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(label5);
            Controls.Add(txtTopic);
            Controls.Add(groupBox2);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(groupBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPort);
            Controls.Add(txtIPBroker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnButton);
            MinimumSize = new Size(350, 500);
            Name = "frmPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publisher MQTT";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtMessage;
        private Button btnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIPBroker;
        private TextBox txtPort;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private GroupBox groupBox1;
        private Button btnConnect;
        private Button btnDisconnect;
        private RichTextBox rtxtCrypto;
        private GroupBox groupBox2;
        private TextBox txtTopic;
        private Label label5;
    }
}
