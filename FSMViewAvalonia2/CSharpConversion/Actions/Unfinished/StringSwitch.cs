using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class StringSwitch
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString stringVariable = action.Values[0].Item2 as FsmString;
            FsmString[] compareTo = action.Values[1].Item2 as FsmString[];
            FsmEvent[] sendEvent = action.Values[2].Item2 as FsmEvent[];
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}