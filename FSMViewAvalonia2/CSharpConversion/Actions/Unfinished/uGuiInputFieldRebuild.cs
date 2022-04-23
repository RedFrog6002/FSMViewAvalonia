using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiInputFieldRebuild
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            CanvasUpdate canvasUpdate = action.Values[1].Item2 as CanvasUpdate;
            bool rebuildOnExit = (bool)action.Values[2].Item2;
        }
    }
}