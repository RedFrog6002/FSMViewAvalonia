using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiNavigationExplicitSetProperties
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject selectOnDown = action.Values[1].Item2 as FsmGameObject;
            FsmGameObject selectOnUp = action.Values[2].Item2 as FsmGameObject;
            FsmGameObject selectOnLeft = action.Values[3].Item2 as FsmGameObject;
            FsmGameObject selectOnRight = action.Values[4].Item2 as FsmGameObject;
            FsmBool resetOnExit = action.Values[5].Item2 as FsmBool;
        }
    }
}