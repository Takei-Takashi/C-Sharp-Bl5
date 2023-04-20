namespace Slot_12
{
	partial class Add_new_Order
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			comboBox3 = new ComboBox();
			dateTimePicker1 = new DateTimePicker();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			label6 = new Label();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton3 = new RadioButton();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(230, 30);
			label1.TabIndex = 0;
			label1.Text = "Add new Order";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 67);
			label2.Name = "label2";
			label2.Size = new Size(65, 15);
			label2.TabIndex = 1;
			label2.Text = "Employee :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 125);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 2;
			label3.Text = "Customer :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 182);
			label4.Name = "label4";
			label4.Size = new Size(53, 15);
			label4.TabIndex = 3;
			label4.Text = "Shipper :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 238);
			label5.Name = "label5";
			label5.Size = new Size(90, 15);
			label5.TabIndex = 4;
			label5.Text = "Required Date : ";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(138, 64);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(234, 23);
			comboBox1.TabIndex = 5;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(138, 122);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(234, 23);
			comboBox2.TabIndex = 6;
			// 
			// comboBox3
			// 
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(138, 179);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(234, 23);
			comboBox3.TabIndex = 7;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(138, 232);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(234, 23);
			dateTimePicker1.TabIndex = 8;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(411, 64);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(845, 374);
			dataGridView1.TabIndex = 9;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(276, 368);
			button1.Name = "button1";
			button1.Size = new Size(96, 38);
			button1.TabIndex = 10;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(411, 24);
			label6.Name = "label6";
			label6.Size = new Size(76, 15);
			label6.TabIndex = 11;
			label6.Text = "List Product :";
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(870, 22);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(63, 19);
			radioButton1.TabIndex = 12;
			radioButton1.TabStop = true;
			radioButton1.Text = "Default";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(966, 22);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(47, 19);
			radioButton2.TabIndex = 13;
			radioButton2.TabStop = true;
			radioButton2.Text = "ASC";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(1054, 22);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(53, 19);
			radioButton3.TabIndex = 14;
			radioButton3.TabStop = true;
			radioButton3.Text = "DESC";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged;
			// 
			// Add_new_Order
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1282, 450);
			Controls.Add(radioButton3);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(label6);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(dateTimePicker1);
			Controls.Add(comboBox3);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Add_new_Order";
			Text = "Add_new_Order";
			Load += Add_new_Order_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private ComboBox comboBox3;
		private DateTimePicker dateTimePicker1;
		private DataGridView dataGridView1;
		private Button button1;
		private Label label6;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private RadioButton radioButton3;
	}
}