using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ScaleGUI
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat scaleX = action.Values[0].Item2 as FsmFloat;
            FsmFloat scaleY = action.Values[1].Item2 as FsmFloat;
            FsmFloat pivotX = action.Values[2].Item2 as FsmFloat;
            FsmFloat pivotY = action.Values[3].Item2 as FsmFloat;
            bool normalized = (bool)action.Values[4].Item2;
            bool applyGlobally = (bool)action.Values[5].Item2;
        }
    }
}