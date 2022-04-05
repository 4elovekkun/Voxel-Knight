using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAreaController : MonoBehaviour
{
    public RectTransform rectTopBackground;
    public RectTransform rectBottomBackground;
    public RectTransform rectPictureLocation;
    public RectTransform rectBackgroundLocation;

    private void Awake()
    {
        UpdateSafeArea();
    }

    private void UpdateSafeArea()
    {
        var safeArea = Screen.safeArea;
        var myRectTransform = GetComponent<RectTransform>();

        var anchorMin = safeArea.position;
        var anchorMax = safeArea.position + safeArea.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        myRectTransform.anchorMin = anchorMin;
        myRectTransform.anchorMax = anchorMax;

        rectTopBackground.anchorMin = new Vector2(anchorMin.x, anchorMax.y);
        rectTopBackground.anchorMax = new Vector2(1f ,1f);

        rectBottomBackground.anchorMax = new Vector2(1f, anchorMin.y);
        rectBottomBackground.anchorMin = new Vector2(0f, 0f);

        //rectPictureLocation.anchorMax = ;
    }
}
