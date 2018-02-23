using PrimeNumberCheck;
using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Automation.Common;

namespace PrimeNumberExtension
{
    [AddonGroup("PrimeNumber")]
    [AddonName("Is Prime and Next Prime")]
    public class PrimeNumber : VIPNativeActivity
    {
        [Description("Number to check")]
        [Category("Input Properties")]
        [RequiredArgument] 
        public InArgument<int> NumberToCheck { get; set; }

        [Description("String Property")]
        [Category("Output Properties")]
        public OutArgument<PrimeNumberDetails> PrimeResults { get; set; }
        public override void ExecuteActivity(NativeActivityContext context)
        {
            Logger.LogMessage("Executing Addon...");

            int vnum = NumberToCheck.Get(context);
            var vresult = StandardClasses.CheckPrime(vnum);
            PrimeResults.Set(context, vresult);

            Logger.LogMessage("Addon Execution Complete...");
        }

        public override void PostExecute(NativeActivityContext context)
        {
        }

        public override void PreExecute(NativeActivityContext context)
        {
        }
    }
}