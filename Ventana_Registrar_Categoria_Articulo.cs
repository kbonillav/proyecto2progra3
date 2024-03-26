/*
* Universidad Estatal a Distancia
* Escuela de Ciencias Exactas y Naturales
* Cátedra de Tecnología de Sistemas
* 
* 00830 Programación Avanzada
* Proyecto 2: Servidor de Gestión Hotelera
* Estudiante: Kabir Bonilla Vega 1 1609 0008
* Fecha: 07 de abril de 2024
 */

/*Esta ventana implementa el método para crear las categorías
 de los artículos. Se implementa la lógica para limpiar los campos
y regresar al menú principal.*/

using Entidades;
using LogicaNegocio;
using Presentación;

namespace Presentacion
{
    public partial class Ventana_Registrar_Categoria_Articulo : Form
    {
        public Ventana_Registrar_Categoria_Articulo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string categoriavalida = ValidarDatosCategoria();

                if (string.IsNullOrWhiteSpace(categoriavalida))
                {

                    Categoria_Articulo nuevaCategoria = new Categoria_Articulo();
                    nuevaCategoria.IDCategoria = int.Parse(Entrada_categoria_1.Text);
                    nuevaCategoria.DescripcionCategoria = Entrada_categoria_2.Text;
                    string status_categoria = opcion_categoria_1.GetItemText(opcion_categoria_1.SelectedItem);
                    if (status_categoria.Equals("Activa"))
                    {
                        nuevaCategoria.StatusCategoria = true;
                    }
                    else
                    {
                        nuevaCategoria.StatusCategoria = false;
                    }

                    RegistrarCategoriaArticulo NuevaCategoria = new RegistrarCategoriaArticulo();
                    bool RegistroCorrecto = NuevaCategoria.GuardarCategoria(nuevaCategoria);

                    if (RegistroCorrecto) 
                    {
                        MessageBox.Show("Se ha guardado la categoría correctamente");
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("No se pudo guardar la categoría");
                    }
                }
                else 
                {
                    MessageBox.Show(categoriavalida);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un error, el formato no es el correcto");
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número ingresado no es válido porque es muy grande");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                //Aunque se podría mostrar el mensaje (ex.Message) de error no es una buena práctica ya que el usuario no 
                //entendería un mensaje técnico, normalmente se utiliza para bitácoras, etc.
                //MessageBox.Show("Ha ocurrido un error " + ex.Message);

                MessageBox.Show("Ha ocurrido un error contacte  al administrador");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana_Principal MenuPrincipal = new Ventana_Principal();
            MenuPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entrada_categoria_1.Text = String.Empty;
            Entrada_categoria_2.Text = String.Empty;
        }

        private string ValidarDatosCategoria()
        {
            string validacion = String.Empty;

            if (string.IsNullOrWhiteSpace(Entrada_categoria_1.Text)) 
            {
                Entrada_categoria_1.Focus();
                return "Debe agregar la ID de la categoría";
            }
            else if (string.IsNullOrWhiteSpace(Entrada_categoria_2.Text))
            {
                Entrada_categoria_2.Focus();
                return "Debe agregar una descripción para la categoría";
            }
            else if(opcion_categoria_1.SelectedItem == null)
            {
                opcion_categoria_1.Focus();
                return "Favor indicar el estado de la categoría";
            }
            return validacion;
        }
    }
}
