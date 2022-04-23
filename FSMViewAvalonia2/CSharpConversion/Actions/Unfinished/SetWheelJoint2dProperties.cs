using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetWheelJoint2dProperties
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool useMotor = action.Values[1].Item2 as FsmBool;
            FsmFloat motorSpeed = action.Values[2].Item2 as FsmFloat;
            FsmFloat maxMotorTorque = action.Values[3].Item2 as FsmFloat;
            FsmFloat angle = action.Values[4].Item2 as FsmFloat;
            FsmFloat dampingRatio = action.Values[5].Item2 as FsmFloat;
            FsmFloat frequency = action.Values[6].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}