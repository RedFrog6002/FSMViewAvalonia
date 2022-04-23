using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListGetNext
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmBool reset = action.Values[2].Item2 as FsmBool;
            FsmInt startIndex = action.Values[3].Item2 as FsmInt;
            FsmInt endIndex = action.Values[4].Item2 as FsmInt;
            string loopEvent = action.Values[5].Item2 as string;
            string finishedEvent = action.Values[6].Item2 as string;
            string failureEvent = action.Values[7].Item2 as string;
            FsmInt currentIndex = action.Values[8].Item2 as FsmInt;
            FsmVar result = action.Values[9].Item2 as FsmVar;
        }
    }
}