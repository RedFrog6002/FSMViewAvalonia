using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Tk2dPlayAnimation
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            state.AddMiddleCode(GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".GetComponent<tk2dSpriteAnimator>().Play(" + action.Values[2].Item2 + ");");
        }
    }
}
