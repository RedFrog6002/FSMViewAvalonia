using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Tk2dTextMeshGetProperties
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString text = action.Values[1].Item2 as FsmString;
            FsmBool inlineStyling = action.Values[2].Item2 as FsmBool;
            FsmString anchor = action.Values[3].Item2 as FsmString;
            FsmBool kerning = action.Values[4].Item2 as FsmBool;
            FsmInt maxChars = action.Values[5].Item2 as FsmInt;
            FsmInt NumDrawnCharacters = action.Values[6].Item2 as FsmInt;
            FsmColor mainColor = action.Values[7].Item2 as FsmColor;
            FsmColor gradientColor = action.Values[8].Item2 as FsmColor;
            FsmBool useGradient = action.Values[9].Item2 as FsmBool;
            FsmInt textureGradient = action.Values[10].Item2 as FsmInt;
            FsmVector3 scale = action.Values[11].Item2 as FsmVector3;
        }
    }
}