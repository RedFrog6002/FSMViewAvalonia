using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetGameObjectSelf
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject variable = action.Values[0].Item2 as FsmGameObject;
            FsmOwnerDefault gameObject = action.Values[1].Item2 as FsmOwnerDefault;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}