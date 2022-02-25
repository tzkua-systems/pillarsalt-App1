namespace WindowsFormsApp1
{
    partial class Arduino1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.progressBar_statusBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_textSent = new System.Windows.Forms.TextBox();
            this.richTextBox_textReceiver = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.progressBar_statusBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_baudRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(153, 202);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(93, 48);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(45, 202);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(93, 48);
            this.button_open.TabIndex = 6;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // progressBar_statusBar
            // 
            this.progressBar_statusBar.Location = new System.Drawing.Point(153, 120);
            this.progressBar_statusBar.Name = "progressBar_statusBar";
            this.progressBar_statusBar.Size = new System.Drawing.Size(140, 23);
            this.progressBar_statusBar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "STATUS :";
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(153, 74);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(140, 32);
            this.comboBox_baudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "BAUD RATE :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(153, 146);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(144, 24);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "DISCONNECTED";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(153, 28);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(140, 32);
            this.comboBox_comPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT :";
            // 
            // textBox_textSent
            // 
            this.textBox_textSent.Location = new System.Drawing.Point(320, 8);
            this.textBox_textSent.Name = "textBox_textSent";
            this.textBox_textSent.Size = new System.Drawing.Size(264, 32);
            this.textBox_textSent.TabIndex = 1;
            // 
            // richTextBox_textReceiver
            // 
            this.richTextBox_textReceiver.Location = new System.Drawing.Point(320, 46);
            this.richTextBox_textReceiver.Name = "richTextBox_textReceiver";
            this.richTextBox_textReceiver.Size = new System.Drawing.Size(360, 252);
            this.richTextBox_textReceiver.TabIndex = 2;
            this.richTextBox_textReceiver.Text = "";
            this.richTextBox_textReceiver.TextChanged += new System.EventHandler(this.richTextBox_textReceiver_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(590, 12);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(90, 28);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Arduino1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.richTextBox_textReceiver);
            this.Controls.Add(this.textBox_textSent);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Arduino1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino and C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Arduino1_FormClosing);
            this.Load += new System.EventHandler(this.Arduino1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ProgressBar progressBar_statusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_textSent;
        private System.Windows.Forms.RichTextBox richTextBox_textReceiver;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

