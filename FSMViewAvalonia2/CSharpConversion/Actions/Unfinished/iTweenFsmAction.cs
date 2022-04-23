using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenFsmAction
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string startEvent = action.Values[0].Item2 as string;
            string finishEvent = action.Values[1].Item2 as string;
            FsmBool realTime = action.Values[2].Item2 as FsmBool;
            FsmBool stopOnExit = action.Values[3].Item2 as FsmBool;
            FsmBool loopDontFinish = action.Values[4].Item2 as FsmBool;
        }
    }
}