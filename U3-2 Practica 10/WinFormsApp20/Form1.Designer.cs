namespace WinFormsApp20
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
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Location = new Point(356, 388);
            button1.Name = "button1";
            button1.Size = new Size(127, 32);
            button1.TabIndex = 0;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(90, 199);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Info;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(254, 199);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 169);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.Info;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(426, 199);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 169);
            listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            listBox4.BackColor = SystemColors.Info;
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(589, 199);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 169);
            listBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 62);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 5;
            label1.Text = "Z=X^2 + X^3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(137, 159);
            label2.Name = "label2";
            label2.Size = new Size(23, 22);
            label2.TabIndex = 6;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(302, 159);
            label3.Name = "label3";
            label3.Size = new Size(45, 22);
            label3.TabIndex = 7;
            label3.Text = "X^2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(473, 159);
            label4.Name = "label4";
            label4.Size = new Size(45, 22);
            label4.TabIndex = 8;
            label4.Text = "X^3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.Location = new Point(639, 159);
            label5.Name = "label5";
            label5.Size = new Size(21, 22);
            label5.TabIndex = 9;
            label5.Text = "Z";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 471);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
