namespace Binari_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Convert to decimal number

            if (radioButton1.Checked == true)
            {
                double resultadodecimal = 0;
                int it = 0;

                for(double i = Math.Pow( 2 ,Convert.ToDouble( textBox1.Text.Length - 1 )); i >= 1; i = i / 2 ) {

                    try
                    {
                        if (textBox1.Text[it] != '0') resultadodecimal = resultadodecimal + i;

                        it++;
                    }
                    catch (Exception ex)
                    {   
                        MessageBox.Show("Error" + ex.ToString());
                        return;
                    }

                    
                }

                textBox2.Text = resultadodecimal.ToString();
            }

            // Convert to binari number

            if ( radioButton2.Checked == true)
            {
                System.UInt64 numero = 0;
                try
                {   
                    numero = Convert.ToUInt64(textBox1.Text);
                    
                }
                catch( OverflowException ex)
                {
                    MessageBox.Show("Error " + ex.ToString() + " Máximo 64 bits = 18446744073709551615");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());                    
                }
                
                System.UInt64 resto = 0;                

                string resultado = "";

                do
                {
                    resto = numero % 2;
                  
                    if (resto == 1) resultado = resultado.Insert(0, "1");
                    else resultado = resultado = resultado.Insert(0, "0");
                    numero = numero / 2;
             
                    if (numero == 1 ) resultado = resultado.Insert(0, "1");
                } while(numero > 1);
                
                textBox2.Text = resultado;
            }
            
            
        }
    }
}