using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatOperator
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat float1 = action.Values[0].Item2 as FsmFloat;
            FsmFloat float2 = action.Values[1].Item2 as FsmFloat;
            Operation operation = action.Values[2].Item2 as Operation;
            FsmFloat storeResult = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}