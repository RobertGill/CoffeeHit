using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHit
{
    public class CoffeeCounter
    {
        private int _coffeesDrank;

        public CoffeeCounter()
        {
            _coffeesDrank = 0;
        }

        public void CoffeeDrank()
        {
            _coffeesDrank++;
        }

        public string DisplayMessage()
        {
            if (_coffeesDrank < 6)
            {
                return string.Format("You have drank {0} cups!", _coffeesDrank);
            }

            return "You drink too much coffee!!";
        }
    }
}
