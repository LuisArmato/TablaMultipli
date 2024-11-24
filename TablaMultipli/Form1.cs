namespace TablaMultipli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            this.mostrarTabla();
        }

        private void mostrarTabla()
        {
            int num = Convert.ToInt32(this.textBoxNum.Text);
            string tabla = "";

            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + " " + num + " x " + i + " = " + (num * i) + "\n";
            }
            
            this.richTextBoxResults.AppendText(tabla);
        }
    }
}
