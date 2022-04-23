using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUIContentAction
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmTexture image = action.Values[0].Item2 as FsmTexture;
            FsmString text = action.Values[1].Item2 as FsmString;
            FsmString tooltip = action.Values[2].Item2 as FsmString;
            FsmString style = action.Values[3].Item2 as FsmString;
            FsmRect screenRect = action.Values[4].Item2 as FsmRect;
            FsmFloat left = action.Values[5].Item2 as FsmFloat;
            FsmFloat top = action.Values[6].Item2 as FsmFloat;
            FsmFloat width = action.Values[7].Item2 as FsmFloat;
            FsmFloat height = action.Values[8].Item2 as FsmFloat;
            FsmBool normalized = action.Values[9].Item2 as FsmBool;
        }
    }
}