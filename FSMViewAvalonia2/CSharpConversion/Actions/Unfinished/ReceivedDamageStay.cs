using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ReceivedDamageStay
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString collideTag = action.Values[0].Item2 as FsmString;
            string sendEvent = action.Values[1].Item2 as string;
            FsmString fsmName = action.Values[2].Item2 as FsmString;
            FsmGameObject storeGameObject = action.Values[3].Item2 as FsmGameObject;
            FsmBool ignoreAcid = action.Values[4].Item2 as FsmBool;
        }
    }
}