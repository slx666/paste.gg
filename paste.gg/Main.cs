using System;
using System.Collections.Generic;
using System.Diagnostics;
using paste.gg.Properties;
using Wox.Plugin;

namespace paste.gg
{
    public class Main : IPlugin
    {
        public List<Result> Query(Query query)
        {
            //TODO: add the ability to add pastes directly using the paste.gg api.
            var possibleResults = new List<Result>();

            var result = new Result
            {
                Title = "paste.gg",
                SubTitle = "Add a new paste",
                IcoPath = Resources.icon,
                Action = context =>
                {
                    Process.Start("https://paste.gg");
                    return true;
                }
            };


            possibleResults.Add(result);

            return possibleResults;
        }

        public void Init(PluginInitContext context)
        {
        }
    }
}