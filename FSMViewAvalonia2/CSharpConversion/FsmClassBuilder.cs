﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FSMViewAvalonia2.CSharpConversion
{
    public class FsmClassBuilder
    {
        private const string ClassMemberSpace = "    ";
        private const string MethodSpace = "        ";

        private List<(string, string)> Fields = new List<(string, string)>();
        private List<FsmStateBuilder> States = new List<FsmStateBuilder>();
        private string GOName;
        private string FSMName;
        public bool RequireEndState { get; private set; } = false;
        public bool ContainsCoroutine { get; private set; } = false;

        public void SetRequireEndState() => RequireEndState = true;
        public void SetContainsCoroutine() => ContainsCoroutine = true;

        public void AddField(string Type, string Name) => Fields.Add((Type, Name));

        public FsmStateBuilder CreateState(string Name, string finishedMethod)
        {
            FsmStateBuilder state = new FsmStateBuilder(this, Name, finishedMethod);
            States.Add(state);
            return state;
        }

        public FsmStateBuilder GetState(int index) => States[index];
        public FsmStateBuilder GetState(string name) => States.First(s => s.Name == name);

        public FsmClassBuilder(string GOName, string FSMName)
        {
            this.GOName = GOName;
            this.FSMName = FSMName;
        }

        public override string ToString()
        {
            string ret = "public class " + GOName + "_" + FSMName + "\n{\n";
            if (RequireEndState)
            {
                ret += ClassMemberSpace + "private readonly Action EndState;\n";
                if (ContainsCoroutine)
                    ret += ClassMemberSpace + "private readonly Coroutine ThisRoutine;\n";
                ret += ClassMemberSpace + "\n";
            }
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
            if (RequireEndState)
                ret += ClassMemberSpace + "public void BeginState()\n" + ClassMemberSpace + "{\n" + MethodSpace
                    + "if (EndState != null)\n" + MethodSpace + "{\n" + MethodSpace + "    EndState();\n" + MethodSpace + "    EndState = null;\n" + MethodSpace + "}\n"
                    + MethodSpace + "if (LastRoutine != null)\n" + MethodSpace + "    StopCoroutine(LastRoutine);" + MethodSpace + "LastRoutine = ThisRoutine;"
                    + ClassMemberSpace + "}\n";
            ret += "}";
            return ret;
        }
    }

    public class FsmStateBuilder
    {
        private const string ClassMemberSpace = "    ";
        private const string MethodSpace = "        ";

        public FsmClassBuilder classBuilder;

        private List<Func<string>> BeginningCode = new List<Func<string>>();
        private List<Func<string>> MiddleCode = new List<Func<string>>();
        private List<Func<string>> EndCode = new List<Func<string>>();
        private List<Func<string>> ReturnCode = new List<Func<string>>();
        public readonly string Name;
        private readonly string finishedMethod;
        public readonly bool hasFinishMethod;
        public bool IsEnumerator { get; private set; } = false;
        public bool NormalFinish { get; private set; } = true;

        public void AddBeginningCode(string line) => BeginningCode.Add(() => line);
        public void AddBeginningCode(Func<string> line) => BeginningCode.Add(line);
        public void AddBeginningCodeReturn(string space) => BeginningCode.Add(() => GetReturnCode(ReturnCode, space));
        public void AddBeginningCodeAt0(string line) => BeginningCode.Insert(0, () => line);
        public void AddBeginningCodeAt0(Func<string> line) => BeginningCode.Insert(0, line);
        public void AddMiddleCode(string line) => MiddleCode.Add(() => line);
        public void AddMiddleCode(Func<string> line) => MiddleCode.Add(line);
        public void AddMiddleCodeReturn(string space) => MiddleCode.Add(() => GetReturnCode(ReturnCode, space));
        public void AddMiddleCodeAt0(string line) => MiddleCode.Insert(0, () => line);
        public void AddMiddleCodeAt0(Func<string> line) => MiddleCode.Insert(0, line);
        public void AddEndCode(string line) => EndCode.Add(() => line);
        public void AddEndCode(Func<string> line) => EndCode.Add(line);
        public void AddEndCodeReturn(string space) => EndCode.Add(() => GetReturnCode(ReturnCode, space));
        public void AddEndCodeAt0(string line) => EndCode.Insert(0, () => line);
        public void AddEndCodeAt0(Func<string> line) => EndCode.Insert(0, line);
        public void AddReturnCode(string line) => ReturnCode.Add(() => line);
        public void AddReturnCode(Func<string> line) => ReturnCode.Add(line);
        public void AddReturnCodeAt0(string line) => ReturnCode.Insert(0, () => line);
        public void AddReturnCodeAt0(Func<string> line) => ReturnCode.Insert(0, line);

        public void SetIsEnumerator()
        {
            IsEnumerator = true;
            classBuilder.SetContainsCoroutine();
        }
        public void SetAbnormalFinish()
        {
            NormalFinish = false;
            classBuilder.SetRequireEndState();
        }

        internal FsmStateBuilder(FsmClassBuilder classBuilder, string Name, string finishedMethod)
        {
            this.classBuilder = classBuilder;
            this.Name = Name;
            this.finishedMethod = finishedMethod;
            if (string.IsNullOrEmpty(finishedMethod))
            {
                this.hasFinishMethod = false;
                classBuilder.SetRequireEndState();
            }
            else
                this.hasFinishMethod = true;
        }

        private string GetReturnCode(List<Func<string>> list, string space = "")
        {
            string ret = "";
            if (hasFinishMethod && NormalFinish)
            {
                int length = list.Count;
                for (int i = 0; i < length; i++)
                {
                    if (i != 0)
                        ret += "\n" + MethodSpace + space;
                    ret += MethodSpace + space + list[i]();
                }
            }
            else
            {
                ret += "EndState();\n" + MethodSpace + space + "EndState = null;";
            }
            return ret;
        }

        private void WriteAllCode(ref string ret, List<Func<string>> list, string space = MethodSpace)
        {
            int length = list.Count;
            for (int i = 0; i < length; i++)
            {
                string add = list[i]();
                if (add != "")
                    ret += space + add + "\n";
            }
        }

        public string MakeCall(string space = "")
        {
            if (IsEnumerator)
            {
                if (classBuilder.RequireEndState)
                    return space + "ThisRoutine = StartCoroutine(" + Name + "());";
                return space + "StartCoroutine(" + Name + "());";
            }
            return space + Name + "();";
        }

        public string MakeReturn(string space = "")
        {
            if (IsEnumerator)
                return space + "yield break;";
            return space + "return;";
        }

        public override string ToString()
        {
            string ret = ClassMemberSpace + (IsEnumerator ? "public IEnumerator " : "public void ") + Name + "()\n" + ClassMemberSpace + "{\n";
            if (classBuilder.RequireEndState)
            {
                if (BeginningCode.Count > 0 || MiddleCode.Count > 0 || EndCode.Count > 0 || ReturnCode.Count > 0)
                    ret += MethodSpace + "\n";
            }
            if (BeginningCode.Count > 0)
            {
                WriteAllCode(ref ret, BeginningCode);
                if (MiddleCode.Count > 0 || EndCode.Count > 0 || ReturnCode.Count > 0)
                    ret += MethodSpace + "\n";
            }
            if (ReturnCode.Count > 0 && (!hasFinishMethod || !NormalFinish))
            {
                ret += MethodSpace + "EndState = () =>\n" + MethodSpace + "{\n";
                WriteAllCode(ref ret, ReturnCode, MethodSpace + "    ");
                ret += MethodSpace + "}\n";
                if (MiddleCode.Count > 0 || EndCode.Count > 0 || (ReturnCode.Count > 0 && hasFinishMethod && NormalFinish))
                    ret += MethodSpace + "\n";
            }
            if (MiddleCode.Count > 0)
            {
                WriteAllCode(ref ret, MiddleCode);
                if (EndCode.Count > 0 || (ReturnCode.Count > 0 && hasFinishMethod && NormalFinish))
                    ret += MethodSpace + "\n";
            }
            if (EndCode.Count > 0)
            {
                WriteAllCode(ref ret, EndCode);
                if (ReturnCode.Count > 0 && hasFinishMethod && NormalFinish)
                    ret += MethodSpace + "\n";
            }
            if (hasFinishMethod && NormalFinish)
            {
                if (ReturnCode.Count > 0)
                {
                    WriteAllCode(ref ret, ReturnCode);
                }
                ret += MethodSpace + classBuilder.GetState(finishedMethod).MakeCall();
            }
            ret += ClassMemberSpace + "}\n";
            return ret;
        }
    }
}
