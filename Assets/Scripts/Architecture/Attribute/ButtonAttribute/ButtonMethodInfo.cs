using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public struct ButtonMethodInfo {
    public readonly MethodInfo methodInfo;
    
    public ButtonMethodInfo(MethodInfo methodInfo) {
        this.methodInfo = methodInfo;
    }
}

public readonly struct ComponentInfo {
    public readonly Type Type;
    public readonly ButtonMethodInfo[] ButtonMethods;
    
    public ComponentInfo(Type type, ButtonMethodInfo[] buttonMethods) {
        Type = type;
        ButtonMethods = buttonMethods;
    }
}

public static class ComponentsGatherer {
   public static IEnumerable<ComponentInfo> Gather() {
       var buttonMethods = new List<ButtonMethodInfo>();
       foreach (var type in TypeCache.GetTypesDerivedFrom<MonoBehaviour>()) {
           if (type.IsAbstract || type.IsGenericTypeDefinition || type.IsGenericType) continue;

           foreach ( var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)) {
               if (method.GetCustomAttributes<ButtonAttribute>() == null) continue;

               if (method.GetParameters().Length > 0) {
                   Debug.LogError($"Method {method.Name} in {type.Name} has parameters. Button methods should not have parameters.");
                   continue;
               }
               
               buttonMethods.Add(new ButtonMethodInfo(method));
           }
           
           if (buttonMethods.Count <= 0) continue;
           
           var componentInfo = new ComponentInfo(type, buttonMethods.ToArray());
           yield return componentInfo;
           
           buttonMethods.Clear();
       }
   }
}
