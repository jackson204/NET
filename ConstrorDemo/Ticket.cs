using System;

namespace ConstrorDemo
{
    //預設值為 internal 
    class Ticket
    {

        // 不加存取修飾 預設為 private
        int _distance;
        private readonly int _price;

        public Ticket(int distance)
        {
            _distance = distance;
        }

        public int Distance
        {
            get => _distance;
        }

        public double Price
        {
            get
            {
                if (_distance > 300)
                {
                    return _distance * 0.8;
                }
                else if (_distance > 200)
                {
                    return _distance * 0.9;
                }
                else if (_distance > 100)
                {
                    return _distance * 0.95;
                }
                else
                {
                    return _distance;
                }
            }
        }

        public void ShowTicket()
        {
            Console.WriteLine($"{Distance} send {this.Price}");
        }
    }
}