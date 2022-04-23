using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatSwitch
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatVariable = action.Values[0].Item2 as FsmFloat;
            FsmFloat[] lessThan = action.Values[1].Item2 as FsmFloat[];
            FsmEvent[] sendEvent = action.Values[2].Item2 as FsmEvent[];
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}