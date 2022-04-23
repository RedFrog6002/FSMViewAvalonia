using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GGCheckBoundSoul
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string boundEvent = action.Values[0].Item2 as string;
            string unboundEvent = action.Values[1].Item2 as string;
        }
    }
}