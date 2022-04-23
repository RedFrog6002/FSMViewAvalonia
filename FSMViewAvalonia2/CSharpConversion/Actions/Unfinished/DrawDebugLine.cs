using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DrawDebugLine
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject fromObject = action.Values[0].Item2 as FsmGameObject;
            FsmVector3 fromPosition = action.Values[1].Item2 as FsmVector3;
            FsmGameObject toObject = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 toPosition = action.Values[3].Item2 as FsmVector3;
            FsmColor color = action.Values[4].Item2 as FsmColor;
        }
    }
}