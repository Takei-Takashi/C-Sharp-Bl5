namespace Slot_9
{
	partial class Add_new_Product
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			checkBox1 = new CheckBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Enabled = false;
			textBox1.Location = new Point(176, 58);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(199, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(176, 104);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(199, 23);
			textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(176, 153);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(199, 23);
			textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(176, 201);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(199, 23);
			textBox4.TabIndex = 3;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(176, 249);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(199, 23);
			textBox5.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(52, 61);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 5;
			label1.Text = "ID";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(52, 107);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 6;
			label2.Text = "Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(52, 156);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 7;
			label3.Text = "Category";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(52, 204);
			label4.Name = "label4";
			label4.Size = new Size(33, 15);
			label4.TabIndex = 8;
			label4.Text = "Price";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(52, 252);
			label5.Name = "label5";
			label5.Size = new Size(51, 15);
			label5.TabIndex = 9;
			label5.Text = "Amount";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(52, 300);
			label6.Name = "label6";
			label6.Size = new Size(40, 15);
			label6.TabIndex = 10;
			label6.Text = "Active";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(176, 299);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(70, 19);
			checkBox1.TabIndex = 11;
			checkBox1.Text = "Is Active";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(386, 376);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 12;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Add_new_Product
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(499, 450);
			Controls.Add(button1);
			Controls.Add(checkBox1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Add_new_Product";
			Text = "Add_new_Product";
			Load += Add_new_Product_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private CheckBox checkBox1;
		private Button button1;
	}
}