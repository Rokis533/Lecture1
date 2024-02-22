using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class ProgressBar
    {
        private readonly object _lockProgess = new object();
        private int Progress = 0;

        public void Increment()
        {

            lock (_lockProgess)
            {
                if (Progress < 100)
                {
                    Progress++;
                }
            }
        }
        public int GetProgress()
        {
            lock (_lockProgess)
            {
                return Progress;
            }
        }
    }
}
