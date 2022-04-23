using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FlipScale
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            bool flipHorizontally = (bool)action.Values[1].Item2;
            bool flipVertically = (bool)action.Values[2].Item2;
            bool everyFrame = (bool)action.Values[3].Item2;
            bool lateUpdate = (bool)action.Values[4].Item2;
        }
    }
}