using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("Changed during gameplay")]
    public string role;

    [SerializeField]
    private int currentScreen = 0;

    [Header("Changed before start")]
    public GameObject[] screens;

    [SerializeField]
    private TextMeshProUGUI roleShower;
    [SerializeField]
    private TextMeshProUGUI roleShower2;

    public static Gamemanager gm {  get; private set; }


    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
        else
        {
            Console.WriteLine("Gamemanager is already present, new one destroyed");
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Setting all screens to inactive except current screen
        foreach(GameObject screen in screens)
        {
            screen.SetActive(false);
        }
        screens[currentScreen].SetActive(true);
    }

    public void BecomeRole(string roleName)
    {
        role = roleName;
        roleShower.text = "Role: " + role;

        roleShower2.text = "Code: " + role;
    }

    public void ChangeScene(int sceneNr)
    {
        screens[currentScreen].SetActive(false);

        screens[sceneNr].SetActive(true);
        currentScreen = sceneNr;
    }


}
