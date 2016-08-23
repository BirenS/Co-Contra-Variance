using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Contra_Variance
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animal = new GStack<Animal>();
            IPushable<Animal> pushAnimal = animal;
            IPushable<Bear> pushBear = pushAnimal;

            pushAnimal.Push(new Animal("A1"));
            pushBear.Push(new Bear("B1"));
            pushBear.Push(new Bear("B2"));
            

            

            IPoppable<Animal> popAnimal = animal;
            while(animal.Count>0){
                Console.WriteLine(popAnimal.Pop().Name.ToString());
            }
            Console.ReadLine();


        }
    }
}
