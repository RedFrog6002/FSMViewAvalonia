using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AudioPlayRandomSingle
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmObject audioClip = action.Values[1].Item2 as FsmObject;
            FsmFloat pitchMin = action.Values[2].Item2 as FsmFloat;
            FsmFloat pitchMax = action.Values[3].Item2 as FsmFloat;
        }
    }
}