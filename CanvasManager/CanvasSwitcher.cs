using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CanvasSwitcher : MonoBehaviour
{
    public CanvasType desiredCanvas;

    private Button menuButton;

    private void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        CanvasManager.Instance.SwitchCanvas(desiredCanvas);
    }
}
