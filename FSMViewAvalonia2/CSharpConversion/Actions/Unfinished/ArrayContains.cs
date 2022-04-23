using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayContains
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray array = action.Values[0].Item2 as FsmArray;
            FsmVar value = action.Values[1].Item2 as FsmVar;
            FsmInt index = action.Values[2].Item2 as FsmInt;
            FsmBool isContained = action.Values[3].Item2 as FsmBool;
            string isContainedEvent = action.Values[4].Item2 as string;
            string isNotContainedEvent = action.Values[5].Item2 as string;
        }
    }
}