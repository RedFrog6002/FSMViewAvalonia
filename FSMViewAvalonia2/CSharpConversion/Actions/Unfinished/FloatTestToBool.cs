using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatTestToBool
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat float1 = action.Values[0].Item2 as FsmFloat;
            FsmFloat float2 = action.Values[1].Item2 as FsmFloat;
            FsmFloat tolerance = action.Values[2].Item2 as FsmFloat;
            FsmBool equalBool = action.Values[3].Item2 as FsmBool;
            FsmBool lessThanBool = action.Values[4].Item2 as FsmBool;
            FsmBool greaterThanBool = action.Values[5].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}