using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250305
{

    class Character
    {
        protected string Name;
        protected float Cash;
        protected int Friends;
        protected int Hp;

        public Character()
        {
            Name = "이름";
            Cash = 0;
            Friends = 0;
            Hp = 100;
        }
        public virtual void Buy()
        {
            Console.WriteLine($"{Name}이(가) 1000벨을 사용해 무언가를 구매했습니다.");
        }

        public virtual void Talk()
        {
            Console.WriteLine($"{Name}에게 말을 걸었습니다!");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name}이(가) 잠에 들었습니다......");
        }
    }

    class Mitchell : Character
    {
        public Mitchell()
        {
            Name = "미첼";
            Cash = 2500;
            Friends = 3;
            Hp = 100;
        }

        public override void Buy()
        {
            base.Buy();
            Console.WriteLine("과일은 자꾸자꾸 먹어도 안 질리니까아 나도 되게 좋아해~ 동글~");
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("안녀엉~ 나 미첼이야아~ 이렇게 불러주니깐 왠지 두근두근하다아~");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("너도 잘 자! 동글~");
        }
    }

    class Apple : Character
    {
        public Apple()
        {
            Name = "애플이";
            Cash = 1400;
            Friends = 6;
            Hp = 50;
        }

        public override void Buy()
        {
            base.Buy();
            Console.WriteLine("좋아, 결심했어! 난... 커피를 마실 거야! 큐룽!");
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("무슨 일이야? 큐룽!");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("맛있는 사과가 가득한 꿈을 꿀 거야! 큐룽!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> NPC = new List<Character> { new Mitchell(), new Apple() };

            foreach (Character ch in NPC)
            {
                ch.Talk();
                ch.Buy();
                ch.Sleep();
                Console.WriteLine();
            }
        }
    }
}
