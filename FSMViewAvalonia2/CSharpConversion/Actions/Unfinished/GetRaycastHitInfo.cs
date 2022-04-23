using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetRaycastHitInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObjectHit = action.Values[0].Item2 as FsmGameObject;
            FsmVector3 point = action.Values[1].Item2 as FsmVector3;
            FsmVector3 normal = action.Values[2].Item2 as FsmVector3;
            FsmFloat distance = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}