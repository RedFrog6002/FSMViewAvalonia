using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class MoveTowards
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject targetObject = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 targetPosition = action.Values[2].Item2 as FsmVector3;
            FsmBool ignoreVertical = action.Values[3].Item2 as FsmBool;
            FsmFloat maxSpeed = action.Values[4].Item2 as FsmFloat;
            FsmFloat finishDistance = action.Values[5].Item2 as FsmFloat;
            string finishEvent = action.Values[6].Item2 as string;
        }
    }
}