using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatInterpolate
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            InterpolationType mode = action.Values[0].Item2 as InterpolationType;
            FsmFloat fromFloat = action.Values[1].Item2 as FsmFloat;
            FsmFloat toFloat = action.Values[2].Item2 as FsmFloat;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            FsmFloat storeResult = action.Values[4].Item2 as FsmFloat;
            string finishEvent = action.Values[5].Item2 as string;
            bool realTime = (bool)action.Values[6].Item2;
        }
    }
}