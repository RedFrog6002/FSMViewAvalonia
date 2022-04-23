using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetAmbientLight
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor ambientColor = action.Values[0].Item2 as FsmColor;
            bool everyFrame = (bool)action.Values[1].Item2;
        }
    }
}