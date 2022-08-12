using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exersice_1
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        public void StartWatch()
        {
            this._startTime = DateTime.Now;
        }
        public TimeSpan StopWatch()
        {
            this._stopTime = DateTime.Now.AddSeconds(22);
            return _stopTime - _startTime;
        }
    }
}
