using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GGCheckBoundHeart
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt healthNumber = action.Values[0].Item2 as FsmInt;
            CheckSource checkSource = action.Values[1].Item2 as CheckSource;
            string trueEvent = action.Values[2].Item2 as string;
            string falseEvent = action.Values[3].Item2 as string;
        }
    }
}