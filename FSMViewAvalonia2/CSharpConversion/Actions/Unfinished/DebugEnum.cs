using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DebugEnum
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            LogLevel logLevel = action.Values[0].Item2 as LogLevel;
            FsmEnum enumVariable = action.Values[1].Item2 as FsmEnum;
            bool sendToUnityLog = (bool)action.Values[2].Item2;
        }
    }
}