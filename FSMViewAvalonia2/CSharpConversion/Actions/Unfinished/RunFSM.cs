using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RunFSM
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmTemplateControl fsmTemplateControl = action.Values[0].Item2 as FsmTemplateControl;
            FsmInt storeID = action.Values[1].Item2 as FsmInt;
            string finishEvent = action.Values[2].Item2 as string;
        }
    }
}