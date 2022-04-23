using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetNextOverlapPoint2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 position = action.Values[1].Item2 as FsmVector2;
            FsmInt minDepth = action.Values[2].Item2 as FsmInt;
            FsmInt maxDepth = action.Values[3].Item2 as FsmInt;
            FsmInt[] layerMask = action.Values[4].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[5].Item2 as FsmBool;
            FsmInt collidersCount = action.Values[6].Item2 as FsmInt;
            FsmGameObject storeNextCollider = action.Values[7].Item2 as FsmGameObject;
            string loopEvent = action.Values[8].Item2 as string;
            string finishedEvent = action.Values[9].Item2 as string;
        }
    }
}