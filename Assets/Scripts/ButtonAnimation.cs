using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Necessário para IPointerEnterHandler e IPointerExitHandler
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button button;           
    public Vector3 scaleIncrease = new Vector3(1.2f, 1.2f, 1f);  
    public float duration = 0.2f; 
    public GameObject image;
    public ParticleSystem explosionEffect;
    public GameObject prefabToInstantiate; 
    


    
    

    private List<string> string_test = new List<string> 
    { 
        "Foi sorteado o primeiro da lista.", 
        "O segundo foi sorteado.", 
        "A string escolhida foi a terceira."
    };

    private Vector3 originalScale; 

    private void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();  
        }

        originalScale = button.transform.localScale;
    }


    public void TriggerExplosion()
    {
        if (explosionEffect != null)
        {
            explosionEffect.Play(); 
        }

    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        
        button.transform.Scale(scaleIncrease,duration);
        if(image != null)image.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       
        button.transform.Scale(originalScale,duration);
        if(image != null)image.SetActive(false);
    }

    public void CreateObject(){
        if (prefabToInstantiate != null) // Verifica se o prefab está atribuído
        {
            var a = Instantiate(prefabToInstantiate); 
            a.transform.position = Vector3.zero;

            StringFunction();

        }
        else
        {
            Debug.LogWarning("Prefab não atribuído.");
            StringFunction();
        }
    }


    private void StringFunction(){
        string stringDebug = string_test.GetRandomList();
         Debug.Log(stringDebug);
    }

    


}