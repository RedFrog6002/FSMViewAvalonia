using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AudioPlayerOneShotSingle
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject audioPlayer = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject spawnPoint = action.Values[1].Item2 as FsmGameObject;
            FsmObject audioClip = action.Values[2].Item2 as FsmObject;
            FsmFloat pitchMin = action.Values[3].Item2 as FsmFloat;
            FsmFloat pitchMax = action.Values[4].Item2 as FsmFloat;
            FsmFloat volume = action.Values[5].Item2 as FsmFloat;
            FsmFloat delay = action.Values[6].Item2 as FsmFloat;
            FsmGameObject storePlayer = action.Values[7].Item2 as FsmGameObject;
        }
    }
}