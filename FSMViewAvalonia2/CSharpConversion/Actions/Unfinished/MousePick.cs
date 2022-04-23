using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class MousePick
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat rayDistance = action.Values[0].Item2 as FsmFloat;
            FsmBool storeDidPickObject = action.Values[1].Item2 as FsmBool;
            FsmGameObject storeGameObject = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 storePoint = action.Values[3].Item2 as FsmVector3;
            FsmVector3 storeNormal = action.Values[4].Item2 as FsmVector3;
            FsmFloat storeDistance = action.Values[5].Item2 as FsmFloat;
            FsmInt[] layerMask = action.Values[6].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[7].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[8].Item2;
        }
    }
}