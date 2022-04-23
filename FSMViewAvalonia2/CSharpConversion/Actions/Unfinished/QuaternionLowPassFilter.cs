using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class QuaternionLowPassFilter
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmQuaternion quaternionVariable = action.Values[0].Item2 as FsmQuaternion;
            FsmFloat filteringFactor = action.Values[1].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[2].Item2;
            everyFrameOptions everyFrameOption = action.Values[3].Item2 as everyFrameOptions;
        }
    }
}