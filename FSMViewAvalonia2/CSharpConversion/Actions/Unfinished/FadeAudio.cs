using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FadeAudio
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat startVolume = action.Values[1].Item2 as FsmFloat;
            FsmFloat endVolume = action.Values[2].Item2 as FsmFloat;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
        }
    }
}