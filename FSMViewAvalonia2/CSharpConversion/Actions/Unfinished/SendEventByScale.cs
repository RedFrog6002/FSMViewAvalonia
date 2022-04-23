using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SendEventByScale
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmEventTarget eventTarget = action.Values[1].Item2 as FsmEventTarget;
            bool xScale = (bool)action.Values[2].Item2;
            string positiveEvent = action.Values[3].Item2 as string;
            string negativeEvent = action.Values[4].Item2 as string;
            Space space = action.Values[5].Item2 as Space;
        }
    }
}