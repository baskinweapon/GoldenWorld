using System;
using UnityEngine;



[Serializable]
public struct DiggerMaterial {
    public string name;
    [TextArea(3, 10)]
    public string description;
    //public Element element;
    public Sprite icon;
    
} 

[CreateAssetMenu(fileName = "DiggerMaterials", menuName = "UI/DiggerMaterials", order = 1)]
public class DiggerMaterials : ScriptableObject {
    public DiggerMaterial[] materials;
}

