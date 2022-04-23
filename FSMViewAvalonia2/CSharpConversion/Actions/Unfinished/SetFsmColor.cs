using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetFsmColor
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString fsmName = action.Values[1].Item2 as FsmString;
            FsmString variableName = action.Values[2].Item2 as FsmString;
            FsmColor setValue = action.Values[3].Item2 as FsmColor;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}