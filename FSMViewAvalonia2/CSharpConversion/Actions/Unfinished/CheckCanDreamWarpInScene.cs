using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckCanDreamWarpInScene
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string trueEvent = action.Values[0].Item2 as string;
            string falseEvent = action.Values[1].Item2 as string;
        }
    }
}