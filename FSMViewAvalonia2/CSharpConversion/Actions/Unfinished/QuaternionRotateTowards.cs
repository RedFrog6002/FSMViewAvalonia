using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class QuaternionRotateTowards
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmQuaternion fromQuaternion = action.Values[0].Item2 as FsmQuaternion;
            FsmQuaternion toQuaternion = action.Values[1].Item2 as FsmQuaternion;
            FsmFloat maxDegreesDelta = action.Values[2].Item2 as FsmFloat;
            FsmQuaternion storeResult = action.Values[3].Item2 as FsmQuaternion;
            bool everyFrame = (bool)action.Values[4].Item2;
            everyFrameOptions everyFrameOption = action.Values[5].Item2 as everyFrameOptions;
        }
    }
}