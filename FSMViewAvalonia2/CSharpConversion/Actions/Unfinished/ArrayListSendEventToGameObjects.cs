using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListSendEventToGameObjects
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEventTarget eventTarget = action.Values[0].Item2 as FsmEventTarget;
            FsmOwnerDefault gameObject = action.Values[1].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[2].Item2 as FsmString;
            string sendEvent = action.Values[3].Item2 as string;
            FsmBool excludeSelf = action.Values[4].Item2 as FsmBool;
            FsmBool sendToChildren = action.Values[5].Item2 as FsmBool;
        }
    }
}