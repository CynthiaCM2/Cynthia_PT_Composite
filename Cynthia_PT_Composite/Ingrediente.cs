using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Cynthia_PT_Composite
{
    //Se crea la clase derivada de la clase abstracta para definir en este caso los conceptos de cantidad y unidad con si tipo de estructura
    class Ingrediente : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }

        public Ingrediente(String Nombre, decimal Costo, int Cantidad, string Unidad)
            :base(Nombre, Costo)
        {
            this.Cantidad = Cantidad;
            this .Unidad = Unidad;  
        }
    }
}
