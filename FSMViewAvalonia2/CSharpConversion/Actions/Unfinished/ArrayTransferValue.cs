using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayTransferValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray arraySource = action.Values[0].Item2 as FsmArray;
            FsmArray arrayTarget = action.Values[1].Item2 as FsmArray;
            FsmInt indexToTransfer = action.Values[2].Item2 as FsmInt;
            FsmEnum copyType = action.Values[3].Item2 as FsmEnum;
            FsmEnum pasteType = action.Values[4].Item2 as FsmEnum;
            string indexOutOfRange = action.Values[5].Item2 as string;
        }
    }
}