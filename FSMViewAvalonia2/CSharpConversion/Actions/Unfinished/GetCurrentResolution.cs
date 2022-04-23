using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetCurrentResolution
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat width = action.Values[0].Item2 as FsmFloat;
            FsmFloat height = action.Values[1].Item2 as FsmFloat;
            FsmFloat refreshRate = action.Values[2].Item2 as FsmFloat;
            FsmVector3 currentResolution = action.Values[3].Item2 as FsmVector3;
        }
    }
}