using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetControllerHitInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObjectHit = action.Values[0].Item2 as FsmGameObject;
            FsmVector3 contactPoint = action.Values[1].Item2 as FsmVector3;
            FsmVector3 contactNormal = action.Values[2].Item2 as FsmVector3;
            FsmVector3 moveDirection = action.Values[3].Item2 as FsmVector3;
            FsmFloat moveLength = action.Values[4].Item2 as FsmFloat;
            FsmString physicsMaterialName = action.Values[5].Item2 as FsmString;
        }
    }
}