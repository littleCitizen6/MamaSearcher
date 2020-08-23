using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
        public class MamaSearch : IMamaSearcher
    {
        public Action<int, string> actionsToPreform;
        private Dictionary<string, Action<int, string>> _patterns;
        public MamaSearch()
        {
            _patterns = new Dictionary<string, Action<int, string>>();
        }
        public void PerformSearch(string content)
        {
            foreach (var pattern in _patterns.Keys)
            {
                if(content.Contains(pattern))
                {
                    _patterns[pattern]?.Invoke(content.IndexOf(pattern), pattern);
                }
            } 
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            if (!_patterns.TryAdd(pattern, actionToPerform)) 
            {
                _patterns[pattern] += actionToPerform;
            }
        }
    }
}
