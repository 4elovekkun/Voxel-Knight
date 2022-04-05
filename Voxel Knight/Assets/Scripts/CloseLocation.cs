using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLocation : MonoBehaviour
{
    public Location location;
    public void OnPressButton()
    {
        Debug.Log("Button Press");
        location.locationUI.SetActive(false);
        location.middleUI.gameObject.SetActive(true);
    }
}
