using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FindChild
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            state.AddMiddleCode((action.Values[2].Item2 as FsmGameObject).name + " = " + GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".Find(" + action.Values[1].Item2 + ").gameObject;");
        }
    }
}
