using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class EnumSwitch
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEnum enumVariable = action.Values[0].Item2 as FsmEnum;
            FsmEnum[] compareTo = action.Values[1].Item2 as FsmEnum[];
            FsmEvent[] sendEvent = action.Values[2].Item2 as FsmEvent[];
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}