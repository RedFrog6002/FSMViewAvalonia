using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Tk2dTextMeshGetColors
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmColor mainColor = action.Values[1].Item2 as FsmColor;
            FsmColor gradientColor = action.Values[2].Item2 as FsmColor;
            FsmBool useGradient = action.Values[3].Item2 as FsmBool;
            bool everyframe = (bool)action.Values[4].Item2;
        }
    }
}