using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CurveColor
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor colorVariable = action.Values[0].Item2 as FsmColor;
            FsmColor fromValue = action.Values[1].Item2 as FsmColor;
            FsmColor toValue = action.Values[2].Item2 as FsmColor;
            FsmAnimationCurve curveR = action.Values[3].Item2 as FsmAnimationCurve;
            Calculation calculationR = action.Values[4].Item2 as Calculation;
            FsmAnimationCurve curveG = action.Values[5].Item2 as FsmAnimationCurve;
            Calculation calculationG = action.Values[6].Item2 as Calculation;
            FsmAnimationCurve curveB = action.Values[7].Item2 as FsmAnimationCurve;
            Calculation calculationB = action.Values[8].Item2 as Calculation;
            FsmAnimationCurve curveA = action.Values[9].Item2 as FsmAnimationCurve;
            Calculation calculationA = action.Values[10].Item2 as Calculation;
            FsmFloat time = action.Values[11].Item2 as FsmFloat;
            FsmFloat speed = action.Values[12].Item2 as FsmFloat;
            FsmFloat delay = action.Values[13].Item2 as FsmFloat;
            FsmBool ignoreCurveOffset = action.Values[14].Item2 as FsmBool;
            string finishEvent = action.Values[15].Item2 as string;
            bool realTime = (bool)action.Values[16].Item2;
        }
    }
}