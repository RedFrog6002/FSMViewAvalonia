using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetNextRayCast2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault fromGameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 fromPosition = action.Values[1].Item2 as FsmVector2;
            FsmVector2 direction = action.Values[2].Item2 as FsmVector2;
            Space space = action.Values[3].Item2 as Space;
            FsmFloat distance = action.Values[4].Item2 as FsmFloat;
            FsmInt minDepth = action.Values[5].Item2 as FsmInt;
            FsmInt maxDepth = action.Values[6].Item2 as FsmInt;
            FsmInt[] layerMask = action.Values[7].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[8].Item2 as FsmBool;
            FsmInt collidersCount = action.Values[9].Item2 as FsmInt;
            FsmGameObject storeNextCollider = action.Values[10].Item2 as FsmGameObject;
            FsmVector2 storeNextHitPoint = action.Values[11].Item2 as FsmVector2;
            FsmVector2 storeNextHitNormal = action.Values[12].Item2 as FsmVector2;
            FsmFloat storeNextHitDistance = action.Values[13].Item2 as FsmFloat;
            FsmFloat storeNextHitFraction = action.Values[14].Item2 as FsmFloat;
            string loopEvent = action.Values[15].Item2 as string;
            string finishedEvent = action.Values[16].Item2 as string;
        }
    }
}