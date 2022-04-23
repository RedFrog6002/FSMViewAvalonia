using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ListenForMenuActions
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEventTarget eventTarget = action.Values[0].Item2 as FsmEventTarget;
            string submitPressed = action.Values[1].Item2 as string;
            string cancelPressed = action.Values[2].Item2 as string;
            FsmBool ignoreAttack = action.Values[3].Item2 as FsmBool;
        }
    }
}