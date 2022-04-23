using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TimeLimitCheck
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat storedValue = action.Values[0].Item2 as FsmFloat;
            string aboveEvent = action.Values[1].Item2 as string;
            string belowEvent = action.Values[2].Item2 as string;
        }
    }
}