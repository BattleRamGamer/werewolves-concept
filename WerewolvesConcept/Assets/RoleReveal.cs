using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoleReveal : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI roleText;
    [SerializeField]
    private TextMeshProUGUI boldRoleText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.gm.role == "Three")
        {
            roleText.text = "You are the murderer. Get your code scanned to kill others and win";
            boldRoleText.text = "Role: Murderer";
        }
        else
        {
            roleText.text = "You are innocent. If you scan the murderer's code, you lose";
            boldRoleText.text = "Role: Innocent";
        }
    }
}
