using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAca
{
    class Hero
    {
        public Gender gender;
        public string name;
        public Breed breed;
        public int age;


        public Hero(Gender gender, string name, int age, Breed breed)
        { 
            this.gender = gender; // detta kodstycke refererar till gender variabeln utanför metoden och ger ett värde till klassens gender istället för att loopa internt.
            this.name = name;
            this.age = age;
            this.breed = breed;


        }
        public void Print() //glöm inte att ha parenteser efter metoder
        {

            Console.WriteLine("Gender: " + gender.ToString() + "." + " " + "Name: " + name); // denna rad skriver ut kön och namn. för att convertera en enums måste man skriva ".ToString)
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Breed " + breed.ToString());
        }
        enum Gender // enum byter ut siffor till bokstäver, typ som man gjorde i minecraft lol
        {
            neutral,
            Male,
            Female

        }
       /* enum Breed
        {
            Human,
            Mutant,
            Emitter

        kalle
        }
       */
    }

    class Program
    {

        static void Main(string[] args)
        {
           

           


            Console.ReadLine();



        }
    }
}
