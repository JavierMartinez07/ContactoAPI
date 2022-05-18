using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimiento.Models
{
    public class ResponseModel<T>
    {
        public ResponseModel(List<T> records = null, List<dynamic> values = null, bool oK = true, List<string> message = null)
        {
            Records = records;
            Values = values;
            OK=oK;
            Message=message;
        }

        public List<T> Records { get; set; }
        public List<dynamic> Values { get; set; }
        public bool OK { get; set; }
        public List<string> Message { get; set; }
    }
}
