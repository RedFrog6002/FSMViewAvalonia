using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetTextureScale
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt materialIndex = action.Values[1].Item2 as FsmInt;
            FsmString namedTexture = action.Values[2].Item2 as FsmString;
            FsmFloat scaleX = action.Values[3].Item2 as FsmFloat;
            FsmFloat scaleY = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}