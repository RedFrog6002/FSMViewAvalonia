using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenPause
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            iTweenFSMType iTweenType = action.Values[1].Item2 as iTweenFSMType;
            bool includeChildren = (bool)action.Values[2].Item2;
            bool inScene = (bool)action.Values[3].Item2;
        }
    }
}