
namespace Ejercicio1
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
            tbResultado = new TextBox();
            lbResultado = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(508, 64);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(78, 227);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(600, 172);
            tbResultado.TabIndex = 1;
            // 
            // lbResultado
            // 
            lbResultado.AccessibleName = "lbResultado";
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.ForeColor = SystemColors.ActiveCaptionText;
            lbResultado.Location = new Point(78, 209);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "lbResultado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(137, 64);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 4;
            button2.Text = "calcular promedio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(lbResultado);
            Controls.Add(tbResultado);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private TextBox tbResultado;
        private Label lbResultado;
        private TextBox textBox2;
        private Button button2;
    }
}
