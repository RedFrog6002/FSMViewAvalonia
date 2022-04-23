using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListGetClosestGameObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmGameObject distanceFrom = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 orDistanceFromVector3 = action.Values[3].Item2 as FsmVector3;
            bool everyframe = (bool)action.Values[4].Item2;
            FsmGameObject closestGameObject = action.Values[5].Item2 as FsmGameObject;
            FsmInt closestIndex = action.Values[6].Item2 as FsmInt;
        }
    }
}