using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetRectFields
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect rectVariable = action.Values[0].Item2 as FsmRect;
            FsmFloat storeX = action.Values[1].Item2 as FsmFloat;
            FsmFloat storeY = action.Values[2].Item2 as FsmFloat;
            FsmFloat storeWidth = action.Values[3].Item2 as FsmFloat;
            FsmFloat storeHeight = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}