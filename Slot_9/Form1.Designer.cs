namespace Slot_9
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
			textBox1 = new TextBox();
			Browse = new OpenFileDialog();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			dataGridView1 = new DataGridView();
			Save = new SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(184, 44);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(702, 27);
			textBox1.TabIndex = 0;
			// 
			// Browse
			// 
			Browse.Filter = "Text Files|*.txt";
			Browse.FileOk += Browse_FileOk;
			// 
			// button1
			// 
			button1.Location = new Point(40, 44);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(137, 31);
			button1.TabIndex = 1;
			button1.Text = "Browse";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// button2
			// 
			button2.Location = new Point(184, 105);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(117, 31);
			button2.TabIndex = 2;
			button2.Text = "Load data";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(381, 105);
			button3.Margin = new Padding(3, 4, 3, 4);
			button3.Name = "button3";
			button3.Size = new Size(151, 31);
			button3.TabIndex = 3;
			button3.Text = "Add new Product";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(617, 105);
			button4.Margin = new Padding(3, 4, 3, 4);
			button4.Name = "button4";
			button4.Size = new Size(117, 31);
			button4.TabIndex = 4;
			button4.Text = "Save data";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(40, 167);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(847, 403);
			dataGridView1.TabIndex = 5;
			// 
			// Save
			// 
			Save.Filter = "Text files (*.txt)|*.txt";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(dataGridView1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private OpenFileDialog Browse;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private DataGridView dataGridView1;
		private SaveFileDialog Save;
	}
}