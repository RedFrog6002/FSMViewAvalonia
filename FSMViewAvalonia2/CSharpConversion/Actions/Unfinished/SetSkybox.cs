using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetSkybox
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmMaterial skybox = action.Values[0].Item2 as FsmMaterial;
            bool everyFrame = (bool)action.Values[1].Item2;
        }
    }
}