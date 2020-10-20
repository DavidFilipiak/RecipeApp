using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp
{
    public class Recipe
    {
        /// <summary>
        /// The possible difficulties of a recipe.
        /// </summary>
        public enum RecipeDifficulty
        {
            Easy, Moderate, Challenging, MasterChef
        }

        #region Attributes
        private string name;
        private string descripiton;
        private RecipeDifficulty difficulty;
        private int portionAmount;
        private int minutes;
        #endregion

        #region Properties

        /// <summary>
        /// The name of the recipe.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// The description of the recipe.
        /// </summary>
        public string Description
        {
            get { return this.descripiton; }
            set { this.descripiton = value; }
        }

        /// <summary>
        /// The difficulty of the recipe.
        /// </summary>
        public RecipeDifficulty Difficulty
        {
            get { return this.difficulty; }
            set { this.difficulty = value; }
        }

        /// <summary>
        /// Amount of portions got from the recipe when using the listed ingredients in the same amounts.
        /// </summary>
        public int PortionAmount
        {
            get { return this.portionAmount; }
            set { this.portionAmount = value; }
        }

        /// <summary>
        /// The time in minutes it takes to prepare the meal from this recipe.
        /// </summary>
        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }
        #endregion
    }
}
