using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LerpTk2dSpriteColor
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault Target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmColor TargetColor = action.Values[1].Item2 as FsmColor;
            FsmFloat LerpTime = action.Values[2].Item2 as FsmFloat;
        }
    }
}