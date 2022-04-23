using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PlayAudioEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject audioClip = action.Values[0].Item2 as FsmObject;
            FsmFloat pitchMin = action.Values[1].Item2 as FsmFloat;
            FsmFloat pitchMax = action.Values[2].Item2 as FsmFloat;
            FsmFloat volume = action.Values[3].Item2 as FsmFloat;
            FsmObject audioPlayerPrefab = action.Values[4].Item2 as FsmObject;
            FsmOwnerDefault spawnPoint = action.Values[5].Item2 as FsmOwnerDefault;
            FsmVector3 spawnPosition = action.Values[6].Item2 as FsmVector3;
        }
    }
}