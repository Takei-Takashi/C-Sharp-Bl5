namespace Demo_PE_Q2
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
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			comboBox1 = new ComboBox();
			dateTimePicker1 = new DateTimePicker();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(702, 426);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(dateTimePicker1);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(735, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(338, 426);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Current Employee";
			// 
			// button3
			// 
			button3.Location = new Point(235, 305);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 13;
			button3.Text = "Edit";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(131, 305);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 12;
			button2.Text = "Add";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(26, 305);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 11;
			button1.Text = "Refresh";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(106, 246);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(173, 23);
			comboBox1.TabIndex = 10;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(106, 187);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(204, 23);
			dateTimePicker1.TabIndex = 9;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(216, 135);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(63, 19);
			radioButton2.TabIndex = 8;
			radioButton2.TabStop = true;
			radioButton2.Text = "Female";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(106, 135);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(51, 19);
			radioButton1.TabIndex = 7;
			radioButton1.TabStop = true;
			radioButton1.Text = "Male";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(106, 80);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(204, 23);
			textBox2.TabIndex = 6;
			// 
			// textBox1
			// 
			textBox1.Enabled = false;
			textBox1.Location = new Point(106, 31);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(26, 249);
			label5.Name = "label5";
			label5.Size = new Size(50, 15);
			label5.TabIndex = 4;
			label5.Text = "Position";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(26, 193);
			label4.Name = "label4";
			label4.Size = new Size(31, 15);
			label4.TabIndex = 3;
			label4.Text = "DOB";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(26, 137);
			label3.Name = "label3";
			label3.Size = new Size(25, 15);
			label3.TabIndex = 2;
			label3.Text = "Sex";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 83);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 1;
			label2.Text = "Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 34);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 0;
			label1.Text = "ID";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1085, 450);
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
		private DateTimePicker dateTimePicker1;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button button3;
		private Button button2;
		private Button button1;
		private ComboBox comboBox1;
	}
}