using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetTouchCount
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt storeCount = action.Values[0].Item2 as FsmInt;
            bool everyFrame = (bool)action.Values[1].Item2;
        }
    }
}