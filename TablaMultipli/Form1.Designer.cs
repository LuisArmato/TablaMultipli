namespace TablaMultipli
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
            panelTapete = new Panel();
            richTextBoxResults = new RichTextBox();
            buttonGenerate = new Button();
            textBoxNum = new TextBox();
            labelNum = new Label();
            labelTitle = new Label();
            labelAlumno = new Label();
            labelEntrega = new Label();
            panelTapete.SuspendLayout();
            SuspendLayout();
            // 
            // panelTapete
            // 
            panelTapete.BackColor = Color.Snow;
            panelTapete.Controls.Add(labelEntrega);
            panelTapete.Controls.Add(labelAlumno);
            panelTapete.Controls.Add(richTextBoxResults);
            panelTapete.Controls.Add(buttonGenerate);
            panelTapete.Controls.Add(textBoxNum);
            panelTapete.Controls.Add(labelNum);
            panelTapete.Controls.Add(labelTitle);
            panelTapete.Location = new Point(39, 16);
            panelTapete.Name = "panelTapete";
            panelTapete.Size = new Size(900, 675);
            panelTapete.TabIndex = 0;
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResults.Location = new Point(410, 250);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(250, 350);
            richTextBoxResults.TabIndex = 4;
            richTextBoxResults.Text = "";
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.ForestGreen;
            buttonGenerate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerate.ForeColor = Color.White;
            buttonGenerate.Location = new Point(135, 250);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(135, 45);
            buttonGenerate.TabIndex = 3;
            buttonGenerate.Text = "Generar Tabla";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNum.Location = new Point(300, 160);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(111, 34);
            textBoxNum.TabIndex = 2;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNum.Location = new Point(60, 160);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(215, 31);
            labelNum.TabIndex = 1;
            labelNum.Text = "¿Qué tabla quieres?";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(300, 70);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(266, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Tabla de Multiplicar";
            // 
            // labelAlumno
            // 
            labelAlumno.AutoSize = true;
            labelAlumno.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlumno.ForeColor = Color.FromArgb(64, 64, 64);
            labelAlumno.Location = new Point(10, 10);
            labelAlumno.Name = "labelAlumno";
            labelAlumno.Size = new Size(479, 20);
            labelAlumno.TabIndex = 5;
            labelAlumno.Text = "// Alumno: Luis Manuel Ibrahim González Sánchez";
            // 
            // labelEntrega
            // 
            labelEntrega.AutoSize = true;
            labelEntrega.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEntrega.ForeColor = Color.FromArgb(64, 64, 64);
            labelEntrega.Location = new Point(410, 644);
            labelEntrega.Name = "labelEntrega";
            labelEntrega.Size = new Size(429, 20);
            labelEntrega.TabIndex = 6;
            labelEntrega.Text = "// Código: Tabla de Multiplicar (ver. 1.0)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 703);
            Controls.Add(panelTapete);
            Name = "Form1";
            Text = "Form1";
            panelTapete.ResumeLayout(false);
            panelTapete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTapete;
        private Label labelTitle;
        private TextBox textBoxNum;
        private Label labelNum;
        private Button buttonGenerate;
        private RichTextBox richTextBoxResults;
        private Label labelAlumno;
        private Label labelEntrega;
    }
}
