using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Location : MonoBehaviour
{
    public string name;
    public TMP_Text locationText;
    public TMP_Text location_name;
    public string difficulty;
    public Image imageLocation;
    public GameObject middleUI;
    private RectTransform rt;
    public GameObject locationUI;
    public string[] enemies;
    
    public void Awake()
    {
        name = gameObject.name;
        locationText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        locationText.text = name.ToUpper();
        imageLocation = gameObject.GetComponent<Image>();
        switch (difficulty)
        {
            case "peaceful":
                imageLocation.sprite = Resources.Load<Sprite>("Sprites/peaceful_location");
                break;
            case "simple":
                imageLocation.sprite = Resources.Load<Sprite>("Sprites/simple_location");
                break;
            case "middle":
                imageLocation.sprite = Resources.Load<Sprite>("Sprites/middle_location");
                break;
            case "hard":
                imageLocation.sprite = Resources.Load<Sprite>("Sprites/hard_location");
                break;
            default:
                Debug.Log("Error: strange difficulty");
                break;
        }
    }

    public void OnButtonPress()
    {
        Debug.Log("Button Press");
        locationUI.SetActive(true);
        location_name.text = gameObject.name;
        middleUI.gameObject.SetActive(false);

        /*if (difficulty != "peaceful")
        {
            Debug.Log("Not Peaceful");
            locationUI.SetActive(true);
        }
        else
        {
            Debug.Log("Peaceful");
            var loc = GameObject.Find("Peaceful Loc UI");
            locationUI.SetActive(true);
        }*/
    }
}