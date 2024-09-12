using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Necessário para IPointerEnterHandler e IPointerExitHandler
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button button;           // Referência ao botão
    public Vector3 scaleIncrease = new Vector3(1.2f, 1.2f, 1f);  // Escala aumentada
    public float duration = 0.2f;  // Duração da animação
    public GameObject image;
    public ParticleSystem explosionEffect;

    private Vector3 originalScale; // Escala original

    private void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();  // Obtém o botão se não for atribuído
        }

        originalScale = button.transform.localScale; // Armazena a escala original
    }


    public void TriggerExplosion()
    {
        if (explosionEffect != null)
        {
            explosionEffect.Play(); // Reproduz a animação de explosão
        }
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        // Anima a escala para aumentar quando o mouse entra
        button.transform.DOScale(scaleIncrease, duration).SetEase(Ease.OutBack);
        if(image != null)image.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Anima a escala para retornar ao normal quando o mouse sai
        button.transform.DOScale(originalScale, duration).SetEase(Ease.InBack);
        if(image != null)image.SetActive(false);
    }
}