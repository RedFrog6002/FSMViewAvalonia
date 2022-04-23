using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListGetGameobjectMaxFsmFloatIndex
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmString fsmName = action.Values[2].Item2 as FsmString;
            FsmString variableName = action.Values[3].Item2 as FsmString;
            bool everyframe = (bool)action.Values[4].Item2;
            FsmFloat storeMaxValue = action.Values[5].Item2 as FsmFloat;
            FsmGameObject maxGameObject = action.Values[6].Item2 as FsmGameObject;
            FsmInt maxIndex = action.Values[7].Item2 as FsmInt;
        }
    }
}