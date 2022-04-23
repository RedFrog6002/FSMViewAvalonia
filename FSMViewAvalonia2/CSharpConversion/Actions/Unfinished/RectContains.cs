using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectContains
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect rectangle = action.Values[0].Item2 as FsmRect;
            FsmVector3 point = action.Values[1].Item2 as FsmVector3;
            FsmFloat x = action.Values[2].Item2 as FsmFloat;
            FsmFloat y = action.Values[3].Item2 as FsmFloat;
            string trueEvent = action.Values[4].Item2 as string;
            string falseEvent = action.Values[5].Item2 as string;
            FsmBool storeResult = action.Values[6].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}