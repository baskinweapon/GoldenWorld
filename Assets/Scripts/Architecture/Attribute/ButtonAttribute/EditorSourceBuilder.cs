using System.Text;

public class EditorSourceBuilder {
    private readonly StringBuilder sb = new StringBuilder();

    public EditorSourceBuilder() {
        sb.AppendLine("using System;");
        sb.AppendLine("using UnityEngine;");
        sb.AppendLine("using UnityEditor;");
        sb.AppendLine("using System.Reflection;");
    }
    
    public string Build() => sb.ToString();

    public void AddEditor(ComponentInfo componentInfo, out string editorName) {
        editorName = $"{componentInfo.Type.Name.Replace('+', '_')}Editor";
        sb.AppendLine($"public class {editorName} : Editor {{");
        sb.AppendLine("public override void OnInspectorGUI() {");
        GenerateOnInspectorGUI(sb, componentInfo);
        sb.AppendLine("}}");
    }
    
    private static void GenerateOnInspectorGUI(StringBuilder sb, ComponentInfo componentInfo) {
        sb.AppendLine("DrawDefaultInspector();");
        foreach (var buttonMethod in componentInfo.ButtonMethods) {
            GenerateButtonMethod(sb, buttonMethod);
        }
    }

    private static void GenerateButtonMethod(StringBuilder sb, ButtonMethodInfo buttonMethodInfo) {
        sb.AppendLine(@$"if (GUILayout.Button(""{buttonMethodInfo.methodInfo.Name}""{{
        var method = typeof({buttonMethodInfo.methodInfo.DeclaringType.FullName}).GetMethod(""{buttonMethodInfo.methodInfo.Name}"", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        method.Invoke(target, Array.Empty<object>());    
}}
");
    }
}

