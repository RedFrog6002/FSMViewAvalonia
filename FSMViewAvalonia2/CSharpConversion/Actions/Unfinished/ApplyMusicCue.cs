using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ApplyMusicCue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject musicCue = action.Values[0].Item2 as FsmObject;
            FsmFloat delayTime = action.Values[1].Item2 as FsmFloat;
            FsmFloat transitionTime = action.Values[2].Item2 as FsmFloat;
        }
    }
}