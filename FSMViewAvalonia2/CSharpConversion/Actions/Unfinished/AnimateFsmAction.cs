using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimateFsmAction
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat time = action.Values[0].Item2 as FsmFloat;
            FsmFloat speed = action.Values[1].Item2 as FsmFloat;
            FsmFloat delay = action.Values[2].Item2 as FsmFloat;
            FsmBool ignoreCurveOffset = action.Values[3].Item2 as FsmBool;
            string finishEvent = action.Values[4].Item2 as string;
            bool realTime = (bool)action.Values[5].Item2;
        }
    }
}