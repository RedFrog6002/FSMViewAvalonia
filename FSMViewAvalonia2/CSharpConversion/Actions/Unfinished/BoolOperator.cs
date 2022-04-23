using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BoolOperator
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool bool1 = action.Values[0].Item2 as FsmBool;
            FsmBool bool2 = action.Values[1].Item2 as FsmBool;
            Operation operation = action.Values[2].Item2 as Operation;
            FsmBool storeResult = action.Values[3].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}