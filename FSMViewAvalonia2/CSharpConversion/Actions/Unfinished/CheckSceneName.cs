using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckSceneName
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString sceneName = action.Values[0].Item2 as FsmString;
            string equalEvent = action.Values[1].Item2 as string;
            string notEqualEvent = action.Values[2].Item2 as string;
        }
    }
}