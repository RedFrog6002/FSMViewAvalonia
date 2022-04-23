using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SendEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEventTarget eventTarget = action.Values[0].Item2 as FsmEventTarget;
            string sendEvent = action.Values[1].Item2 as string;
            FsmFloat delay = action.Values[2].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}