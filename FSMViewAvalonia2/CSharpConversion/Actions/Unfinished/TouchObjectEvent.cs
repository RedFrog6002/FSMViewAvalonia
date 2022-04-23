using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TouchObjectEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat pickDistance = action.Values[1].Item2 as FsmFloat;
            FsmInt fingerId = action.Values[2].Item2 as FsmInt;
            string touchBegan = action.Values[3].Item2 as string;
            string touchMoved = action.Values[4].Item2 as string;
            string touchStationary = action.Values[5].Item2 as string;
            string touchEnded = action.Values[6].Item2 as string;
            string touchCanceled = action.Values[7].Item2 as string;
            FsmInt storeFingerId = action.Values[8].Item2 as FsmInt;
            FsmVector3 storeHitPoint = action.Values[9].Item2 as FsmVector3;
            FsmVector3 storeHitNormal = action.Values[10].Item2 as FsmVector3;
        }
    }
}