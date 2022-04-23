using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FindClosest
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString withTag = action.Values[1].Item2 as FsmString;
            FsmBool ignoreOwner = action.Values[2].Item2 as FsmBool;
            FsmBool mustBeVisible = action.Values[3].Item2 as FsmBool;
            FsmGameObject storeObject = action.Values[4].Item2 as FsmGameObject;
            FsmFloat storeDistance = action.Values[5].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}