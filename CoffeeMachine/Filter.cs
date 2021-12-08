using System.Collections.Generic;

namespace CoffeeMachine
{
    public class Filter
    {
        //Creating a list of flavors
        private List<string> flavorType { get; }

        public Filter()
        {
            //adding items for my list of flavors
            flavorType.Add("Coffee");
            flavorType.Add("Tee");
            flavorType.Add("Choco");
        }
        
        //this function will take any given flavorType and put it into the filter
        public void PoorFilter()
        {
            
        }
    }
}