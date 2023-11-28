using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BurgerMenu : MonoBehaviour
{
    private GameObject BugerMenuUI;
    bool BurgerDown;

    private void Awake()
    {
        BugerMenuUI = GameObject.Find("BurgerMenuUI");
        BugerMenuUI.SetActive(false);
        BurgerDown = false;
    }

    public void BurgerMenuDown()
    {
        switch (BurgerDown)
        {
            case false:
                BugerMenuUI.SetActive(true);
                BurgerDown = true;
                break;

            case true:
                BugerMenuUI.SetActive(false);
                BurgerDown = false;
                break;
        }
    }
}
