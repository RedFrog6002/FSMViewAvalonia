using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimateRect
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect rectVariable = action.Values[0].Item2 as FsmRect;
            FsmAnimationCurve curveX = action.Values[1].Item2 as FsmAnimationCurve;
            Calculation calculationX = action.Values[2].Item2 as Calculation;
            FsmAnimationCurve curveY = action.Values[3].Item2 as FsmAnimationCurve;
            Calculation calculationY = action.Values[4].Item2 as Calculation;
            FsmAnimationCurve curveW = action.Values[5].Item2 as FsmAnimationCurve;
            Calculation calculationW = action.Values[6].Item2 as Calculation;
            FsmAnimationCurve curveH = action.Values[7].Item2 as FsmAnimationCurve;
            Calculation calculationH = action.Values[8].Item2 as Calculation;
            FsmFloat time = action.Values[9].Item2 as FsmFloat;
            FsmFloat speed = action.Values[10].Item2 as FsmFloat;
            FsmFloat delay = action.Values[11].Item2 as FsmFloat;
            FsmBool ignoreCurveOffset = action.Values[12].Item2 as FsmBool;
            string finishEvent = action.Values[13].Item2 as string;
            bool realTime = (bool)action.Values[14].Item2;
        }
    }
}