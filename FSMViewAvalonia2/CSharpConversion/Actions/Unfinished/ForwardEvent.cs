using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ForwardEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEventTarget forwardTo = action.Values[0].Item2 as FsmEventTarget;
            FsmEvent[] eventsToForward = action.Values[1].Item2 as FsmEvent[];
            bool eatEvents = (bool)action.Values[2].Item2;
        }
    }
}