namespace L9___JAP1129522
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string marca;
            int modelo, precio, cambio;
            modelo = Convert.ToInt16(txt_Modelo.Text);
            precio = Convert.ToInt16(txt_Precio.Text);
            marca = txt_Marca.Text;
            cambio = Convert.ToInt16(txt_TipodeCambioDolar.Text);

            if (int.TryParse(txt_Precio.Text, out int num))
            {
                MessageBox.Show("Debe ingresar un numero");
            }
            else
            {
                if (int.TryParse(txt_TipodeCambioDolar.Text, out int num1))
                {
                    MessageBox.Show("Debe ingresar numero no letra");
                }
                else
                {
                    if (int.TryParse(txt_DescuentoAplicado.Text, out int num2))
                    {
                        MessageBox.Show("Debe ingresar un numero");
                    }
                    else
                    {
                        if (int.TryParse(txt_Disponible.Text, out int num3))
                        {
                            MessageBox.Show("Debe ingresar un numero");
                        }
                        else
                        {
                        }
                        }

                    }
                   
                }
            }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Precio.Clear();
            txt_DescuentoAplicado.Clear();
            txt_Disponible.Clear();
            txt_Marca.Clear();
            txt_Modelo.Clear();
            txt_TipodeCambioDolar.Clear();
            txt_DescuentoAplicado.Clear();
            lbl_resultado.Text = "";
        }
    }
    }