using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutBeginArea
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect screenRect = action.Values[0].Item2 as FsmRect;
            FsmFloat left = action.Values[1].Item2 as FsmFloat;
            FsmFloat top = action.Values[2].Item2 as FsmFloat;
            FsmFloat width = action.Values[3].Item2 as FsmFloat;
            FsmFloat height = action.Values[4].Item2 as FsmFloat;
            FsmBool normalized = action.Values[5].Item2 as FsmBool;
            FsmString style = action.Values[6].Item2 as FsmString;
        }
    }
}