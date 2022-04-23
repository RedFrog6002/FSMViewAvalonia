using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FsmStateTest
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmString fsmName = action.Values[1].Item2 as FsmString;
            FsmString stateName = action.Values[2].Item2 as FsmString;
            string trueEvent = action.Values[3].Item2 as string;
            string falseEvent = action.Values[4].Item2 as string;
            FsmBool storeResult = action.Values[5].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}