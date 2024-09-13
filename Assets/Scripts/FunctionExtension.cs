using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public static class FunctionExtension
{

    [UnityEditor.MenuItem("Ebac/Test")]

    public static void Test(){
        GameObject gameFds = new ();
       
    }
    
    public static void Scale(this Transform transform ,Vector3 scale , float duration){

    transform.DOScale(scale ,duration).SetEase(Ease.OutBack);
    }

    public static T GetRandomList<T>(this List<T> list){
        
        
        if (list.Count == 0)
        {
            throw new System.InvalidOperationException("Cannot get a random item from an empty list.");
        }

        int index = Random.Range(0, list.Count);
        return list[index];
        
        
        
    }

}
