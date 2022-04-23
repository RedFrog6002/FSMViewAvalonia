using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GhostMovement
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat xPosMin = action.Values[1].Item2 as FsmFloat;
            FsmFloat xPosMax = action.Values[2].Item2 as FsmFloat;
            FsmFloat accel_x = action.Values[3].Item2 as FsmFloat;
            FsmFloat speedMax_x = action.Values[4].Item2 as FsmFloat;
            FsmFloat yPosMin = action.Values[5].Item2 as FsmFloat;
            FsmFloat yPosMax = action.Values[6].Item2 as FsmFloat;
            FsmFloat accel_y = action.Values[7].Item2 as FsmFloat;
            FsmFloat speedMax_y = action.Values[8].Item2 as FsmFloat;
            FsmInt direction_x = action.Values[9].Item2 as FsmInt;
            FsmInt direction_y = action.Values[10].Item2 as FsmInt;
        }
    }
}