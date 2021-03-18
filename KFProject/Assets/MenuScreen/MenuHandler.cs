using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{


    public GameObject MenuObject;
    public GameObject GameObject;

    // Start is called before the first frame update
    void Start()
    {
        doSetScreen("menu");
    }

    public void doSetScreen(string screen)
    {
        MenuObject.SetActive(screen == "menu");
        GameObject.SetActive(screen == "game");
    }
}
