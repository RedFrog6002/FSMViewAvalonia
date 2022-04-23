using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayForEach
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray array = action.Values[0].Item2 as FsmArray;
            FsmVar storeItem = action.Values[1].Item2 as FsmVar;
            FsmTemplateControl fsmTemplateControl = action.Values[2].Item2 as FsmTemplateControl;
            string finishEvent = action.Values[3].Item2 as string;
        }
    }
}