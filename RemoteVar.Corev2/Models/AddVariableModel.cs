using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteVar.Corev2.Models
{
    public class AddVariableModel
    {
        [DisplayName("Variable Name")]
        [Required]
        public string VarName { get; set; }


        [DisplayName("Variable Type")]
        [Required]
        public string VariableType { get; set; }

        [DisplayName("Variable Value")]
        [Required]
        public string VariableValue { get; set; }

        [Required]
        public Guid AppId { get; set; }
    }
}
