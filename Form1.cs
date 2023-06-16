namespace Campo_electrico_programa
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           


            if (textBox_q1_1.Text.Trim() == "" || textBox_q1_2.Text.Trim() == "" || textBox_q1_potencia.Text.Trim() == "" || textBox_q2_1.Text.Trim() == "" || textBox_q2_2.Text.Trim() == "" || textBox_q2_potencia.Text.Trim() == "")
            {
                MessageBox.Show("rellenar todos los campos");
            }
            else
            {

                decimal q1_1 = 0;
                decimal q1_2 = 0;
                decimal q1_potencia = 0;
                decimal q2 = 0;
                q1_1 = Convert.ToDecimal(this.textBox_q1_1.Text);
                q1_2 = Convert.ToDecimal(this.textBox_q1_2.Text);
                q1_potencia = Convert.ToDecimal(this.textBox_q1_potencia.Text);
                q2 = q1_2;
                for (int i = 2; i <= q1_potencia; i++)
                {
                    q2 = q2 * q1_2;
                }
                q2 = q2 * q1_1;



                decimal q2_1 = 0;
                decimal q2_2 = 0;
                decimal q2_potencia = 0;
                decimal q3 = 0;
                q2_1 = Convert.ToDecimal(this.textBox_q2_1.Text);
                q2_2 = Convert.ToDecimal(this.textBox_q2_2.Text);
                q2_potencia = Convert.ToDecimal(this.textBox_q2_potencia.Text);
                q3 = q2_2;
                for (int i = 2; i <= q2_potencia; i++)
                {
                    q3 = q3 * q2_2;
                }
                q3 = q3 * q2_1;



                decimal resultado = q2 / q3 * 1000;



                this.label_resultado.Text = resultado.ToString();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yo_enano ventana = new yo_enano();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}