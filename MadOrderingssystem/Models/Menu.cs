using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    public class Menu
    {
        //Skal indeholde
        //Pizzas, Accesories

        List<Pizza> _pizzas;
        List<Accesory> _accesories;

        public Menu(List<Pizza> newPizzas, List<Accesory> newAccesories)
        {
            _pizzas = newPizzas;
            _accesories = newAccesories;
        }



    }
}
