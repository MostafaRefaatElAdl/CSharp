using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06Task01
{
    public class Duration
    {
        float hours, minutes, seconds;
        public float Hours { get { return hours; } set { hours = value; } }
        public float Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 60 || minutes >= 60)
                {
                    float hourfrommin = (int)minutes / 60;
                    hours += (int)hourfrommin;
                    minutes = (int)value % 60;
                }
                if (value <= 0 || minutes <= 0)
                {
                    hours--;
                    minutes = 60 - value;
                }
                else
                    minutes = value;
            }
        }

        public float Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 60 || seconds >= 60)
                {

                    float minfromsec = (int)minutes / 60;
                    minutes += (int)minfromsec;
                    seconds = (int)value % 60;

                }
                if (value <= 0 || seconds <= 0)
                {
                    minutes--;
                    seconds = 60 - value;
                }
                seconds = value;
            }
        }

        public Duration(float _hours, float _minutes, float _seconds)
        {
            Hours = _hours;

            //check for min 
            if (_minutes >= 60)
            {
                float hourfrommin = (int)_minutes / 60;
                hours += (int)hourfrommin;
                minutes = (int)_minutes % 60;
            }
            else
            {
                minutes = _minutes;
            }

            //check for sec
            if (_seconds >= 60)
            {
                float minfromsec = (int)_seconds / 60;
                minutes += (int)minfromsec;
                seconds = (int)_seconds % 60;
            }
            else
            {
                seconds = _seconds;
            }
        }

        public Duration(float _seconds)
        {
            float s = MathF.Floor(_seconds % 3600 % 60);
            float m = MathF.Floor(_seconds % 3600 / 60);
            float h = MathF.Floor(_seconds / 3600);

            if (s > 0)
            {
                seconds = s;
            }
            if (m > 0)
            {
                minutes = m;
            }
            if (h > 0)
            {
                hours = h;
            }
        }


        //===== overloading operators ======//

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.Hours + right.Hours, left.Minutes + right.Minutes, left.Seconds + right.Seconds);
        }
        public static Duration operator +(Duration left, int x)
        {
            return new Duration(left.Hours + x, left.Minutes, left.Seconds);
        }
        public static Duration operator +(int x, Duration right)
        {

            return new Duration(right.Hours + x, right.Minutes, right.Seconds);
        }

        public static Duration operator -(Duration nig)
        {

            return new Duration(-nig.minutes);
        }
        public static Duration operator ++(Duration o)
        {
            return new Duration(o.Hours, o.Minutes + 1, o.Seconds);
        }
        public static Duration operator --(Duration o)
        {
            return new Duration(o.Hours, o.Minutes - 1, o.Seconds);
        }

        public static bool operator ==(Duration left, Duration right)
        {
            return left.Hours == right.Hours && left.Minutes == right.Minutes && left.Seconds == right.Seconds;
        }

        public static bool operator !=(Duration left, Duration right)
        {
            return !(left == right);
        }

        public static bool operator >(Duration left, Duration right)
        {
            return left.Hours > right.Hours && left.Minutes > right.Minutes && left.Seconds > right.Seconds;
        }

        public static bool operator <(Duration left, Duration right)
        {
            return left.Hours < right.Hours && left.Minutes < right.Minutes && left.Seconds < right.Seconds;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours > right.Hours)
            {
                return true;
            }
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes < right.Minutes)
                    return false;
                else if (right.Minutes == left.Minutes)
                {
                    if (left.Seconds < right.Seconds)
                        return false;
                }
                else return true;
            }

            return false;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hours < right.Hours)
            {
                return true;
            }
            else if (left.Hours == right.Hours)
            {
                if (left.Minutes > right.Minutes)
                    return false;
                else if (right.Minutes == left.Minutes)
                {
                    if (left.Seconds > right.Seconds)
                        return false;
                }
                else return true;
            }

            return false;
        }

        public static bool operator true(Duration obj)
        {
            if
            (!ReferenceEquals(obj, null) && (obj.Hours != 0 || obj.Minutes != 0 || obj.seconds != 0))
            { return true; }
            else
            {
                return false;
            }

        }

        public static bool operator false(Duration obj)
        {
            if
            (ReferenceEquals(obj, null) && (obj.Hours == 0 && obj.Minutes == 0 && obj.seconds == 0))
            { return true; }
            else { return false; }

        }

        //=================================//

        public override bool Equals(object? obj)
        {
            Duration d = obj as Duration;
            if (d == null)
                return false;
            else
                return (Hours == d.hours && Minutes == d.minutes && Seconds == d.seconds);
        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public override string ToString()
        {
            return $"Hours:{Hours}, " +
                $"Minutes:{Minutes}, " +
                $"Seconds:{Seconds}";
        }

    }
}
