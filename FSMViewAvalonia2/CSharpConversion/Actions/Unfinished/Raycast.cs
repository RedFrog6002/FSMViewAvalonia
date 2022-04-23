using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Raycast
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault fromGameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 fromPosition = action.Values[1].Item2 as FsmVector3;
            FsmVector3 direction = action.Values[2].Item2 as FsmVector3;
            Space space = action.Values[3].Item2 as Space;
            FsmFloat distance = action.Values[4].Item2 as FsmFloat;
            string hitEvent = action.Values[5].Item2 as string;
            FsmBool storeDidHit = action.Values[6].Item2 as FsmBool;
            FsmGameObject storeHitObject = action.Values[7].Item2 as FsmGameObject;
            FsmVector3 storeHitPoint = action.Values[8].Item2 as FsmVector3;
            FsmVector3 storeHitNormal = action.Values[9].Item2 as FsmVector3;
            FsmFloat storeHitDistance = action.Values[10].Item2 as FsmFloat;
            FsmInt repeatInterval = action.Values[11].Item2 as FsmInt;
            FsmInt[] layerMask = action.Values[12].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[13].Item2 as FsmBool;
            FsmColor debugColor = action.Values[14].Item2 as FsmColor;
            FsmBool debug = action.Values[15].Item2 as FsmBool;
        }
    }
}