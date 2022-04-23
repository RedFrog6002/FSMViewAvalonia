using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LoadLevel
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString levelName = action.Values[0].Item2 as FsmString;
            bool additive = (bool)action.Values[1].Item2;
            bool async = (bool)action.Values[2].Item2;
            string loadedEvent = action.Values[3].Item2 as string;
            FsmBool dontDestroyOnLoad = action.Values[4].Item2 as FsmBool;
            string failedEvent = action.Values[5].Item2 as string;
        }
    }
}