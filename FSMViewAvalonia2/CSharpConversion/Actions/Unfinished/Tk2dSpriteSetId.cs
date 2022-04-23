using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Tk2dSpriteSetId
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt spriteID = action.Values[1].Item2 as FsmInt;
            FsmString ORSpriteName = action.Values[2].Item2 as FsmString;
            FsmGameObject spriteCollection = action.Values[3].Item2 as FsmGameObject;
        }
    }
}