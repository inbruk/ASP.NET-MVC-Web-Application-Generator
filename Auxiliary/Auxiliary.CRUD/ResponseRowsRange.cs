using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliary.CRUD
{
    public class ResponseRowsRange<T>
    {
        public RequestRowsRange RequestRowsRange { get; }
        public List<T> Data { get; }

        public ResponseRowsRange(RequestRowsRange request, List<T> data)
        {
            RequestRowsRange = request;
            Data = data;
        }
    }
}
