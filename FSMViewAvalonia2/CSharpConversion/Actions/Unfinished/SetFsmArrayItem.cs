using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetFsmArrayItem
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString fsmName = action.Values[1].Item2 as FsmString;
            FsmString variableName = action.Values[2].Item2 as FsmString;
            FsmInt index = action.Values[3].Item2 as FsmInt;
            FsmVar value = action.Values[4].Item2 as FsmVar;
            bool everyFrame = (bool)action.Values[5].Item2;
            string indexOutOfRange = action.Values[6].Item2 as string;
            string fsmNotFound = action.Values[7].Item2 as string;
            string variableNotFound = action.Values[8].Item2 as string;
        }
    }
}