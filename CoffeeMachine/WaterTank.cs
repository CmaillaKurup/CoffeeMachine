namespace CoffeeMachine
{
    public abstract class WaterTank
    {
        private WaterLimit waterLimit { get; }
        private int currentSpaceInUse { get; }

        public WaterTank()
        {
            
        }
        
        public void PoorWater()
        {
            /*
            if (currentSpaceInUse < waterLimit)
            {
                
            }
            */
        }
    }
}