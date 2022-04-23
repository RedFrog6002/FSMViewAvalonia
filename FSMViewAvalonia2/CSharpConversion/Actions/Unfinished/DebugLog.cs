using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DebugLog
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            LogLevel logLevel = action.Values[0].Item2 as LogLevel;
            FsmString text = action.Values[1].Item2 as FsmString;
            bool sendToUnityLog = (bool)action.Values[2].Item2;
        }
    }
}