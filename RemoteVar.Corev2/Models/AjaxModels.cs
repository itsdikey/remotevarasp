using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteVar.Corev2.Models
{
    public class UpdateValueModel
    {
        public Guid Id { get; set; }

        public string Value { get; set; }

    }

    public class DeleteValueModel
    {
        public Guid Id { get; set; }
    }
}
