using System;
using System.Collections.Generic;
using System.Text;

namespace FSMViewAvalonia2.CSharpConversion
{
    public class FsmClassBuilder
    {
        private const string ClassMemberSpace = "    ";

        private List<(string, string)> Fields = new List<(string, string)>();
        private List<FsmStateBuilder> States = new List<FsmStateBuilder>();
        private string GOName;
        private string FSMName;

        public void AddField(string Type, string Name) => Fields.Add((Type, Name));

        public FsmStateBuilder CreateState(string Name)
        {
            FsmStateBuilder state = new FsmStateBuilder(this, Name);
            States.Add(state);
            return state;
        }

        public FsmClassBuilder(string GOName, string FSMName)
        {
            this.GOName = GOName;
            this.FSMName = FSMName;
        }

        public override string ToString()
        {
            string ret = "public class " + GOName + "_" + FSMName + "\n{\n";
            int length = Fields.Count;
            for (int i = 0; i < length; i++)
            {
                (string Type, string Name) = Fields[i];
                ret += ClassMemberSpace + "public " + Type + " " + Name + "\n";
            }
            length = States.Count;
            for (int i = 0; i < length; i++)
            {
                ret += ClassMemberSpace + "\n" + States[i].ToString();
            }
            ret += "}";
            return ret;
        }
    }

    public class FsmStateBuilder
    {
        private const string ClassMemberSpace = "    ";
        private const string MethodSpace = "        ";

        public FsmClassBuilder classBuilder;

        private List<string> BeginningCode = new List<string>();
        private List<string> MiddleCode = new List<string>();
        private List<string> EndCode = new List<string>();
        private string Name;
        private bool IsEnumerator = false;

        public void AddBeginningCode(string line) => BeginningCode.Add(line);
        public void AddMiddleCode(string line) => MiddleCode.Add(line);
        private void AddEndCode(string line) => EndCode.Add(line);
        private void SetIsEnumerator() => IsEnumerator = true;

        public FsmStateBuilder(FsmClassBuilder classBuilder, string Name)
        {
            this.classBuilder = classBuilder;
            this.Name = Name;
        }

        private void WriteAllCode(ref string ret, List<string> list)
        {
            int length = list.Count;
            for (int i = 0; i < length; i++)
            {
                ret += MethodSpace + list[i] + "\n";
            }
        }

        public override string ToString()
        {
            string ret = ClassMemberSpace + (IsEnumerator ? "public IEnumerator " : "public void ") + Name + "()\n" + ClassMemberSpace + "{\n";
            if (BeginningCode.Count > 0)
            {
                WriteAllCode(ref ret, BeginningCode);
                if (MiddleCode.Count > 0)
                    ret += MethodSpace + "\n";
            }
            if (MiddleCode.Count > 0)
            {
                WriteAllCode(ref ret, MiddleCode);
                if (EndCode.Count > 0)
                    ret += MethodSpace + "\n";
            }
            if (EndCode.Count > 0)
            {
                WriteAllCode(ref ret, EndCode);
            }
            ret += ClassMemberSpace + "}\n";
            return ret;
        }
    }
}
