using System;

namespace GofPatterns.Builder
{
    public abstract class DrinkBuilder
    {
        public abstract void PrepareWater();
        public abstract void PrepareIngredients();
        public abstract void StartCooking();
        public abstract Drink GetDrink();
    }

    public class TeaBuilder : DrinkBuilder
    {
        private Drink _drink = new Drink();

        public override Drink GetDrink()
        {
            return _drink;
        }

        public override void PrepareIngredients()
        {
            _drink.Cup += "2 spoons of black tea \n";
        }

        public override void PrepareWater()
        {
            _drink.Cup += "0,5l of water \n";
        }

        public override void StartCooking()
        {
            _drink.Cup += "boil water, put it in cup with tea";
        }
    }

    public class CoffeeBuilder : DrinkBuilder
    {
        private Drink _drink = new Drink();

        public override Drink GetDrink()
        {
            return _drink;
        }

        public override void PrepareIngredients()
        {
            _drink.Cup += "3 spoons of coffee \n";
        }

        public override void PrepareWater()
        {
            _drink.Cup += "0,33l of water \n";
        }

        public override void StartCooking()
        {
            _drink.Cup += "smash coffee, boil water, put all in cup, spit in cup";
        }
    }
}
