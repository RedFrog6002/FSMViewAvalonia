using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class IntTestToBool
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt int1 = action.Values[0].Item2 as FsmInt;
            FsmInt int2 = action.Values[1].Item2 as FsmInt;
            FsmBool equalBool = action.Values[2].Item2 as FsmBool;
            FsmBool lessThanBool = action.Values[3].Item2 as FsmBool;
            FsmBool greaterThanBool = action.Values[4].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}