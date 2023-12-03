using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginMenuNav : MonoBehaviour
{
    public GameObject login;
    public GameObject signup;

    public void loginMenu()
    {
        signup.SetActive(false);
        login.SetActive(true);
    }

    public void signUpMenu()
    {
        signup.SetActive(true);
        login.SetActive(false);
    }
}
