using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteVar.Corev2.Models.Application;

namespace RemoteVar.Corev2.ResponseData
{
    public static class ResponseConverter
    {
        public static ApplicationRP ConvertToResponse(this Application app, bool test = true, bool parsingOn = false)
        {
            ApplicationRP apprp = new ApplicationRP()
            {
                ApplicationId = app.AppId,
                ApplicationName = app.AppName,
                TestMode = test
            };
            VariableCollection var = new VariableCollection();
            var.Values = new List<VariableRP>();
            foreach (var val in app.Variables.Where(x => x.IsTestMode == test))
            {
                var.Values.Add(VariableFactory.ConvertToVariableRP(val, parsingOn));
            }
            apprp.Variables = var;
            return apprp;
        }
    }
}
