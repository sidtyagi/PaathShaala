using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchProject
{
    class StopWatch
    {
        private bool _state;
        public DateTime Start()
        {
            if (_state)
            {
                Console.WriteLine("Alredy Started, hence cannot restart");
                throw new InvalidOperationException();
            }
            _state = true;
            var CurDate = DateTime.Now;
            Console.WriteLine("Started");
            return CurDate;
        }
        public DateTime Stop()
        {
            if(_state)
            {
                var CurDate = DateTime.Now;
                Console.WriteLine("Attempting to Stop");
                Console.WriteLine("Stopped");
                _state = false;
                return CurDate;
            }
            Console.WriteLine("Cannot stop as the watch is not yet started");
            throw new InvalidOperationException();
        }

        
    }
}
