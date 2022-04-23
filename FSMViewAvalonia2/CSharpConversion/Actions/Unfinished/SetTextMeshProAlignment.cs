using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetTextMeshProAlignment
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool topLeft = action.Values[1].Item2 as FsmBool;
            FsmBool topRight = action.Values[2].Item2 as FsmBool;
            FsmBool topCentre = action.Values[3].Item2 as FsmBool;
            FsmBool topJustified = action.Values[4].Item2 as FsmBool;
            FsmBool centreLeft = action.Values[5].Item2 as FsmBool;
            FsmBool centreRight = action.Values[6].Item2 as FsmBool;
            FsmBool centreCentre = action.Values[7].Item2 as FsmBool;
            FsmBool centreJustified = action.Values[8].Item2 as FsmBool;
            FsmBool bottomLeft = action.Values[9].Item2 as FsmBool;
            FsmBool bottomRight = action.Values[10].Item2 as FsmBool;
            FsmBool bottomCentre = action.Values[11].Item2 as FsmBool;
            FsmBool bottomJustified = action.Values[12].Item2 as FsmBool;
        }
    }
}