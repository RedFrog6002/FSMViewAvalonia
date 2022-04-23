using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SampleCurve
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmAnimationCurve curve = action.Values[0].Item2 as FsmAnimationCurve;
            FsmFloat sampleAt = action.Values[1].Item2 as FsmFloat;
            FsmFloat storeValue = action.Values[2].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}