using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class HashTableGetKeyFromValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmVar theValue = action.Values[2].Item2 as FsmVar;
            FsmString result = action.Values[3].Item2 as FsmString;
            string KeyFoundEvent = action.Values[4].Item2 as string;
            string KeyNotFoundEvent = action.Values[5].Item2 as string;
        }
    }
}