using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Composite
{
    //se crea otra clase abstracta en la cual definiremos como se agregaran los costos de los pasteles y se agregaran los ingredientes que se vayan ingresando
    class PastelComposite : Component
    {
        private List<Component> ingredientes = new List<Component>();

        public decimal CostoTotal
        {
            get
            {
                decimal costo = 0;
                foreach( var oElemento in ingredientes)
                {
                    if (oElemento.GetType().Name == "PastelComposite")
                        costo += ((PastelComposite)oElemento).CostoTotal;
                    else
                        costo += oElemento.Costo;
                }
                return costo;

            }
        }

        public void Add(Component oElemento)
        {
            ingredientes.Add(oElemento);
        }
        public void Remove(Component oElemento)
        {
            ingredientes.Remove(oElemento);
        }

        public PastelComposite(string Nombre, decimal Costo = 0): base (Nombre, Costo) 
        {
        }
    }
}
