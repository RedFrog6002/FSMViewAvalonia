using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListGetFarthestGameObjectInSight
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmGameObject distanceFrom = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 orDistanceFromVector3 = action.Values[3].Item2 as FsmVector3;
            bool everyframe = (bool)action.Values[4].Item2;
            FsmOwnerDefault fromGameObject = action.Values[5].Item2 as FsmOwnerDefault;
            FsmInt[] layerMask = action.Values[6].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[7].Item2 as FsmBool;
            FsmGameObject farthestGameObject = action.Values[8].Item2 as FsmGameObject;
            FsmInt farthestIndex = action.Values[9].Item2 as FsmInt;
        }
    }
}