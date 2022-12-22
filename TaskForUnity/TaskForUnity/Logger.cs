using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class Logger : ILogger
    {
        private ILogger _logger { get; }
        ILogger ILogger.Logger => _logger.Logger;

        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public void PrintMessage(string printMessage)
        {
            throw new NotImplementedException();
        }
    }
}
