using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LoadLevelNum
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt levelIndex = action.Values[0].Item2 as FsmInt;
            bool additive = (bool)action.Values[1].Item2;
            string loadedEvent = action.Values[2].Item2 as string;
            FsmBool dontDestroyOnLoad = action.Values[3].Item2 as FsmBool;
            string failedEvent = action.Values[4].Item2 as string;
        }
    }
}