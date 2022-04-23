using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class EnableBehaviour
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString behaviour = action.Values[1].Item2 as FsmString;
            Component component = action.Values[2].Item2 as Component;
            FsmBool enable = action.Values[3].Item2 as FsmBool;
            FsmBool resetOnExit = action.Values[4].Item2 as FsmBool;
        }
    }
}