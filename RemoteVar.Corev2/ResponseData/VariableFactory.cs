using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteVar.Corev2.Models.Application;

namespace RemoteVar.Corev2.ResponseData
{
    public class VariableFactory
    {
        public static VariableRP ConvertToVariableRP(Variable var, bool parsingOn = false)
        {
            if (!parsingOn)
            {
                return new VariableRPString()
                {
                    VariableValue = var.VariableValue,
                    VariableName = var.VariableName,
                    VariableType = var.VariableType
                };
            }
            VariableRP result;
            if (var.VariableType == "int")
            {
                result = new VariableRPInt()
                {
                    VariableValue = int.Parse(var.VariableValue)
                };
            }
            else if (var.VariableType == "float")
            {
                result = new VariableRPFloat()
                {
                    VariableValue = float.Parse(var.VariableValue)
                };
            }
            else if (var.VariableType == "bool")
            {
                result = new VariableRPBool()
                {
                    VariableValue = bool.Parse(var.VariableValue)
                };
            }
            else
            {
                result = new VariableRPString()
                {
                    VariableValue = var.VariableValue
                };
            }

            result.VariableName = var.VariableName;
            result.VariableType = var.VariableType;


            return result;
        }
    }
}
