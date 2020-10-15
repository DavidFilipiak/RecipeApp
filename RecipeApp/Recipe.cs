using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp
{
    class Recipe
    {
        private string name;
        private string descripiton;


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
    }
}
