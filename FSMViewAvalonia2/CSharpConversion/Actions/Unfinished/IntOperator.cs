using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class IntOperator
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt integer1 = action.Values[0].Item2 as FsmInt;
            FsmInt integer2 = action.Values[1].Item2 as FsmInt;
            Operation operation = action.Values[2].Item2 as Operation;
            FsmInt storeResult = action.Values[3].Item2 as FsmInt;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}