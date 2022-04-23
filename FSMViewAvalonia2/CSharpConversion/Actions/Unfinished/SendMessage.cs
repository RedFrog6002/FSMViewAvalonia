using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SendMessage
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            MessageType delivery = action.Values[1].Item2 as MessageType;
            SendMessageOptions options = action.Values[2].Item2 as SendMessageOptions;
            FunctionCall functionCall = action.Values[3].Item2 as FunctionCall;
        }
    }
}