﻿using System.Collections.Generic;
using System.Reflection;

namespace ScriptCs.Contracts
{
    public interface IScriptExecutor
    {
        void ImportNamespaces(params string[] namespaces);
        void RemoveNamespaces(params string[] namespaces);

        void AddReferences(params Assembly[] references);
        void RemoveReferences(params Assembly[] references);

        void AddReferences(params string[] references);
        void RemoveReferences(params string[] references);

        IScriptHost Initialize(IEnumerable<string> paths, IEnumerable<IScriptPack> scriptPacks, params string[] scriptArgs);

        void Reset();

        void Terminate();

        ScriptResult Execute(string script, params string[] scriptArgs);

        ScriptResult ExecuteScript(string script, params string[] scriptArgs);

        IScriptHost ScriptHost { get; }
    }
}
