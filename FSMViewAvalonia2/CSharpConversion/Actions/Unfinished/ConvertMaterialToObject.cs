using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ConvertMaterialToObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmMaterial materialVariable = action.Values[0].Item2 as FsmMaterial;
            FsmObject objectVariable = action.Values[1].Item2 as FsmObject;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}