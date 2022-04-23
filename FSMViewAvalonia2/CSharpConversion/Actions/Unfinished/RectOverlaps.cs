using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectOverlaps
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect rect1 = action.Values[0].Item2 as FsmRect;
            FsmRect rect2 = action.Values[1].Item2 as FsmRect;
            string trueEvent = action.Values[2].Item2 as string;
            string falseEvent = action.Values[3].Item2 as string;
            FsmBool storeResult = action.Values[4].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}