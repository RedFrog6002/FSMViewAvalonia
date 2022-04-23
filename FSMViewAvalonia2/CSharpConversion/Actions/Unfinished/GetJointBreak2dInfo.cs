using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetJointBreak2dInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject brokenJoint = action.Values[0].Item2 as FsmObject;
            FsmVector2 reactionForce = action.Values[1].Item2 as FsmVector2;
            FsmFloat reactionForceMagnitude = action.Values[2].Item2 as FsmFloat;
            FsmFloat reactionTorque = action.Values[3].Item2 as FsmFloat;
        }
    }
}