using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class IsPointerOverUiObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt pointerId = action.Values[0].Item2 as FsmInt;
            string pointerOverUI = action.Values[1].Item2 as string;
            string pointerNotOverUI = action.Values[2].Item2 as string;
            FsmBool isPointerOverUI = action.Values[3].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}