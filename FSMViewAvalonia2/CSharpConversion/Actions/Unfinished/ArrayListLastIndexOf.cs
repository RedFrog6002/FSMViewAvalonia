using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListLastIndexOf
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmInt startIndex = action.Values[2].Item2 as FsmInt;
            FsmInt count = action.Values[3].Item2 as FsmInt;
            FsmVar variable = action.Values[4].Item2 as FsmVar;
            FsmInt lastIndexOf = action.Values[5].Item2 as FsmInt;
            string itemFound = action.Values[6].Item2 as string;
            string itemNotFound = action.Values[7].Item2 as string;
            string failureEvent = action.Values[8].Item2 as string;
        }
    }
}