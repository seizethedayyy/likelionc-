using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterfaceExam
{
    //인터페이스를 활용하면 객체가 어떤 특정한 동작을 보장하면서도 여러 동물을 공통된 방식으로 다룰 수 있다.

    class Program
    {
        interface IAnimal
        {
            void Speak();
        }

        class Dog: IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("멍멍!");
            }
        }

        class Cat : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("야옹!");
            }
        }

        //인터페이스를 활용한 공통 메서드
        class AnimalTrainer
        {
            public void Train(IAnimal animal)
            {
                Console.WriteLine("동물이 소리를 냅니다.");
                animal.Speak();
            }
        }

        static void Main(string[] args)
        {
            AnimalTrainer trainer = new AnimalTrainer();

            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();

            trainer.Train(myDog);
            trainer.Train(myCat);
        }
    }
}
