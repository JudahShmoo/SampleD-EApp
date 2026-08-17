namespace CustomWFA
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
			large = new Button();
			small = new Button();
			close = new Button();
			open = new Button();
			SuspendLayout();
			// 
			// large
			// 
			large.Location = new Point(140, 115);
			large.Name = "large";
			large.Size = new Size(207, 23);
			large.TabIndex = 1;
			large.Text = "Maketh the window largeth";
			large.UseVisualStyleBackColor = true;
			large.Click += Large_Click;
			// 
			// small
			// 
			small.Location = new Point(364, 115);
			small.Name = "small";
			small.Size = new Size(183, 23);
			small.TabIndex = 2;
			small.Text = "Maketh the window smalleth";
			small.UseVisualStyleBackColor = true;
			small.Click += Small_Click;
			// 
			// close
			// 
			close.Location = new Point(163, 197);
			close.Name = "close";
			close.Size = new Size(195, 23);
			close.TabIndex = 3;
			close.Text = "closeth the window";
			close.UseVisualStyleBackColor = true;
			close.Click += Close_Click;
			// 
			// open
			// 
			open.Location = new Point(389, 197);
			open.Name = "open";
			open.Size = new Size(232, 23);
			open.TabIndex = 4;
			open.Text = "openth a new windoweth";
			open.UseVisualStyleBackColor = true;
			open.Click += Open_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(open);
			Controls.Add(close);
			Controls.Add(small);
			Controls.Add(large);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion
		private Button large;
		private Button small;
		private Button close;
		private Button open;
	}
}
