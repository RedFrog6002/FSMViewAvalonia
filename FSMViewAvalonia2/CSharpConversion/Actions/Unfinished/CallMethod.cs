using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CallMethod
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject behaviour = action.Values[0].Item2 as FsmObject;
            FsmString methodName = action.Values[1].Item2 as FsmString;
            FsmVar[] parameters = action.Values[2].Item2 as FsmVar[];
            FsmVar storeResult = action.Values[3].Item2 as FsmVar;
            bool everyFrame = (bool)action.Values[4].Item2;
            bool manualUI = (bool)action.Values[5].Item2;
        }
    }
}