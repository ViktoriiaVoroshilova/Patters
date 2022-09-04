﻿namespace AbstractFactoryRestaurant.Recipes
{
    internal class IndianSummerRecipe : IRecipe
    {
        public int ChickenAmount { get => 100; }
        public Level ChickenFryLevel { get => Level.Low; }
        public Level ChickenSaltLevel { get => Level.Zero; }
        public Level ChickenPepperLevel { get => Level.Medium; }
        public int RiceAmount { get => 100; }
        public Level RiceFryLevel { get => Level.Low; }
        public Level RiceSaltLevel { get => Level.Zero; }
        public Level RicePepperLevel { get => Level.Medium; }
    }
}
