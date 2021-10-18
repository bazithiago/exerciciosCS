using System;
namespace exerciciosCS
{
    public abstract class Animal
    {
        public string name;
        public string type;
        protected string kingdom = "Animalia";
        protected bool domestic = true;
        
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getType()
        {
            return this.type;
        }

        public void setType(string type)
        {
            this.type = type;
        }



        
    }
}