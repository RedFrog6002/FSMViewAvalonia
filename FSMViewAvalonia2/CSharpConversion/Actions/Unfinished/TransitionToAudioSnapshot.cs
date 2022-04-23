using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TransitionToAudioSnapshot
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject snapshot = action.Values[0].Item2 as FsmObject;
            FsmFloat transitionTime = action.Values[1].Item2 as FsmFloat;
        }
    }
}