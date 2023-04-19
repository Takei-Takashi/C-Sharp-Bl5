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
			label1.Location = new Point(34, 28);
			label1.Name = "label1";
			label1.Size = new Size(122, 20);
			label1.TabIndex = 0;
			label1.Text = "Select Employee:";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(181, 24);
			comboBox1.Margin = new Padding(3, 4, 3, 4);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(287, 28);
			comboBox1.TabIndex = 1;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(181, 109);
			dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(245, 27);
			dateTimePicker1.TabIndex = 2;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(635, 109);
			dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(239, 27);
			dateTimePicker2.TabIndex = 3;
			dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(58, 115);
			label2.Name = "label2";
			label2.Size = new Size(82, 20);
			label2.TabIndex = 4;
			label2.Text = "From Date:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(553, 115);
			label3.Name = "label3";
			label3.Size = new Size(64, 20);
			label3.TabIndex = 5;
			label3.Text = "To Date:";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(34, 175);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(840, 409);
			dataGridView1.TabIndex = 6;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(34, 116);
			checkBox1.Margin = new Padding(3, 4, 3, 4);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(18, 17);
			checkBox1.TabIndex = 7;
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(529, 116);
			checkBox2.Margin = new Padding(3, 4, 3, 4);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(18, 17);
			checkBox2.TabIndex = 8;
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += checkBox2_CheckedChanged;
			// 
			// button1
			// 
			button1.Location = new Point(529, 23);
			button1.Name = "button1";
			button1.Size = new Size(164, 29);
			button1.TabIndex = 9;
			button1.Text = "Add new Order";
			button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
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
			Margin = new Padding(3, 4, 3, 4);
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