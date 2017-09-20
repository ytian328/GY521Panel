using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace GY521Panel
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.messageSent = new System.Windows.Forms.TextBox();
			this.portName = new System.Windows.Forms.ComboBox();
			this.baudRate = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.messageReceived = new System.Windows.Forms.TextBox();
			this.btnClosePort = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOpenPort = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.compass = new System.Windows.Forms.PictureBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.pitchRoll = new System.Windows.Forms.PictureBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.latitude = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.longitude = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.compass)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pitchRoll)).BeginInit();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSend);
			this.groupBox1.Controls.Add(this.messageSent);
			this.groupBox1.Location = new System.Drawing.Point(12, 130);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 51);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Send Data";
			// 
			// btnSend
			// 
			this.btnSend.Enabled = false;
			this.btnSend.Location = new System.Drawing.Point(245, 21);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// messageSent
			// 
			this.messageSent.Enabled = false;
			this.messageSent.Location = new System.Drawing.Point(6, 21);
			this.messageSent.Multiline = true;
			this.messageSent.Name = "messageSent";
			this.messageSent.Size = new System.Drawing.Size(219, 23);
			this.messageSent.TabIndex = 0;
			// 
			// portName
			// 
			this.portName.FormattingEnabled = true;
			this.portName.Location = new System.Drawing.Point(87, 21);
			this.portName.Name = "portName";
			this.portName.Size = new System.Drawing.Size(121, 24);
			this.portName.TabIndex = 1;
			// 
			// baudRate
			// 
			this.baudRate.FormattingEnabled = true;
			this.baudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
			this.baudRate.Location = new System.Drawing.Point(87, 53);
			this.baudRate.Name = "baudRate";
			this.baudRate.Size = new System.Drawing.Size(121, 24);
			this.baudRate.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.messageReceived);
			this.groupBox2.Location = new System.Drawing.Point(12, 189);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(325, 223);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Receive Data";
			// 
			// messageReceived
			// 
			this.messageReceived.Enabled = false;
			this.messageReceived.Location = new System.Drawing.Point(6, 21);
			this.messageReceived.Multiline = true;
			this.messageReceived.Name = "messageReceived";
			this.messageReceived.ReadOnly = true;
			this.messageReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.messageReceived.Size = new System.Drawing.Size(314, 196);
			this.messageReceived.TabIndex = 0;
			// 
			// btnClosePort
			// 
			this.btnClosePort.Enabled = false;
			this.btnClosePort.Location = new System.Drawing.Point(221, 52);
			this.btnClosePort.Name = "btnClosePort";
			this.btnClosePort.Size = new System.Drawing.Size(98, 24);
			this.btnClosePort.TabIndex = 5;
			this.btnClosePort.Text = "Close Port";
			this.btnClosePort.UseVisualStyleBackColor = true;
			this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Baud Rate";
			// 
			// btnOpenPort
			// 
			this.btnOpenPort.Location = new System.Drawing.Point(221, 20);
			this.btnOpenPort.Name = "btnOpenPort";
			this.btnOpenPort.Size = new System.Drawing.Size(98, 24);
			this.btnOpenPort.TabIndex = 9;
			this.btnOpenPort.Text = "Open Port";
			this.btnOpenPort.UseVisualStyleBackColor = true;
			this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnRefresh);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.btnClosePort);
			this.groupBox3.Controls.Add(this.btnOpenPort);
			this.groupBox3.Controls.Add(this.portName);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.baudRate);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(325, 112);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Port Connection";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(221, 83);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(98, 24);
			this.btnRefresh.TabIndex = 10;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.compass);
			this.groupBox4.Location = new System.Drawing.Point(360, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(500, 500);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Compass";
			// 
			// compass
			// 
			this.compass.Location = new System.Drawing.Point(6, 21);
			this.compass.Name = "compass";
			this.compass.Size = new System.Drawing.Size(488, 473);
			this.compass.TabIndex = 13;
			this.compass.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.pitchRoll);
			this.groupBox5.Location = new System.Drawing.Point(891, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(500, 500);
			this.groupBox5.TabIndex = 12;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Pitch and Roll";
			// 
			// pitchRoll
			// 
			this.pitchRoll.Location = new System.Drawing.Point(6, 21);
			this.pitchRoll.Name = "pitchRoll";
			this.pitchRoll.Size = new System.Drawing.Size(488, 473);
			this.pitchRoll.TabIndex = 14;
			this.pitchRoll.TabStop = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label4);
			this.groupBox6.Controls.Add(this.longitude);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.latitude);
			this.groupBox6.Location = new System.Drawing.Point(12, 418);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(320, 94);
			this.groupBox6.TabIndex = 13;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Location Info";
			// 
			// latitude
			// 
			this.latitude.Location = new System.Drawing.Point(96, 26);
			this.latitude.Name = "latitude";
			this.latitude.ReadOnly = true;
			this.latitude.Size = new System.Drawing.Size(206, 22);
			this.latitude.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Port Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Latitude";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "longitude";
			// 
			// longitude
			// 
			this.longitude.Location = new System.Drawing.Point(96, 54);
			this.longitude.Name = "longitude";
			this.longitude.ReadOnly = true;
			this.longitude.Size = new System.Drawing.Size(206, 22);
			this.longitude.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1399, 570);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "GY-521 Serial Communication";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.compass)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pitchRoll)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox messageSent;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.ComboBox portName;
		private System.Windows.Forms.ComboBox baudRate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox messageReceived;
		private System.Windows.Forms.Button btnClosePort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOpenPort;
		private System.Windows.Forms.GroupBox groupBox3;
		private GroupBox groupBox4;
		private GroupBox groupBox5;
		private PictureBox compass;
		private PictureBox pitchRoll;
		private Button btnRefresh;
		private Label label1;
		private GroupBox groupBox6;
		private Label label4;
		private TextBox longitude;
		private Label label3;
		private TextBox latitude;
	}
}

