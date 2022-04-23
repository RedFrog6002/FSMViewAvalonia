using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimateFloatV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatVariable = action.Values[0].Item2 as FsmFloat;
            FsmAnimationCurve animCurve = action.Values[1].Item2 as FsmAnimationCurve;
            Calculation calculation = action.Values[2].Item2 as Calculation;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            FsmFloat speed = action.Values[4].Item2 as FsmFloat;
            FsmFloat delay = action.Values[5].Item2 as FsmFloat;
            FsmBool ignoreCurveOffset = action.Values[6].Item2 as FsmBool;
            string finishEvent = action.Values[7].Item2 as string;
            bool realTime = (bool)action.Values[8].Item2;
        }
    }
}