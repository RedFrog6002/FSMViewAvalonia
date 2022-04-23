using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Vector3RotateTowards
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 currentDirection = action.Values[0].Item2 as FsmVector3;
            FsmVector3 targetDirection = action.Values[1].Item2 as FsmVector3;
            FsmFloat rotateSpeed = action.Values[2].Item2 as FsmFloat;
            FsmFloat maxMagnitude = action.Values[3].Item2 as FsmFloat;
        }
    }
}