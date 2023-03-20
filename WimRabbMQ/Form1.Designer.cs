namespace WimRabbMQ
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCreateExc = new System.Windows.Forms.Button();
            this.btnCreateQue = new System.Windows.Forms.Button();
            this.btnBindQue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPubEm = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSMS = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 56);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT_MQ";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCreateExc
            // 
            this.btnCreateExc.Location = new System.Drawing.Point(8, 86);
            this.btnCreateExc.Name = "btnCreateExc";
            this.btnCreateExc.Size = new System.Drawing.Size(144, 56);
            this.btnCreateExc.TabIndex = 1;
            this.btnCreateExc.Text = "Create Exchange";
            this.btnCreateExc.UseVisualStyleBackColor = true;
            this.btnCreateExc.Click += new System.EventHandler(this.btnCreateExc_Click);
            // 
            // btnCreateQue
            // 
            this.btnCreateQue.Location = new System.Drawing.Point(8, 164);
            this.btnCreateQue.Name = "btnCreateQue";
            this.btnCreateQue.Size = new System.Drawing.Size(144, 56);
            this.btnCreateQue.TabIndex = 2;
            this.btnCreateQue.Text = "Create Queues";
            this.btnCreateQue.UseVisualStyleBackColor = true;
            this.btnCreateQue.Click += new System.EventHandler(this.btnCreateQue_Click);
            // 
            // btnBindQue
            // 
            this.btnBindQue.Location = new System.Drawing.Point(8, 240);
            this.btnBindQue.Name = "btnBindQue";
            this.btnBindQue.Size = new System.Drawing.Size(144, 56);
            this.btnBindQue.TabIndex = 3;
            this.btnBindQue.Text = "Bind Queues";
            this.btnBindQue.UseVisualStyleBackColor = true;
            this.btnBindQue.Click += new System.EventHandler(this.btnBindQue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnPubEm);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Location = new System.Drawing.Point(197, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publish Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(425, 72);
            this.textBox1.TabIndex = 6;
            // 
            // btnPubEm
            // 
            this.btnPubEm.Location = new System.Drawing.Point(332, 22);
            this.btnPubEm.Name = "btnPubEm";
            this.btnPubEm.Size = new System.Drawing.Size(105, 23);
            this.btnPubEm.TabIndex = 1;
            this.btnPubEm.Text = "Publish";
            this.btnPubEm.UseVisualStyleBackColor = true;
            this.btnPubEm.Click += new System.EventHandler(this.btnPubEm_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 22);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(305, 23);
            this.tbEmail.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbSMS);
            this.groupBox2.Location = new System.Drawing.Point(197, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 146);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publish SMS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(425, 72);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Publish";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbSMS
            // 
            this.tbSMS.Location = new System.Drawing.Point(6, 22);
            this.tbSMS.Name = "tbSMS";
            this.tbSMS.Size = new System.Drawing.Size(305, 23);
            this.tbSMS.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBindQue);
            this.Controls.Add(this.btnCreateQue);
            this.Controls.Add(this.btnCreateExc);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConnect;
        private Button btnCreateExc;
        private Button btnCreateQue;
        private Button btnBindQue;
        private GroupBox groupBox1;
        private Button btnPubEm;
        private TextBox tbEmail;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox tbSMS;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}