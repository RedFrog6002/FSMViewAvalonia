using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CallStaticMethod
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString className = action.Values[0].Item2 as FsmString;
            FsmString methodName = action.Values[1].Item2 as FsmString;
            FsmVar[] parameters = action.Values[2].Item2 as FsmVar[];
            FsmVar storeResult = action.Values[3].Item2 as FsmVar;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}