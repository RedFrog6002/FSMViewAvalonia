using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DebugLogDeprecatedEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString noteText = action.Values[0].Item2 as FsmString;
            bool sendToUnityLog = (bool)action.Values[1].Item2;
        }
    }
}