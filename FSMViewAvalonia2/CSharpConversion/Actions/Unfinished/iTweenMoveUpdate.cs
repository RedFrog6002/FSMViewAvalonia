using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenMoveUpdate
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject transformPosition = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 vectorPosition = action.Values[2].Item2 as FsmVector3;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            Space space = action.Values[4].Item2 as Space;
            FsmBool orientToPath = action.Values[5].Item2 as FsmBool;
            FsmGameObject lookAtObject = action.Values[6].Item2 as FsmGameObject;
            FsmVector3 lookAtVector = action.Values[7].Item2 as FsmVector3;
            FsmFloat lookTime = action.Values[8].Item2 as FsmFloat;
            AxisRestriction axis = action.Values[9].Item2 as AxisRestriction;
        }
    }
}