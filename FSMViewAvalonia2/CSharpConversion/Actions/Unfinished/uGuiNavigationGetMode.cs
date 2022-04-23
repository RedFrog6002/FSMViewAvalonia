using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiNavigationGetMode
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString navigationMode = action.Values[1].Item2 as FsmString;
            string automaticEvent = action.Values[2].Item2 as string;
            string horizontalEvent = action.Values[3].Item2 as string;
            string verticalEvent = action.Values[4].Item2 as string;
            string explicitEvent = action.Values[5].Item2 as string;
            string noNavigationEvent = action.Values[6].Item2 as string;
        }
    }
}