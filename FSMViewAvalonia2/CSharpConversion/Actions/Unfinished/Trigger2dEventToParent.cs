using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Trigger2dEventToParent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            Trigger2DType trigger = action.Values[0].Item2 as Trigger2DType;
            FsmString collideTag = action.Values[1].Item2 as FsmString;
            FsmInt collideLayer = action.Values[2].Item2 as FsmInt;
            string sendEvent = action.Values[3].Item2 as string;
            FsmGameObject storeCollider = action.Values[4].Item2 as FsmGameObject;
        }
    }
}