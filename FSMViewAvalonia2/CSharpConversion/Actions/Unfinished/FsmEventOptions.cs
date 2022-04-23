using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FsmEventOptions
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            PlayMakerFSM sendToFsmComponent = action.Values[0].Item2 as PlayMakerFSM;
            FsmGameObject sendToGameObject = action.Values[1].Item2 as FsmGameObject;
            FsmString fsmName = action.Values[2].Item2 as FsmString;
            FsmBool sendToChildren = action.Values[3].Item2 as FsmBool;
            FsmBool broadcastToAll = action.Values[4].Item2 as FsmBool;
        }
    }
}