using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BroadcastEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString broadcastEvent = action.Values[0].Item2 as FsmString;
            FsmGameObject gameObject = action.Values[1].Item2 as FsmGameObject;
            FsmBool sendToChildren = action.Values[2].Item2 as FsmBool;
            FsmBool excludeSelf = action.Values[3].Item2 as FsmBool;
        }
    }
}