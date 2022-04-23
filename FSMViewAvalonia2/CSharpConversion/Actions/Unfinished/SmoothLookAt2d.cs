using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SmoothLookAt2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject targetObject = action.Values[1].Item2 as FsmGameObject;
            FsmVector2 targetPosition2d = action.Values[2].Item2 as FsmVector2;
            FsmVector3 targetPosition = action.Values[3].Item2 as FsmVector3;
            FsmFloat rotationOffset = action.Values[4].Item2 as FsmFloat;
            FsmFloat speed = action.Values[5].Item2 as FsmFloat;
            FsmBool debug = action.Values[6].Item2 as FsmBool;
            FsmFloat finishTolerance = action.Values[7].Item2 as FsmFloat;
            string finishEvent = action.Values[8].Item2 as string;
        }
    }
}