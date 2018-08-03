using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteVar.Corev2.ResponseData
{
    public class ApplicationRP
    {
        public Guid ApplicationId { get; set; }

        public string ApplicationName { get; set; }

        public VariableCollection Variables { get; set; }

        public bool TestMode { get; set; }
    }


    public class VariableRP
    {
        public string VariableName { get; set; }
        public string VariableType { get; set; }

        public object VariableValue { get; set; }
    }

    public class VariableRPInt : VariableRP
    {
        public new int VariableValue { get; set; }
    }

    public class VariableRPString : VariableRP
    {
        public new string VariableValue { get; set; }
    }

    public class VariableRPFloat : VariableRP
    {
        public new float VariableValue { get; set; }
    }

    public class VariableRPBool : VariableRP
    {
        public new bool VariableValue { get; set; }
    }




    public class VariableCollection
    {
        public List<VariableRP> Values { get; set; }
    }
}
