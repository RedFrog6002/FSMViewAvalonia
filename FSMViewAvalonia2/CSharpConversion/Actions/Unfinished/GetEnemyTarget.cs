using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetEnemyTarget
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault listHolder = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject storeTarget = action.Values[1].Item2 as FsmGameObject;
        }
    }
}