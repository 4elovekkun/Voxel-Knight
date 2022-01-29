using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterController : MonoBehaviour
{
    private string location;
    [SerializeField]
    private int money;
    public TMP_Text moneyText;
    private int hp;
    public TMP_Text hpText;
    private int maxHp;
    private int lvl;
    public TMP_Text lvlText;
    private int xp;
    public Transform cameraTrans;
    private float camY;
    private float camX;
    private GameObject loc;

    public void Awake()
    {
        if (PlayerPrefs.HasKey("location"))
        {
            location = PlayerPrefs.GetString("location");
            money = PlayerPrefs.GetInt("money");
            hp = PlayerPrefs.GetInt("hp");
            maxHp = PlayerPrefs.GetInt("maxHp");
            lvl = PlayerPrefs.GetInt("lvl");
            xp = PlayerPrefs.GetInt("xp");
        }
        else
        {
            location = "Peninsuela";
            money = 10;
            hp = 200;
            maxHp = 200;
            lvl = 1;
            xp = 0;
            PlayerPrefs.SetString("location", location);
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("hp", hp);
            PlayerPrefs.SetInt("lvl", lvl);
            PlayerPrefs.SetInt("xp", xp);
        }
        moneyText.text = money.ToString();
        hpText.text = hp.ToString() + "/" + maxHp.ToString();
        lvlText.text = lvl.ToString();
        loc = GameObject.Find(PlayerPrefs.GetString("location"));
        cameraTrans.position = new Vector3(loc.transform.position.x, loc.transform.position.y, cameraTrans.position.z);
    }

    public void OnApplicationPause(bool pause)
    {
        PlayerPrefs.SetString("location", location);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("hp", hp);
        PlayerPrefs.SetInt("lvl", lvl);
        PlayerPrefs.SetInt("xp", xp);
    }
}
