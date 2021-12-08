namespace CoffeeMachine
{
    public class MachineMng : IPower
    {
        private WaterTank waterTank { get; set; }
        
        public MachineMng()
        {
            
        }

        //This function will turn on the machine,
        //but only if there is power to the machine,
        //water in the tank and something in the filter
        public bool turnOn()
        {
            //only to have an return statement as placeholder
            return false;
        }
    }
}