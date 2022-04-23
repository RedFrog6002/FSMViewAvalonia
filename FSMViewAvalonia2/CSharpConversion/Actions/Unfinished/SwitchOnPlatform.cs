using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SwitchOnPlatform
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string Standalone = action.Values[0].Item2 as string;
            string Switch = action.Values[1].Item2 as string;
            string PS4 = action.Values[2].Item2 as string;
            string XB1 = action.Values[3].Item2 as string;
            string Other = action.Values[4].Item2 as string;
        }
    }
}