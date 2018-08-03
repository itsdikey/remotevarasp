using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteVar.Corev2.Models.Application;

namespace RemoteVar.Corev2.Models
{
    public class VariableListViewModel
    {
        public Application.Application Application { get; set; }

        public List<Variable> Variables { get; set; }
    }
}
