using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RemoteVar.Corev2.Models.Application
{
    public class Application
    {
        [Key]
        public Guid AppId { get; set; }

        public string AppName { get; set; }

        public string UserId { get; set; }

        public List<Variable> Variables { get; set; }
    }

    public class Variable
    {
        [Key]
        public Guid Id { get; set; }

        public Guid AppId { get; set; }

        public string VariableName { get; set; }

        public string VariableValue { get; set; }

        public string VariableType { get; set; }

        public bool IsTestMode { get; set; }

        public Application Application { get; set; }
    }


}
