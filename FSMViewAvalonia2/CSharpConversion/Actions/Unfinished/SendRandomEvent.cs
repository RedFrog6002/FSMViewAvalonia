using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SendRandomEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEvent[] events = action.Values[0].Item2 as FsmEvent[];
            FsmFloat[] weights = action.Values[1].Item2 as FsmFloat[];
            FsmFloat delay = action.Values[2].Item2 as FsmFloat;
        }
    }
}