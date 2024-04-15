namespace practica3._2
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(664, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(936, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(191, 231);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 4;
            button1.Text = "генерировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(729, 231);
            button2.Name = "button2";
            button2.Size = new Size(213, 29);
            button2.TabIndex = 5;
            button2.Text = "найти элементы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(69, 115);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 6;
            label1.Text = "количество элементов генерируемого массива";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 135);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 7;
            label2.Text = "сгенерированный массив";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 135);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 8;
            label3.Text = "индексы элементов";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(848, 135);
            label4.Name = "label4";
            label4.Size = new Size(248, 20);
            label4.TabIndex = 9;
            label4.Text = "количество найденных элементов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 516);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
