using System.Collections.Generic;

namespace pattern_iterator
{
    public class Browser
    {
        private List<BrowserHistory> _histories;
        private int _index;
        public Browser()
        {
            _histories = new List<BrowserHistory>();
            _index = 0;
        }

    }
}