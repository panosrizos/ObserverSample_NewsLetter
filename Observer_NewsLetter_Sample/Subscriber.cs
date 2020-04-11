using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_NewsLetter_Sample
{
    class Subscriber : ISubscribers
    {

        public readonly string Name;


        private NewsLetter _newsLetter;


        public Subscriber(string name , NewsLetter newsLetter)
        {

            Name = name;
            _newsLetter = newsLetter;


        }


        public void GetNewsLetter(NewsLetter newsLetter)
        {

            Console.WriteLine($"Dear {Name} ,\n {newsLetter.GetType().Name} send you :\n {newsLetter.Message}");

        }
    }
}
