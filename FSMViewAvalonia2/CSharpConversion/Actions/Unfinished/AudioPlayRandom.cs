using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AudioPlayRandom
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            AudioClip[] audioClips = action.Values[1].Item2 as AudioClip[];
            FsmFloat[] weights = action.Values[2].Item2 as FsmFloat[];
            FsmFloat pitchMin = action.Values[3].Item2 as FsmFloat;
            FsmFloat pitchMax = action.Values[4].Item2 as FsmFloat;
        }
    }
}