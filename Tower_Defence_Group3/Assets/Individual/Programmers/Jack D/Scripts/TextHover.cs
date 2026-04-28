using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI text;

    [SerializeField] private Color normalColor = new Color(0.2f, 0.2f, 0.2f);
    [SerializeField] private Color hoverColor = Color.yellow;

    [SerializeField] private float hoverScale = 1.1f;

    private Vector3 originalScale;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        originalScale = transform.localScale;
        text.color = normalColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = hoverColor;
        transform.localScale = originalScale * hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = normalColor;
        transform.localScale = originalScale;
    }
}