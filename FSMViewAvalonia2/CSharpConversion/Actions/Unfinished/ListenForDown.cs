using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ListenForDown
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEventTarget eventTarget = action.Values[0].Item2 as FsmEventTarget;
            string wasPressed = action.Values[1].Item2 as string;
            string wasReleased = action.Values[2].Item2 as string;
            string isPressed = action.Values[3].Item2 as string;
            string isNotPressed = action.Values[4].Item2 as string;
            FsmBool isPressedBool = action.Values[5].Item2 as FsmBool;
            bool stateEntryOnly = (bool)action.Values[6].Item2;
        }
    }
}