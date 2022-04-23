using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DistanceFly
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject target = action.Values[1].Item2 as FsmGameObject;
            FsmFloat distance = action.Values[2].Item2 as FsmFloat;
            FsmFloat speedMax = action.Values[3].Item2 as FsmFloat;
            FsmFloat acceleration = action.Values[4].Item2 as FsmFloat;
            bool targetsHeight = (bool)action.Values[5].Item2;
            FsmFloat height = action.Values[6].Item2 as FsmFloat;
        }
    }
}