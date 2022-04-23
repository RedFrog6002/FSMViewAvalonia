using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Tk2dPlayAnimationV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString animLibName = action.Values[1].Item2 as FsmString;
            FsmString clipName = action.Values[2].Item2 as FsmString;
            bool doNotResetCurrentClip = (bool)action.Values[3].Item2;
        }
    }
}