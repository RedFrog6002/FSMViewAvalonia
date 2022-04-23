using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetMaterialTexture
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt materialIndex = action.Values[1].Item2 as FsmInt;
            FsmMaterial material = action.Values[2].Item2 as FsmMaterial;
            FsmString namedTexture = action.Values[3].Item2 as FsmString;
            FsmTexture texture = action.Values[4].Item2 as FsmTexture;
        }
    }
}