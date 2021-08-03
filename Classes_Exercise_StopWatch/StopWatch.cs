using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_StopWatch
{
    public class Stopwatch
    {

        private DateTime _startDateTime;
        private DateTime _endDateTime;
        private TimeSpan _duration;
        private bool _isRunning;

        public DateTime Start()
        {

            _isRunning = true;
            _startDateTime = DateTime.Now;
            return _startDateTime;
        }

        public TimeSpan Stop()
        {
            if (_isRunning != true)
                throw new InvalidOperationException("Stopwatch cannot be started twice");
            {
                _isRunning = false;
                _endDateTime = DateTime.Now;
                _duration = _endDateTime - _startDateTime;
                return _duration;
            }
        }
    }
}
