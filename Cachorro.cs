using System;
namespace exerciciosCS
{
    public class Cachorro : Animal
    {
        protected string family = "Canidae";
        protected string specie = "C. lupus";
        public Cachorro(string name)
        {
            this.setName(name);
        }

        
    }
}