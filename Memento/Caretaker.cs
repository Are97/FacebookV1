using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Memento
{
    public class Caretaker
    {
        public Stack<Memento> mementoHistory = new Stack<Memento>();

        public void save(Originator orig)
        {
            mementoHistory.Push(orig.save());
        }

        public void revert(Originator orig)
        {
            orig.revert(mementoHistory.Pop());
        }
    }
}
