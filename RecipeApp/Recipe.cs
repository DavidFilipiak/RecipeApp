using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp
{
    class Recipe
    {
        public enum RecipeDifficulty
        {
            Easy, Moderate, Challenging, MasterChef;
        }

        private string name;
        private string descripiton;
        private RecipeDifficulty difficulty;
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.descripiton; }
            set { this.descripiton = value; }
        }

        public RecipeDifficulty Difficulty
        {
            get { return this.difficulty; }
            set { this.difficulty = value; }
        }
    }
}
