using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Hello; //using 키워드로 네임스페이스를 편하게 사용 가능

namespace Hello
{
    class say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}

namespace study35
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello.say sa = new Hello.say();
            sa.SayHello();
        }
    }
}
