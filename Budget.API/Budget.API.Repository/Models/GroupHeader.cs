using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.API.Repository.Models
{
    public class GroupHeader
    {
        public string CreationDateTime { get; set; }

        public string MessageType { get; set; }

        public string MessageIdentification { get; set; }

        public string InitiationSourceName { get; set; }

        public string ProcessIdentification { get; set; }

        public string ProcessType { get; set; }


    }
}
