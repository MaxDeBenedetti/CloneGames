using UnityEngine;
using UnityEditor;
using System.Collections;

public class Group 
{
        [MenuItem("Utility/Group Selection %G")]
        static void GroupSelectedObjects()
        {
                GameObject[] selected = Selection.gameObjects;
                
                if(selected.Length > 0)
                {
                        GameObject parent = new GameObject("group");
                        
                        foreach(GameObject g in selected)
                        {
                                g.transform.parent = parent.transform;
                        }
                }
        }
}