using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RandomFloatEither
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat value1 = action.Values[0].Item2 as FsmFloat;
            FsmFloat value2 = action.Values[1].Item2 as FsmFloat;
            FsmFloat storeResult = action.Values[2].Item2 as FsmFloat;
        }
    }
}