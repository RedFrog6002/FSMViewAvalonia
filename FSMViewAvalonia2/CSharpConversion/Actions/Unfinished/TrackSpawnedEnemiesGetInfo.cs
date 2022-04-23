using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TrackSpawnedEnemiesGetInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault Target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt TotalTracked = action.Values[1].Item2 as FsmInt;
            FsmInt TotalAlive = action.Values[2].Item2 as FsmInt;
        }
    }
}