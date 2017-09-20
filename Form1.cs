using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace GY521Panel
{
	public partial class Form1 : Form
	{
		private System.IO.Ports.SerialPort serialPort1;
		private Thread readThread = null;
		delegate void SetTextCallback(string text);
		private string message = "";
		private double maxPitch = 80;
		private double maxRoll = 80;


		public Form1()
		{
			InitializeComponent();
			getAvailablePorts();

			this.compass.BackColor = System.Drawing.Color.Black;
			this.compass.Image = Compass.DrawCompass(0, 0, this.maxPitch, 0, this.maxRoll, this.compass.Size);

			this.pitchRoll.BackColor = System.Drawing.Color.Black;
			this.pitchRoll.Image = PitchRoll.DrawPitchRoll(0, 0, this.pitchRoll.Size);
		}

		void getAvailablePorts()
		{
			String[] ports = SerialPort.GetPortNames();
			this.portName.Items.Clear();
			this.portName.Items.AddRange(ports);
		}

		private void btnOpenPort_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.portName.Text == "" || baudRate.Text == "")
				{
					this.messageReceived.Text = "Please select port settings.";
				}
				else
				{
					System.ComponentModel.IContainer components = new System.ComponentModel.Container();
					this.serialPort1 = new System.IO.Ports.SerialPort(components);
					this.serialPort1.PortName = portName.Text;
					this.serialPort1.BaudRate = Convert.ToInt32(baudRate.Text);
					this.serialPort1.ReadTimeout = 5000;
					this.serialPort1.WriteTimeout = 500;
					this.serialPort1.DtrEnable = true;
					this.serialPort1.Open();
					this.btnSend.Enabled = true;
					this.messageSent.Enabled = true;
					this.messageReceived.Enabled = true;
					this.btnOpenPort.Enabled = false;
					this.btnClosePort.Enabled = true;
					this.btnRefresh.Enabled = false;

					this.readThread = new Thread(new ThreadStart(read));
					this.readThread.Start();

				}
			}
			catch (UnauthorizedAccessException)
			{
				this.messageReceived.Text = "Unauthorized Access";
			}
		}


		private void read()
		{
			while (this.serialPort1.IsOpen)
			{
				try
				{
					if (this.serialPort1.BytesToRead > 0)
					{
						this.message = serialPort1.ReadLine();
						this.setText(message);
						if (message.Length > 0 && message.IndexOf("ypr") == 0)
						{
							string[] splitMessage = message.Split('\t');
							double yaw = Double.Parse(splitMessage[1]);
							double pitch = Double.Parse(splitMessage[2]);
							double roll = Double.Parse(splitMessage[3]);
							this.compass.Image = Compass.DrawCompass(yaw, pitch, this.maxPitch, roll, this.maxRoll, this.compass.Size);
							this.pitchRoll.Image = PitchRoll.DrawPitchRoll(pitch, roll, this.pitchRoll.Size);
						}
					}
				}
				catch (TimeoutException) { }
			}
		}

		private void setText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.messageReceived.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(setText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.messageReceived.AppendText(Environment.NewLine);
				this.messageReceived.AppendText(text);
				
			}
		}


		private void btnClosePort_Click(object sender, EventArgs e)
		{
			this.btnClosePort.Enabled = false;
			this.btnSend.Enabled = false;
			this.messageSent.Enabled = false;
			this.messageReceived.Clear();
			this.btnRefresh.Enabled = true;
			//messageReceived.Enabled = false;

			closeThread(readThread);
			closePort();

			this.btnOpenPort.Enabled = true;
			this.messageReceived.Enabled = false;
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (this.serialPort1.IsOpen) {
				this.serialPort1.WriteLine(messageSent.Text);
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			closeThread(readThread);
			closePort();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			getAvailablePorts();
			this.messageReceived.Clear();
			this.messageSent.Clear();
			this.pitchRoll.Image = PitchRoll.DrawPitchRoll(0, 0, this.pitchRoll.Size);
			this.compass.Image = Compass.DrawCompass(0, 0, this.maxPitch, 0, this.maxRoll, this.compass.Size);
		}

		private void closePort() {
			try
			{
				this.serialPort1.Close();
				this.messageReceived.AppendText(this.serialPort1.IsOpen ? "Port close fails!" : "Port is closed.");
				this.messageReceived.AppendText(Environment.NewLine);
			}
			catch (NullReferenceException e)
			{
				this.messageReceived.AppendText(e.Message.ToString());
			}

		}

		private void closeThread(Thread thread) {
			try
			{
				if (!(thread == null))
					thread.Abort();
				this.messageReceived.AppendText(thread.IsAlive ? "Read thread abort failed!" : "Read thread is aborted.");
				this.messageReceived.AppendText(Environment.NewLine);
			}
			catch (NullReferenceException e)
			{
				this.messageReceived.AppendText(e.Message.ToString());
			}
		}
	}
}
