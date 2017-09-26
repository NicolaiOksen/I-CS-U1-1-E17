using System;
using System.Collections;

public struct Interval : IEnumerable
{
    private readonly int _from, _to;

    public Interval(int from, int to)
    {
        this._from = from;
        this._to = to;
    }

    public int From => _from;

    public int To => _to;

    public int Length => Math.Abs(_to - _from) + 1;

    public int this[int i]
    {
        get
        {
            if (_from <= _to)
            {
                if (i >= 0 && i <= Math.Abs(_from - _to))
                    return _from + i;
                else throw new Exception("Error");
            }
            else if (_from > _to)
            {
                if (i >= 0 && i <= Math.Abs(_from - _to))
                    return _from - i;
                else throw new Exception("Error");
            }
            else throw new Exception("Should not happen");
        }
    }

    private class IntervalEnumerator : IEnumerator
    {

        private readonly Interval _interval;
        private int _idx;

        public IntervalEnumerator(Interval i)
        {
            this._interval = i;
            _idx = -1;   // position enumerator outside range
        }

        public object Current => (_interval.From < _interval.To) ?
            _interval.From + _idx :
            _interval.From - _idx;

        public bool MoveNext()
        {
            if (_idx >= Math.Abs(_interval.To - _interval.From)) return false;

            _idx++;
            return true;
        }

        public void Reset()
        {
            _idx = -1;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return new IntervalEnumerator(this);
    }
}
