using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ButtonAnimation))]

public class ButtonAnimationEditor : Editor
{

   public override void OnInspectorGUI()
    {
        ButtonAnimation myTarget = (ButtonAnimation)target;

        myTarget.prefabToInstantiate = (GameObject)EditorGUILayout.ObjectField("Prefab to Instantiate", myTarget.prefabToInstantiate, typeof(GameObject), true);

        if (GUILayout.Button("Create Object"))
        {
            myTarget.CreateObject();
        }

        DrawDefaultInspector(); // Adiciona a visualização padrão do Inspector
    }
    

    
}
