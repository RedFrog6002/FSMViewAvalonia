using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LookAt
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject targetObject = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 targetPosition = action.Values[2].Item2 as FsmVector3;
            FsmVector3 upVector = action.Values[3].Item2 as FsmVector3;
            FsmBool keepVertical = action.Values[4].Item2 as FsmBool;
            FsmBool debug = action.Values[5].Item2 as FsmBool;
            FsmColor debugLineColor = action.Values[6].Item2 as FsmColor;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}