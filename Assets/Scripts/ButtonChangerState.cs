using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonChangerState : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{  
    [SerializeField] private Sprite _normalTexture;
    [SerializeField] private Sprite _hoverTexture;
    [SerializeField] private Sprite _pressedTexture;
    [SerializeField] private Sprite _disbleTexture;

    private Image _image;
    private Button _button;

    private void Start()
    {
        _image = GetComponent<Image>();
        _button = GetComponent<Button>();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        _image.sprite = _hoverTexture;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.sprite = _normalTexture;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _image.sprite = _pressedTexture;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _image.sprite = _hoverTexture;
    }
}
