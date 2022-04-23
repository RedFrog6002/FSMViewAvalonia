using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Tk2dTextMeshSetScale
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 scale = action.Values[1].Item2 as FsmVector3;
            FsmBool commit = action.Values[2].Item2 as FsmBool;
            bool everyframe = (bool)action.Values[3].Item2;
        }
    }
}