using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SelectRandomColor
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor[] colors = action.Values[0].Item2 as FsmColor[];
            FsmFloat[] weights = action.Values[1].Item2 as FsmFloat[];
            FsmColor storeColor = action.Values[2].Item2 as FsmColor;
        }
    }
}