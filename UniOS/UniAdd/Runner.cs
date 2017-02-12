using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniOS;

namespace CosmosKernel2
{
    class Runner
    {
        public static void packages(string packageid)
        {
            switch(packageid)
            {
                /// Add all packages here!
                case "dungeonrunner":
                    UniOS.UniAdd.Games.dungeonrunner.dungeonrun();
                    break;

                case "deadrun":
                    UniOS.UniAdd.Games.deadrun.deadrungame();
                    break;

                    /// Add others here!
            }
        }
    }
}
