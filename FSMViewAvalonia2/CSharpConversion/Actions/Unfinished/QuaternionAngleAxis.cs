using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class QuaternionAngleAxis
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat angle = action.Values[0].Item2 as FsmFloat;
            FsmVector3 axis = action.Values[1].Item2 as FsmVector3;
            FsmQuaternion result = action.Values[2].Item2 as FsmQuaternion;
            bool everyFrame = (bool)action.Values[3].Item2;
            everyFrameOptions everyFrameOption = action.Values[4].Item2 as everyFrameOptions;
        }
    }
}