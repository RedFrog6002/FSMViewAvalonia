using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TimeLimitSet
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat timeDelay = action.Values[0].Item2 as FsmFloat;
            FsmFloat storeValue = action.Values[1].Item2 as FsmFloat;
        }
    }
}