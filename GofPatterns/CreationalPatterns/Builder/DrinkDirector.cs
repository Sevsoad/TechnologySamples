namespace GofPatterns.Builder
{
    public class DrinkDirector
    {
        public void MakeDrink(DrinkBuilder builder)
        {
            builder.PrepareWater();
            builder.PrepareIngredients();
            builder.StartCooking();
        }
    }
}
