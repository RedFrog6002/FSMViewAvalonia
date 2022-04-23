using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AudioPlayV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat volume = action.Values[1].Item2 as FsmFloat;
            FsmObject oneShotClip = action.Values[2].Item2 as FsmObject;
            string finishedEvent = action.Values[3].Item2 as string;
        }
    }
}