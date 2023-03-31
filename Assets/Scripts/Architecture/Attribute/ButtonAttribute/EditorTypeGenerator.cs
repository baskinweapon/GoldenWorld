using System.Collections.Generic;
using System;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Text;

public static class EditorTypeGenerator {
    public static IEnumerable<(Type inspectedType, Type EditorType)> GenerateForComponents(
        params ComponentInfo[] components) {

        var editorNames = new List<string>();
        
        var sourceBuild = new EditorSourceBuilder();
        foreach (var componentInfo in components) {
            sourceBuild.AddEditor(componentInfo, out var editorName);
            editorNames.Add(editorName);
        }

        var source = sourceBuild.Build();
        
        var assembly = CompileAssemblyFromSource(source);
    }

    private static Assembly CompileAssemblyFromSource(string sourceCode) {
        var csProvider = new CSharpCodeProvider();
        var compParams = new CompileParameters {
            GenerateExecutable = false,
            GenerateInMemory = true,
        };
        CompilerResults results = csProvider.CompileAssemblyFromSource(compParams, sourceCode);
        return results.CompiledAssembly;
    }
}
