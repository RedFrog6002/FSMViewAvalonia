using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AddForce2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            ForceMode2D forceMode = action.Values[1].Item2 as ForceMode2D;
            FsmVector2 atPosition = action.Values[2].Item2 as FsmVector2;
            FsmVector2 vector = action.Values[3].Item2 as FsmVector2;
            FsmFloat x = action.Values[4].Item2 as FsmFloat;
            FsmFloat y = action.Values[5].Item2 as FsmFloat;
            FsmVector3 vector3 = action.Values[6].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}