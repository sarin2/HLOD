using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HLODVolume))]
public class HLODVolumeEditor : Editor
{
    private Bounds boundsProp;
    private HLODVolume hlodProp;

    private void OnEnable()
    {
        
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Generate HLOD"))
        {
            hlodProp = (HLODVolume)target;
            hlodProp.GenerateHLOD();
        }
    }
}
