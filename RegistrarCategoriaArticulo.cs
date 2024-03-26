using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class RegistrarCategoriaArticulo
    {
        public bool GuardarCategoria(Categoria_Articulo nuevacategoria)
        {
            bool categoria_ingresada = false;

            Categoria_Articulo[] Categoria = Categoria_ArticuloAD.ConsultarCategorias();

            for(int i = 0; i < Categoria.Length; i++)
            {
                if (Categoria[i] != null && Categoria[i].IDCategoria == nuevacategoria.IDCategoria)
                {
                    categoria_ingresada = true;
                    break;
                }
            }

            if (categoria_ingresada) 
            {
                return false;
            }
            else 
            { 
                return Categoria_ArticuloAD.GuardarCategoria(nuevacategoria);
            }
        }

        public Categoria_Articulo[] Consultar()
        {
            return Categoria_ArticuloAD.ConsultarCategorias();
        }
    }
}
