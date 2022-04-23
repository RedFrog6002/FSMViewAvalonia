using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetCollision2dInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObjectHit = action.Values[0].Item2 as FsmGameObject;
            FsmVector3 relativeVelocity = action.Values[1].Item2 as FsmVector3;
            FsmFloat relativeSpeed = action.Values[2].Item2 as FsmFloat;
            FsmVector3 contactPoint = action.Values[3].Item2 as FsmVector3;
            FsmVector3 contactNormal = action.Values[4].Item2 as FsmVector3;
            FsmInt shapeCount = action.Values[5].Item2 as FsmInt;
            FsmString physics2dMaterialName = action.Values[6].Item2 as FsmString;
        }
    }
}