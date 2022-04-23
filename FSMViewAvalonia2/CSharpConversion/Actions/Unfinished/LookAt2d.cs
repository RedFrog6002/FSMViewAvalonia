using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LookAt2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 vector2Target = action.Values[1].Item2 as FsmVector2;
            FsmVector3 vector3Target = action.Values[2].Item2 as FsmVector3;
            FsmFloat rotationOffset = action.Values[3].Item2 as FsmFloat;
            FsmBool debug = action.Values[4].Item2 as FsmBool;
            FsmColor debugLineColor = action.Values[5].Item2 as FsmColor;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}