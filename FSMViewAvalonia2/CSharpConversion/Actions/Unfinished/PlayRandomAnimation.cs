using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PlayRandomAnimation
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString[] animations = action.Values[1].Item2 as FsmString[];
            FsmFloat[] weights = action.Values[2].Item2 as FsmFloat[];
            PlayMode playMode = action.Values[3].Item2 as PlayMode;
            FsmFloat blendTime = action.Values[4].Item2 as FsmFloat;
            string finishEvent = action.Values[5].Item2 as string;
            string loopEvent = action.Values[6].Item2 as string;
            bool stopOnExit = (bool)action.Values[7].Item2;
        }
    }
}