using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum CanvasType
{
    MainMenu,
    GameMenu,
    EndMenu
}

public class CanvasManager : MonoBehaviour
{

    private static CanvasManager _instance;

    public static CanvasManager Instance
    {
        get
        {
            return _instance;
        }
    }

    List<CanvasController> _canvasControllers;

    CanvasController _lastActiveCanvas;

    private void Awake()
    {
        if (_instance)
        {
            DestroyImmediate(gameObject);
            return;
        }

        _instance = this;

        DontDestroyOnLoad(gameObject);

        _canvasControllers = GetComponentsInChildren<CanvasController>().ToList();

        _canvasControllers.ForEach(x => x.gameObject.SetActive(false));

        SwitchCanvas(CanvasType.MainMenu);
        
    }


    public void SwitchCanvas(CanvasType type)
    {
        if(_lastActiveCanvas != null)
        {
            _lastActiveCanvas.gameObject.SetActive(false);
        }

        CanvasController desiredCanvas = _canvasControllers.Find(x => x.type == type);

        if(desiredCanvas != null)
        {
            desiredCanvas.gameObject.SetActive(true);
            _lastActiveCanvas = desiredCanvas;
        }
    }
}
