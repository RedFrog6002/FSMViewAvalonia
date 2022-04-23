using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListGetMaxValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            bool everyframe = (bool)action.Values[2].Item2;
            FsmVar maximumValue = action.Values[3].Item2 as FsmVar;
            FsmInt maximumValueIndex = action.Values[4].Item2 as FsmInt;
        }
    }
}