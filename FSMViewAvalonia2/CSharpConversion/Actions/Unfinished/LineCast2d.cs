using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LineCast2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault fromGameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 fromPosition = action.Values[1].Item2 as FsmVector2;
            FsmGameObject toGameObject = action.Values[2].Item2 as FsmGameObject;
            FsmVector2 toPosition = action.Values[3].Item2 as FsmVector2;
            FsmInt minDepth = action.Values[4].Item2 as FsmInt;
            FsmInt maxDepth = action.Values[5].Item2 as FsmInt;
            string hitEvent = action.Values[6].Item2 as string;
            FsmBool storeDidHit = action.Values[7].Item2 as FsmBool;
            FsmGameObject storeHitObject = action.Values[8].Item2 as FsmGameObject;
            FsmVector2 storeHitPoint = action.Values[9].Item2 as FsmVector2;
            FsmVector2 storeHitNormal = action.Values[10].Item2 as FsmVector2;
            FsmFloat storeHitDistance = action.Values[11].Item2 as FsmFloat;
            FsmInt repeatInterval = action.Values[12].Item2 as FsmInt;
            FsmInt[] layerMask = action.Values[13].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[14].Item2 as FsmBool;
            FsmColor debugColor = action.Values[15].Item2 as FsmColor;
            FsmBool debug = action.Values[16].Item2 as FsmBool;
        }
    }
}