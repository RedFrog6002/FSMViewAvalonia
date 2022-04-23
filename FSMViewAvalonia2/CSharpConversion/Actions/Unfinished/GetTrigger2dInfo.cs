using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetTrigger2dInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObjectHit = action.Values[0].Item2 as FsmGameObject;
            FsmInt shapeCount = action.Values[1].Item2 as FsmInt;
            FsmString physics2dMaterialName = action.Values[2].Item2 as FsmString;
        }
    }
}