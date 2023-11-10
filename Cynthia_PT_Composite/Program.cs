using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynthia_PT_Composite
{
    class Program
    {
        //En esta clase ya se definira los objetos con los datos que queremos visualizar al correr el codigo, visualizara ya con monto de costo y sus diferentes datos
        static void Main(string[] args)
        {
            Ingrediente oIngrediente1 = new Ingrediente("Harina", 100, 200, "gramos");
            Ingrediente oIngrediente2 = new Ingrediente("Leche", 20, 1, "litro");
            Ingrediente oIngrediente3 = new Ingrediente("Huevo", 20, 1, "kilo");

            PastelComposite oPastel = new PastelComposite("Pastel de leche");
            oPastel.Add(oIngrediente1);
            oPastel.Add(oIngrediente2);
            oPastel.Add(oIngrediente3);

            Console.WriteLine(oPastel.Costo);

            Ingrediente oIngrediente4 = new Ingrediente("Chocolate", 200, 1, "litro");
            PastelComposite oPastelChocolateYLeche = new PastelComposite("Pastel compuesto");

            oPastelChocolateYLeche.Add(oIngrediente4);
            oPastelChocolateYLeche.Add(oPastel);

            Console.WriteLine(oPastelChocolateYLeche.CostoTotal);


        }
    }
}
