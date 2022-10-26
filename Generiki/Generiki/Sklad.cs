using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class Sklad
    {
        int m_size;
        int m_stackPointer = 0;
        object[] m_items;
        public Sklad(int velikost)
        {
            m_size = velikost;
            m_items = new object[velikost];
        }
        public Sklad():this(100)
        {
        }
        public void Push(object item)
        {
            if (m_stackPointer >= m_size)
            {
                throw new StackOverflowException("Sklad je poln");
            }
            m_items[m_stackPointer] = item;
            m_stackPointer++;
        }
        public object Pop()
        {
            m_stackPointer--;
            if (m_stackPointer >= 0)
                return m_items[m_stackPointer];
            m_stackPointer = 0;
            throw new InvalidOperationException("Sklad je prazen");
        }
    }
}
