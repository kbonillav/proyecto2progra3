using Entidades;

namespace AccesoDatos
{
    public static class Categoria_ArticuloAD
    {
        private static Categoria_Articulo[] categorias = new Categoria_Articulo[20];
        private static int indicecategoria = 0;

        public static bool GuardarCategoria(Categoria_Articulo categoria)
        {
            try
            {
                categorias[indicecategoria] = categoria;
                indicecategoria++;
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("El repositorio esta lleno y no permite registrar más información");
            }
        }

        public static Categoria_Articulo[] ConsultarCategorias() 
        { 
            return categorias;
        }
    }
}
