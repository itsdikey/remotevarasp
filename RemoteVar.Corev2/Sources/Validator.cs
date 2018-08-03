using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteVar.Corev2.Models;

namespace RemoteVar.Corev2.Sources
{
    public static class Validator
    {
        public static bool Validate(AddVariableModel var)
        {
            if (var.VariableType == "int")
            {
                return int.TryParse(var.VariableValue, out _);
            }
            else if (var.VariableType == "float")
            {
                return float.TryParse(var.VariableValue, out _);

            }
            else if (var.VariableType == "bool")
            {
                return bool.TryParse(var.VariableValue, out _);
            }
            else if (var.VariableType == "String")
            {
                return true;
            }
            return false;
        }
    }
}
