using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BlendAnimation
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString animName = action.Values[1].Item2 as FsmString;
            FsmFloat targetWeight = action.Values[2].Item2 as FsmFloat;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            string finishEvent = action.Values[4].Item2 as string;
        }
    }
}