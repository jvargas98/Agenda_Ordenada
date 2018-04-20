using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        Contacto[] personas = new Contacto[15];
        private int i = 0;
        private int ultimo = 0;
        public Agenda()
        {

        }
        public void Agregar(Contacto contacto)
        {
            int posicion = 0;
            if (i < personas.Length && i > 0)
            {
                for (int contador = 0;  personas[contador] != null; contador++)
                {
                    if (contacto.Telefono > 0 && contacto.Telefono > personas[contador].Telefono)
                    {
                        posicion++;
                    }
                }
                for (int contador = personas.Length-2; contador >= posicion; contador--)
                {
                    personas[contador + 1] = personas[contador];
                }
                personas[posicion] = contacto; 
                i++;
            }
            else
            {
                personas[posicion] = contacto;
                ultimo = i;
                i++;
            }
        }

        public Contacto Buscar(int telefono)
        {
            int contador = 0;
            Contacto contacto = null;
            while (contador < i && personas[contador].Telefono != telefono)
            {
                contador++;
            }
            if (contador < personas.Length - 1)
            {
                return contacto = personas[contador];
            }
            else
            {
                return contacto;
            }
        }

        public void Eliminar(int telefono)
        {
            int contador1 = 0;
            while (contador1 < i && personas[contador1].Telefono != telefono)
            {
                contador1++;
            }
            if (contador1 < personas.Length-1)
            {
                for (int contador2 = contador1; contador2 < personas.Length - 2; contador2++)
                {
                    personas[contador2] = personas[contador2 + 1];
                }
                i--;
            }
        }
        private void Insertar(int posicion, Contacto contacto)
        {
           
            for (int contador = personas.Length-2; contador >= posicion; contador--)
            {
               personas[contador+1] = personas[contador];
            }
            personas[posicion] = contacto;
            i++;
        }
        public override string ToString()
        {
            string cadena = "";
            int contador = 0;
            while(personas[contador] != null)
            {
                cadena += personas[contador].ToString();
                contador++;
            }
            return cadena;
        }
    }
}
