using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayGetNext
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray array = action.Values[0].Item2 as FsmArray;
            FsmInt startIndex = action.Values[1].Item2 as FsmInt;
            FsmInt endIndex = action.Values[2].Item2 as FsmInt;
            string loopEvent = action.Values[3].Item2 as string;
            string finishedEvent = action.Values[4].Item2 as string;
            FsmVar result = action.Values[5].Item2 as FsmVar;
            FsmInt currentIndex = action.Values[6].Item2 as FsmInt;
        }
    }
}