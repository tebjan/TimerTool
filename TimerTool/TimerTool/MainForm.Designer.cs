/*
 * Created by SharpDevelop.
 * User: Tebjan Halm
 * Date: 21.01.2014
 * Time: 16:55
 * 
 * 
 */
namespace TimerTool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.InfoGroupBox = new System.Windows.Forms.GroupBox();
			this.MinMaxLabel = new System.Windows.Forms.Label();
			this.ModifyGroupBox = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.EndButton = new System.Windows.Forms.Button();
			this.BeginButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.InfoGroupBox.SuspendLayout();
			this.ModifyGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// InfoGroupBox
			// 
			this.InfoGroupBox.Controls.Add(this.MinMaxLabel);
			this.InfoGroupBox.Location = new System.Drawing.Point(12, 12);
			this.InfoGroupBox.Name = "InfoGroupBox";
			this.InfoGroupBox.Size = new System.Drawing.Size(230, 56);
			this.InfoGroupBox.TabIndex = 1;
			this.InfoGroupBox.TabStop = false;
			this.InfoGroupBox.Text = "Timer Info";
			// 
			// MinMaxLabel
			// 
			this.MinMaxLabel.Location = new System.Drawing.Point(6, 30);
			this.MinMaxLabel.Name = "MinMaxLabel";
			this.MinMaxLabel.Size = new System.Drawing.Size(216, 23);
			this.MinMaxLabel.TabIndex = 1;
			this.MinMaxLabel.Text = "label1";
			// 
			// ModifyGroupBox
			// 
			this.ModifyGroupBox.Controls.Add(this.numericUpDown1);
			this.ModifyGroupBox.Controls.Add(this.EndButton);
			this.ModifyGroupBox.Controls.Add(this.BeginButton);
			this.ModifyGroupBox.Controls.Add(this.label1);
			this.ModifyGroupBox.Location = new System.Drawing.Point(12, 74);
			this.ModifyGroupBox.Name = "ModifyGroupBox";
			this.ModifyGroupBox.Size = new System.Drawing.Size(230, 89);
			this.ModifyGroupBox.TabIndex = 2;
			this.ModifyGroupBox.TabStop = false;
			this.ModifyGroupBox.Text = "Modify Timer";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(6, 27);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.numericUpDown1.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// EndButton
			// 
			this.EndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EndButton.Location = new System.Drawing.Point(123, 53);
			this.EndButton.Name = "EndButton";
			this.EndButton.Size = new System.Drawing.Size(99, 30);
			this.EndButton.TabIndex = 3;
			this.EndButton.Text = "End Timer Period";
			this.EndButton.UseVisualStyleBackColor = true;
			this.EndButton.Click += new System.EventHandler(this.EndButtonClick);
			// 
			// BeginButton
			// 
			this.BeginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BeginButton.Location = new System.Drawing.Point(6, 53);
			this.BeginButton.Name = "BeginButton";
			this.BeginButton.Size = new System.Drawing.Size(110, 30);
			this.BeginButton.TabIndex = 2;
			this.BeginButton.Text = "Begin Timer Period";
			this.BeginButton.UseVisualStyleBackColor = true;
			this.BeginButton.Click += new System.EventHandler(this.BeginButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(53, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "ms";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 175);
			this.Controls.Add(this.ModifyGroupBox);
			this.Controls.Add(this.InfoGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "TimerTool";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.InfoGroupBox.ResumeLayout(false);
			this.ModifyGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BeginButton;
		private System.Windows.Forms.Button EndButton;
		private System.Windows.Forms.GroupBox ModifyGroupBox;
		private System.Windows.Forms.GroupBox InfoGroupBox;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label MinMaxLabel;
	}
}
