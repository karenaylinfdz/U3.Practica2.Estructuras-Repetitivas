namespace WinFormsApp13
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
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 73);
            label1.Name = "label1";
            label1.Size = new Size(361, 29);
            label1.TabIndex = 0;
            label1.Text = "Genera Numeros de 1 al 20 con While";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(189, 234);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 1;
            button1.Text = "Imprime la pantalla";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Salmon;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            listBox1.Location = new Point(495, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(103, 289);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox listBox1;
    }
}
