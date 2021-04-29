using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingMVCProject.Services
{
    public class NoItemsExecptiion :ApplicationException
    {
        string _message;
        public NoItemsExecptiion()
        {
            _message = "There are no items in the collection";
        }
        public override string Message => _message;
    }
}
