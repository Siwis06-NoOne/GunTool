using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(SpawnWeapon))]
public class SpawnWeaponEdditor : Editor
{
    SerializedProperty repeatProperty;

    private void OnEnable()
    {
        repeatProperty = serializedObject.FindProperty("repeat");
    }

    public override void OnInspectorGUI()
    {
        SpawnWeapon myTarget = (SpawnWeapon)target;

        if (GUILayout.Button("Spawn")) 
        {
            myTarget.ReadFile();
        }

        base.OnInspectorGUI();
    }
}
