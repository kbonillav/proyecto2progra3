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

/*Esta es la clase Categoria Artículo. Al igual que en la
 clase Hotel, se crean los atributos privados y los métodos
set y get para fijar sus valores. También se hizo el constructor
con parámetros al igual quen la clase anterior.*/

namespace Entidades;
public class Categoria_Articulo
{
    // Atributos privados
    private int IDCategoria_privado;
    private string DescripcionCategoria_privado;
    private bool StatusCategoria_privado;

    // Métodos set y get para los atributos
    public int IDCategoria
    {
        get { return IDCategoria_privado; }
        set { IDCategoria_privado = value; }
    }

    public string DescripcionCategoria
    {
        get { return DescripcionCategoria_privado; }
        set { DescripcionCategoria_privado = value; }
    }

    public bool StatusCategoria
    {
        get { return StatusCategoria_privado; }
        set { StatusCategoria_privado = value; }
    }

    public Categoria_Articulo(){}
}
