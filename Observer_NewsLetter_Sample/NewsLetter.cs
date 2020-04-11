using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_NewsLetter_Sample
{
    abstract class NewsLetter
    {
        private string _message;

        private List<ISubscribers> _subscribers = new List<ISubscribers>();

        public string Message 
        {
            get
            {
                return _message;
            }
            set 
            {
                if (_message!= value)
                {
                    _message = value;
                    Notify();
                }
            } 
        }



        public NewsLetter(string message)
        {
            _message = message;

        }

        public void Attach(ISubscribers observer) 
        {

            _subscribers.Add(observer);

        }

        public void Dettach(ISubscribers observer)
        {
            _subscribers.Remove(observer);

        }

        public void Notify()
        {

            foreach (var subscriber in _subscribers)
            {

                subscriber.GetNewsLetter(this);

            }


        }

    }

    class Skroutz : NewsLetter
    {
        public Skroutz(string message) : base(message)
        { }
    }



    interface ISubscribers
    {

        void GetNewsLetter(NewsLetter newsLetter );
    }






}
