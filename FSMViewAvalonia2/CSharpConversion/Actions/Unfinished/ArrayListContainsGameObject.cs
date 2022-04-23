using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListContainsGameObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmString gameObjectName = action.Values[2].Item2 as FsmString;
            FsmString withTag = action.Values[3].Item2 as FsmString;
            FsmGameObject result = action.Values[4].Item2 as FsmGameObject;
            FsmInt resultIndex = action.Values[5].Item2 as FsmInt;
            FsmBool isContained = action.Values[6].Item2 as FsmBool;
            string isContainedEvent = action.Values[7].Item2 as string;
            string isNotContainedEvent = action.Values[8].Item2 as string;
        }
    }
}