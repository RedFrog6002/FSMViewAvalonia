using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Wait
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat time = action.Values[0].Item2 as FsmFloat;
            string finishedEvent = action.Values[1].Item2 as string;
            bool realTime = (bool)action.Values[2].Item2;
            string toState = GetToState(data.state.transitions, finishedEvent);
            FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
            if (realTime)
                state.AddEndCode("yield return new WaitForSecondsRealTime(" + time.value + ");");
            else
                state.AddEndCode("yield return new WaitForSeconds(" + time.value + ");");
            state.AddEndCodeReturn("");
            state.AddEndCode(() => toStateBuilder.IsEnumerator ? ("StartCoroutine(" + toState + "());") : (toState + "();"));
            state.SetIsEnumerator();
            state.SetAbnormalFinish();
        }
    }
}
