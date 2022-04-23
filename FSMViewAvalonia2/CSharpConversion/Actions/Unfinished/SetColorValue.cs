using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetColorValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor colorVariable = action.Values[0].Item2 as FsmColor;
            FsmColor color = action.Values[1].Item2 as FsmColor;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}