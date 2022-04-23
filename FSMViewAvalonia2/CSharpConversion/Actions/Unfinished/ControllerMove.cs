using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ControllerMove
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 moveVector = action.Values[1].Item2 as FsmVector3;
            Space space = action.Values[2].Item2 as Space;
            FsmBool perSecond = action.Values[3].Item2 as FsmBool;
        }
    }
}