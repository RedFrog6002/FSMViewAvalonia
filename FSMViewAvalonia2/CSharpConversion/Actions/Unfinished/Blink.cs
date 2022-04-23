using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Blink
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat timeOff = action.Values[1].Item2 as FsmFloat;
            FsmFloat timeOn = action.Values[2].Item2 as FsmFloat;
            FsmBool startOn = action.Values[3].Item2 as FsmBool;
            bool rendererOnly = (bool)action.Values[4].Item2;
            bool realTime = (bool)action.Values[5].Item2;
        }
    }
}