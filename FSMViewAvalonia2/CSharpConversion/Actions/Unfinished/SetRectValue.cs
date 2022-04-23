using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetRectValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect rectVariable = action.Values[0].Item2 as FsmRect;
            FsmRect rectValue = action.Values[1].Item2 as FsmRect;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}