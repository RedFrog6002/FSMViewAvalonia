using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AddForce2dV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 atPosition = action.Values[1].Item2 as FsmVector2;
            FsmVector2 vector = action.Values[2].Item2 as FsmVector2;
            FsmFloat x = action.Values[3].Item2 as FsmFloat;
            FsmFloat y = action.Values[4].Item2 as FsmFloat;
            FsmVector3 vector3 = action.Values[5].Item2 as FsmVector3;
            FsmFloat maxSpeed = action.Values[6].Item2 as FsmFloat;
            FsmFloat maxSpeedX = action.Values[7].Item2 as FsmFloat;
            FsmFloat maxSpeedY = action.Values[8].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[9].Item2;
        }
    }
}