using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetQuaternionMultipliedByVector
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmQuaternion quaternion = action.Values[0].Item2 as FsmQuaternion;
            FsmVector3 vector3 = action.Values[1].Item2 as FsmVector3;
            FsmVector3 result = action.Values[2].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[3].Item2;
            everyFrameOptions everyFrameOption = action.Values[4].Item2 as everyFrameOptions;
        }
    }
}