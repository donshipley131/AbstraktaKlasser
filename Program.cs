using System;
namespace Abstrakta_klasser
{
    class Program
    {
        static void Main(string[] args)
        {            
            Cat jaffe = new Cat(true, "Norsk skogskatt", "3");
            jaffe.Talk(10);            
        }
    }






    public abstract class Animal
    {    
        public abstract void Talk(int times);
    }





    public class Feline : Animal
    {
        public override void Talk(int times){

            int i = 0;

            do{
                System.Console.WriteLine("Meow");

                i++;
            }while(i < times);

        }
    }












    public class Cat : Feline
    {
        public bool isAlive { get; set; }
        public string breed { get; set; }
        public string weight { get; set; }

        public Cat(bool isAlive, string breed, string weight)
        {
            this.isAlive = isAlive;
            this.breed = breed;
            this.weight = weight;
        }       
    }
}
