using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MsCrmTools.FormLibrariesManager.AppCode
{
    internal class ScriptManager
    {
        public ScriptManager(IOrganizationService service)
        {
            Service = service;
        }

        public IOrganizationService Service { get; set; }

        public List<Entity> GetAllScripts(List<Entity> solutions)
        {
            var qba = new QueryExpression("webresource");
            qba.ColumnSet = new ColumnSet(true);
            qba.Criteria = new FilterExpression();
            qba.Criteria.AddCondition("webresourcetype", ConditionOperator.Equal, 3);
            qba.Criteria.AddCondition("ishidden", ConditionOperator.Equal, false);

            if (solutions?.Count > 0)
            {
                var components = Service.RetrieveMultiple(new QueryExpression("solutioncomponent")
                {
                    ColumnSet = new ColumnSet("objectid"),
                    NoLock = true,
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("solutionid", ConditionOperator.In, solutions.Select(s => s.Id).ToArray()),
                            new ConditionExpression("componenttype", ConditionOperator.Equal, 61)
                        }
                    }
                }).Entities;

                var list = components.Select(component => component.GetAttributeValue<Guid>("objectid"))
                    .ToList();

                if (list.Count > 0)
                {
                    qba.Criteria.AddFilter(new FilterExpression(LogicalOperator.Or));
                    foreach (var id in list)
                    {
                        qba.Criteria.Filters.First().AddCondition("webresourceid", ConditionOperator.Equal, id);
                    }
                }
            }

            return Service.RetrieveMultiple(qba).Entities.ToList();
        }
    }
}