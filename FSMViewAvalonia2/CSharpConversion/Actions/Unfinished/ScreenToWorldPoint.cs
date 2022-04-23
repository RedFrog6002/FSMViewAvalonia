using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ScreenToWorldPoint
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 screenVector = action.Values[0].Item2 as FsmVector3;
            FsmFloat screenX = action.Values[1].Item2 as FsmFloat;
            FsmFloat screenY = action.Values[2].Item2 as FsmFloat;
            FsmFloat screenZ = action.Values[3].Item2 as FsmFloat;
            FsmBool normalized = action.Values[4].Item2 as FsmBool;
            FsmVector3 storeWorldVector = action.Values[5].Item2 as FsmVector3;
            FsmFloat storeWorldX = action.Values[6].Item2 as FsmFloat;
            FsmFloat storeWorldY = action.Values[7].Item2 as FsmFloat;
            FsmFloat storeWorldZ = action.Values[8].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[9].Item2;
        }
    }
}