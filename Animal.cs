using System;
namespace exerciciosCS
{
    public abstract class Animal
    {
        public string name;
        public string type;
        public string kingdom = "Animalia";
        public bool domestic = true;
        
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }



        
    }
}