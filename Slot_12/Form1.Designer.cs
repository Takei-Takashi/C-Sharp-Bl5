namespace Slot_12
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
			label1 = new Label();
			comboBox1 = new ComboBox();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			label2 = new Label();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 21);
			label1.Name = "label1";
			label1.Size = new Size(96, 15);
			label1.TabIndex = 0;
			label1.Text = "Select Employee:";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(158, 18);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(252, 23);
			comboBox1.TabIndex = 1;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(158, 82);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(215, 23);
			dateTimePicker1.TabIndex = 2;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(556, 82);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(210, 23);
			dateTimePicker2.TabIndex = 3;
			dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(51, 86);
			label2.Name = "label2";
			label2.Size = new Size(65, 15);
			label2.TabIndex = 4;
			label2.Text = "From Date:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(484, 86);
			label3.Name = "label3";
			label3.Size = new Size(49, 15);
			label3.TabIndex = 5;
			label3.Text = "To Date:";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(30, 131);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(735, 307);
			dataGridView1.TabIndex = 6;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(30, 87);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(15, 14);
			checkBox1.TabIndex = 7;
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(463, 87);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(15, 14);
			checkBox2.TabIndex = 8;
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += checkBox2_CheckedChanged;
			// 
			// button1
			// 
			button1.Location = new Point(463, 17);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(144, 22);
			button1.TabIndex = 9;
			button1.Text = "Add new Order";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(dataGridView1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dateTimePicker2);
			Controls.Add(dateTimePicker1);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox comboBox1;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private Label label2;
		private Label label3;
		private DataGridView dataGridView1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private Button button1;
	}
}