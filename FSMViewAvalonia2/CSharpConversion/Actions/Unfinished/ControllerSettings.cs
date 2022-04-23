using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ControllerSettings
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat height = action.Values[1].Item2 as FsmFloat;
            FsmFloat radius = action.Values[2].Item2 as FsmFloat;
            FsmFloat slopeLimit = action.Values[3].Item2 as FsmFloat;
            FsmFloat stepOffset = action.Values[4].Item2 as FsmFloat;
            FsmVector3 center = action.Values[5].Item2 as FsmVector3;
            FsmBool detectCollisions = action.Values[6].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}