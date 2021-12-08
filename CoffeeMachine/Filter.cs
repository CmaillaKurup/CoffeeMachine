using System.Collections.Generic;

namespace CoffeeMachine
{
    public class Filter
    {
        private List<string> liquidType { get; }

        public Filter()
        {
            liquidType.Add("Coffee");
            liquidType.Add("Tee");
            liquidType.Add("Choco");
        }
        
        public void PoorFilter()
        {
            
        }
    }
}