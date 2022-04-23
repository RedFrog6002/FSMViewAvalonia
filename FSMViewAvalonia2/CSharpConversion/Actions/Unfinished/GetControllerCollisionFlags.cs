using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetControllerCollisionFlags
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool isGrounded = action.Values[1].Item2 as FsmBool;
            FsmBool none = action.Values[2].Item2 as FsmBool;
            FsmBool sides = action.Values[3].Item2 as FsmBool;
            FsmBool above = action.Values[4].Item2 as FsmBool;
            FsmBool below = action.Values[5].Item2 as FsmBool;
        }
    }
}