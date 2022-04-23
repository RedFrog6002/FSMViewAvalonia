using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TakeDamage
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject Target = action.Values[0].Item2 as FsmGameObject;
            FsmInt AttackType = action.Values[1].Item2 as FsmInt;
            FsmBool CircleDirection = action.Values[2].Item2 as FsmBool;
            FsmInt DamageDealt = action.Values[3].Item2 as FsmInt;
            FsmFloat Direction = action.Values[4].Item2 as FsmFloat;
            FsmBool IgnoreInvulnerable = action.Values[5].Item2 as FsmBool;
            FsmFloat MagnitudeMultiplier = action.Values[6].Item2 as FsmFloat;
            FsmFloat MoveAngle = action.Values[7].Item2 as FsmFloat;
            FsmBool MoveDirection = action.Values[8].Item2 as FsmBool;
            FsmFloat Multiplier = action.Values[9].Item2 as FsmFloat;
            FsmInt SpecialType = action.Values[10].Item2 as FsmInt;
        }
    }
}