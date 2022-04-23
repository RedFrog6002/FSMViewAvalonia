using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenRotateUpdate
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject transformRotation = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 vectorRotation = action.Values[2].Item2 as FsmVector3;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            Space space = action.Values[4].Item2 as Space;
        }
    }
}