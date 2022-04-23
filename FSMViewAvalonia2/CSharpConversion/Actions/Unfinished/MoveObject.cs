using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class MoveObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault objectToMove = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject destination = action.Values[1].Item2 as FsmGameObject;
            FsmFloat time = action.Values[2].Item2 as FsmFloat;
            FsmFloat speed = action.Values[3].Item2 as FsmFloat;
            FsmFloat delay = action.Values[4].Item2 as FsmFloat;
            EaseType easeType = action.Values[5].Item2 as EaseType;
            FsmBool reverse = action.Values[6].Item2 as FsmBool;
            string finishEvent = action.Values[7].Item2 as string;
            bool realTime = (bool)action.Values[8].Item2;
        }
    }
}