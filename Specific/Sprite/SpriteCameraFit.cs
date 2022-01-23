using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCameraFit : MonoBehaviour
{
    private SpriteRenderer _mySpriteRenderer;

    private void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();

        if(_mySpriteRenderer != null)
            ResizeSpriteToScreen();
    }

    private void ResizeSpriteToScreen() {
     
        transform.localScale = new Vector3(1f,1f,1f);
        
        float width = _mySpriteRenderer.sprite.bounds.size.x;
        float height = _mySpriteRenderer.sprite.bounds.size.y;
        
        float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / width, worldScreenHeight / height, 1);
    }
}
