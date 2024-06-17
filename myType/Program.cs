namespace Xcaim.MATCOM
{
    public class Libro
    {
        float descuento = 2;

        public Libro(string titulo, float precio)
        {
            string Titulo = titulo;
            float Precio = precio;
        }
        public string Titulo 
        { 
            get { return Titulo; } 
            private set { Titulo = value; }
        }
        public float Precio 
        { 
            get { return Precio; } 
            set { Precio = value - descuento; }
        }
    }
}