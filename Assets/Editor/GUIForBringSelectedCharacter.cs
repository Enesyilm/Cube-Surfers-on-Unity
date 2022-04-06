using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

[ExecuteInEditMode]
[CustomEditor(typeof(BringSelectedCharacter))]
public class GUIForBringSelectedCharacter : Editor
{
    static void ClearLog()
     {
         Assembly assembly = Assembly.GetAssembly(typeof(SceneView));
         Type logEntries = assembly.GetType("UnityEditorInternal.LogEntries");
         logEntries.GetMethod("Clear").Invoke (new object (), null);
 
         int count = (int)logEntries.GetMethod("GetCount").Invoke(new object (), null);
 
         if (count > 0)
             throw new Exception("Cannot build because you have compile errors!");
     }

    public override void OnInspectorGUI()
    {
        ClearLog();
        base.OnInspectorGUI();
        BringSelectedCharacter bringSelectedCharacter = (BringSelectedCharacter)target;
        if (bringSelectedCharacter.setScaleBool)
        {
            // bringSelectedCharacter.setScaleBool=bringSelectedCharacter.setScaleBool?false:true;
            bringSelectedCharacter.scaleX = EditorGUILayout.FloatField("ScaleX", bringSelectedCharacter.scaleX);
            bringSelectedCharacter.scaleY = EditorGUILayout.FloatField("ScaleY", bringSelectedCharacter.scaleY);
            bringSelectedCharacter.scaleZ = EditorGUILayout.FloatField("ScaleZ", bringSelectedCharacter.scaleZ);

        }
    }
    private void OnGUI() {
        
    }
}
