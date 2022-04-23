using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TriggerEnterEventSubscribe
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject trigger = action.Values[0].Item2 as FsmObject;
            string triggerEnteredEvent = action.Values[1].Item2 as string;
            string triggerExitedEvent = action.Values[2].Item2 as string;
            string triggerStayedEvent = action.Values[3].Item2 as string;
        }
    }
}