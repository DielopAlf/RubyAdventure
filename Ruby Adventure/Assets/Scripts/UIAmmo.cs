using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIAmmo : MonoBehaviour
{
    private Text ammoText;
    public int maxAmmo=10;
    public int ammoCount=10;

    void Start()
    {
        ammoText = GetComponent<Text>();
        SetMaxAmmo(maxAmmo);
        SetAmmo(ammoCount);
    }

    public void SetMaxAmmo(int amount)
    {
        maxAmmo = amount;
       // ammoText.text = "Ammo: " + ammoCount + " / " + maxAmmo;
    }

    public void SetAmmo(int amount)
    {
        ammoCount = amount;
        //ammoText.text = "Ammo: " + ammoCount + " / " + maxAmmo;
    }
}
