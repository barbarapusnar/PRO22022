using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KličiMe
{
    internal class KličiMeException:ApplicationException
    {
        public KličiMeException(string sporočilo):base(sporočilo)
        {
        }
        public KličiMeException(string sporočilo,Exception notranja):
            base(sporočilo,notranja)
        {
        }
    }
}
