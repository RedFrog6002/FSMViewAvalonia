using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAxisVector
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString horizontalAxis = action.Values[0].Item2 as FsmString;
            FsmString verticalAxis = action.Values[1].Item2 as FsmString;
            FsmFloat multiplier = action.Values[2].Item2 as FsmFloat;
            AxisPlane mapToPlane = action.Values[3].Item2 as AxisPlane;
            FsmGameObject relativeTo = action.Values[4].Item2 as FsmGameObject;
            FsmVector3 storeVector = action.Values[5].Item2 as FsmVector3;
            FsmFloat storeMagnitude = action.Values[6].Item2 as FsmFloat;
        }
    }
}