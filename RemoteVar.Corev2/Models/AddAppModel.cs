using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteVar.Corev2.Models
{
    public class AddAppModel
    {
        [DisplayName("Application Name")]
        [Required]
        public string AppName { get; set; }
    }

}
