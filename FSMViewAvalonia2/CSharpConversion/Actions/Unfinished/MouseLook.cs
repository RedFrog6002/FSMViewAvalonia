using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class MouseLook
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            RotationAxes axes = action.Values[1].Item2 as RotationAxes;
            FsmFloat sensitivityX = action.Values[2].Item2 as FsmFloat;
            FsmFloat sensitivityY = action.Values[3].Item2 as FsmFloat;
            FsmFloat minimumX = action.Values[4].Item2 as FsmFloat;
            FsmFloat maximumX = action.Values[5].Item2 as FsmFloat;
            FsmFloat minimumY = action.Values[6].Item2 as FsmFloat;
            FsmFloat maximumY = action.Values[7].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[8].Item2;
        }
    }
}