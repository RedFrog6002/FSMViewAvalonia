using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListSwapItems
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmInt index1 = action.Values[2].Item2 as FsmInt;
            FsmInt index2 = action.Values[3].Item2 as FsmInt;
            string failureEvent = action.Values[4].Item2 as string;
        }
    }
}