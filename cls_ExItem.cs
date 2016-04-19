using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomWorkout
{
    public class cls_ExItem
    {
        string _exName;
        int _woTime;
        int _restTime;
        int _dflt_woTime;
        int _dflt_restTime;
        bool _pauseAfter;
        enum_RunState _currState;
        int _currCounterVal;

        public string exName
        {
            get { return _exName; }
            set { _exName = value; }
        }

        public int woTime
        {
            get { return _woTime; }
            set { _woTime = value; }
        }

        public int restTime
        {
            get { return _restTime; }
            set { _restTime = value; }
        }

        public int dflt_woTime
        {
            get { return _dflt_woTime; }
            set { _dflt_woTime = value; }
        }

        public int dflt_restTime
        {
            get { return _dflt_restTime; }
            set { _dflt_restTime = value; }
        }

        public bool pauseAfter
        {
            get { return _pauseAfter; }
            set { _pauseAfter = value; }
        }

        public enum_RunState currState
        {
            get { return _currState; }
            set { _currState = value; }
        }

        public int currCounterVal
        {
            get { return _currCounterVal; }
            set { _currCounterVal = value; }
        }

        public cls_ExItem(int par_dflt_woTime, int par_dflt_restTime)
        {
            _exName = "";
            _restTime = 0;
            _woTime = 0;
            _dflt_restTime = par_dflt_restTime;
            _dflt_woTime = par_dflt_woTime;
            _currCounterVal = 0;
            _currState = enum_RunState.Stopped;
            _pauseAfter = false;
        }

        public void loadItem(string par_ln)
        {
            string str_remaining = "";
            string str = "";
            _woTime = _dflt_woTime;
            _restTime = _dflt_restTime;

            //read Exercise name
            int pos = par_ln.IndexOf(";");
            if (pos > 0)
            {
                _exName = par_ln.Substring(0, pos);
                str_remaining = par_ln.Substring(pos+1);
            }
            else
            {
                _exName = par_ln;
                str_remaining = "";
            }

            //read Exercise time
            if (str_remaining != "")
            {
                pos = str_remaining.IndexOf(";");
                if (pos > 0)
                {
                    str = str_remaining.Substring(0, pos);
                    _woTime = Convert.ToInt32(str);
                    str_remaining = str_remaining.Substring(pos + 1);
                }
                else
                {
                    str = str_remaining;
                    str_remaining = "";
                    _woTime = Convert.ToInt32(str);
                }
            }

            //read Rest time
            if (str_remaining != "")
            {
                str = str_remaining;
                if (str.ToLower() == "pause") _pauseAfter = true;
                else _restTime = Convert.ToInt32(str_remaining);
                str_remaining = "";
            }
        }
    }
}
