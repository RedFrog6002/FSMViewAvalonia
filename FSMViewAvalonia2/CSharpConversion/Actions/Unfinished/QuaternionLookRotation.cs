using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class QuaternionLookRotation
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 direction = action.Values[0].Item2 as FsmVector3;
            FsmVector3 upVector = action.Values[1].Item2 as FsmVector3;
            FsmQuaternion result = action.Values[2].Item2 as FsmQuaternion;
            bool everyFrame = (bool)action.Values[3].Item2;
            everyFrameOptions everyFrameOption = action.Values[4].Item2 as everyFrameOptions;
        }
    }
}