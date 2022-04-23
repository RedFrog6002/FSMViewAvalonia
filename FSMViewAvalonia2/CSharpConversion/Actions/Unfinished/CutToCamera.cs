using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CutToCamera
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            Camera camera = action.Values[0].Item2 as Camera;
            bool makeMainCamera = (bool)action.Values[1].Item2;
            bool cutBackOnExit = (bool)action.Values[2].Item2;
        }
    }
}