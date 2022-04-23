using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FindArrayList
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString ArrayListReference = action.Values[0].Item2 as FsmString;
            FsmGameObject store = action.Values[1].Item2 as FsmGameObject;
            string foundEvent = action.Values[2].Item2 as string;
            string notFoundEvent = action.Values[3].Item2 as string;
        }
    }
}