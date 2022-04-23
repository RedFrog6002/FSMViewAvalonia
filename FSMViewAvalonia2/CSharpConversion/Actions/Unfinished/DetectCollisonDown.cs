using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DetectCollisonDown
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            Collision2DType collision = action.Values[0].Item2 as Collision2DType;
            FsmString collideTag = action.Values[1].Item2 as FsmString;
            string sendEvent = action.Values[2].Item2 as string;
            FsmGameObject storeCollider = action.Values[3].Item2 as FsmGameObject;
            FsmFloat storeForce = action.Values[4].Item2 as FsmFloat;
        }
    }
}