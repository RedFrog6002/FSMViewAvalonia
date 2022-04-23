using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SplitTextToArrayList
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmInt startIndex = action.Values[2].Item2 as FsmInt;
            FsmInt parseRange = action.Values[3].Item2 as FsmInt;
            TextAsset textAsset = action.Values[4].Item2 as TextAsset;
            FsmString OrThisString = action.Values[5].Item2 as FsmString;
            SplitSpecialChars split = action.Values[6].Item2 as SplitSpecialChars;
            FsmString OrThisChar = action.Values[7].Item2 as FsmString;
            ArrayMakerParseStringAs parseAsType = action.Values[8].Item2 as ArrayMakerParseStringAs;
        }
    }
}