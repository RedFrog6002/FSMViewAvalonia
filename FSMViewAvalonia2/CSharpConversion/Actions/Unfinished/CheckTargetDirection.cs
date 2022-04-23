using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckTargetDirection
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject target = action.Values[1].Item2 as FsmGameObject;
            string aboveEvent = action.Values[2].Item2 as string;
            string belowEvent = action.Values[3].Item2 as string;
            string rightEvent = action.Values[4].Item2 as string;
            string leftEvent = action.Values[5].Item2 as string;
            FsmBool aboveBool = action.Values[6].Item2 as FsmBool;
            FsmBool belowBool = action.Values[7].Item2 as FsmBool;
            FsmBool rightBool = action.Values[8].Item2 as FsmBool;
            FsmBool leftBool = action.Values[9].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[10].Item2;
        }
    }
}