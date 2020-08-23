using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public interface IMamaSearcher
    {
        void Subscribe(string pattern, Action<int, string> actionToPerform);
        void PerformSearch(string content);
    }
}
