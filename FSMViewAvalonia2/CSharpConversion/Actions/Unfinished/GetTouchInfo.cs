using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetTouchInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt fingerId = action.Values[0].Item2 as FsmInt;
            FsmBool normalize = action.Values[1].Item2 as FsmBool;
            FsmVector3 storePosition = action.Values[2].Item2 as FsmVector3;
            FsmFloat storeX = action.Values[3].Item2 as FsmFloat;
            FsmFloat storeY = action.Values[4].Item2 as FsmFloat;
            FsmVector3 storeDeltaPosition = action.Values[5].Item2 as FsmVector3;
            FsmFloat storeDeltaX = action.Values[6].Item2 as FsmFloat;
            FsmFloat storeDeltaY = action.Values[7].Item2 as FsmFloat;
            FsmFloat storeDeltaTime = action.Values[8].Item2 as FsmFloat;
            FsmInt storeTapCount = action.Values[9].Item2 as FsmInt;
            bool everyFrame = (bool)action.Values[10].Item2;
        }
    }
}