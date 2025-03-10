using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace study40
{
    //부모 클래스의 생성자 호출
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모 생성자" + message); //실행 2
        }
    }

    class Child : Parent
    {
        public Child():base(" 호출 성공입니다.") //부모 생성자 호출 1
        {
            Console.WriteLine("자식 생성자 호출"); //3
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child(); //객체 생성 시작 0
        }
    }
}
