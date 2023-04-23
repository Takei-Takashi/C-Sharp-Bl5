namespace Demo_PE_Q1
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
			dataGridView1 = new DataGridView();
			groupBox1 = new GroupBox();
			comboBox1 = new ComboBox();
			label3 = new Label();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			textBox1 = new TextBox();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(417, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(669, 426);
			dataGridView1.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(380, 426);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Filter";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "All positions", "Developer", "Leader", "Tester", "Manager" });
			comboBox1.Location = new Point(120, 172);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(236, 23);
			comboBox1.TabIndex = 15;
			comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(26, 175);
			label3.Name = "label3";
			label3.Size = new Size(50, 15);
			label3.TabIndex = 14;
			label3.Text = "Position";
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(251, 104);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(63, 19);
			radioButton3.TabIndex = 13;
			radioButton3.Text = "Female";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(154, 104);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(51, 19);
			radioButton2.TabIndex = 12;
			radioButton2.Text = "Male";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(26, 104);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(94, 19);
			radioButton1.TabIndex = 11;
			radioButton1.TabStop = true;
			radioButton1.Text = "Male/Female";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(120, 40);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(236, 23);
			textBox1.TabIndex = 10;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 43);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 9;
			label2.Text = "Name";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1098, 450);
			Controls.Add(groupBox1);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private DataGridView dataGridView1;
		private GroupBox groupBox1;
		private ComboBox comboBox1;
		private Label label3;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private TextBox textBox1;
		private Label label2;
	}
}