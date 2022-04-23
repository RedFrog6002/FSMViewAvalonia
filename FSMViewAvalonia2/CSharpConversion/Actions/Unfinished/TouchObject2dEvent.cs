using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TouchObject2dEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt fingerId = action.Values[1].Item2 as FsmInt;
            string touchBegan = action.Values[2].Item2 as string;
            string touchMoved = action.Values[3].Item2 as string;
            string touchStationary = action.Values[4].Item2 as string;
            string touchEnded = action.Values[5].Item2 as string;
            string touchCanceled = action.Values[6].Item2 as string;
            FsmInt storeFingerId = action.Values[7].Item2 as FsmInt;
            FsmVector2 storeHitPoint = action.Values[8].Item2 as FsmVector2;
        }
    }
}