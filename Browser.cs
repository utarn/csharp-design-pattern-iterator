using System.Collections.Generic;

namespace pattern_iterator
{
    public class Browser
    {
        private BrowserHistory[] _histories;
        // private List<BrowserHistory> _histories;
        // public List<BrowserHistory> Histories => _histories;
        private int _index;
        public Browser()
        {
            _histories = new BrowserHistory[10];
            // _histories = new List<BrowserHistory>();
            _index = 0;
        }

        public void PushHistory(BrowserHistory history)
        {
            _histories[_index] = (history);
            _index += 1;
        }

        public BrowserHistory PopHistory()
        {
            var lastElement = _histories[_index];
            _histories[_index] = null;
            _index -= 1;
            return lastElement;
        }

        public Iterator<BrowserHistory> CreateIterator()
        {
            return new ArrayIterator(this);
        }

        public class ArrayIterator : Iterator<BrowserHistory>
        {
            private readonly Browser _browser;
            private int _index;
            public ArrayIterator(Browser browser)
            {
                _browser = browser;
                _index = 0;
            }
            public BrowserHistory Current()
            {
                return _browser._histories[_index];
            }

            public bool HasNext()
            {
                return _index < _browser._index;
            }

            public void Next()
            {
                _index++;
            }
        }

        // public class ListIterator : Iterator<BrowserHistory>
        // {
        //     private readonly Browser _browser;
        //     private int _index;
        //     public ListIterator(Browser browser)
        //     {
        //         _browser = browser;
        //         _index = 0;
        //     }
        //     public BrowserHistory Current()
        //     {
        //         return _browser._histories[_index];
        //     }

        //     public bool HasNext()
        //     {
        //         return _index < _browser._histories.Count;
        //     }

        //     public void Next()
        //     {
        //         _index += 1;
        //     }
        // }
    }
}