using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class InvokeMethod
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString behaviour = action.Values[1].Item2 as FsmString;
            FsmString methodName = action.Values[2].Item2 as FsmString;
            FsmFloat delay = action.Values[3].Item2 as FsmFloat;
            FsmBool repeating = action.Values[4].Item2 as FsmBool;
            FsmFloat repeatDelay = action.Values[5].Item2 as FsmFloat;
            FsmBool cancelOnExit = action.Values[6].Item2 as FsmBool;
        }
    }
}