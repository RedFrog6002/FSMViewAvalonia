using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetQuaternionEulerAngles
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmQuaternion quaternion = action.Values[0].Item2 as FsmQuaternion;
            FsmVector3 eulerAngles = action.Values[1].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[2].Item2;
            everyFrameOptions everyFrameOption = action.Values[3].Item2 as everyFrameOptions;
        }
    }
}