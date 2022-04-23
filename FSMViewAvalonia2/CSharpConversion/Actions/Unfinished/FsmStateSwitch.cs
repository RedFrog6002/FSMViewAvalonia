using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FsmStateSwitch
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmString fsmName = action.Values[1].Item2 as FsmString;
            FsmString[] compareTo = action.Values[2].Item2 as FsmString[];
            FsmEvent[] sendEvent = action.Values[3].Item2 as FsmEvent[];
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}