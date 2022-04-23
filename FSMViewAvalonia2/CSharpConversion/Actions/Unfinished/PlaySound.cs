using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PlaySound
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 position = action.Values[1].Item2 as FsmVector3;
            FsmObject clip = action.Values[2].Item2 as FsmObject;
            FsmFloat volume = action.Values[3].Item2 as FsmFloat;
        }
    }
}