using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUnity.Abstruct
{
    public interface ILogger
    {
        public ILogger Logger { get; }

        public void PrintMessage(string printMessage);
    }
}
