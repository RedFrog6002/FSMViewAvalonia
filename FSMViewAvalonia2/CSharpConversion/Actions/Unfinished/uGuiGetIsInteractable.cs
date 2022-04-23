using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiGetIsInteractable
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool isInteractable = action.Values[1].Item2 as FsmBool;
            string isInteractableEvent = action.Values[2].Item2 as string;
            string isNotInteractableEvent = action.Values[3].Item2 as string;
        }
    }
}