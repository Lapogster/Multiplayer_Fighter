using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using System.Threading.Tasks;

public class SignupLogic : MonoBehaviour
{
    private string inputNewUsername;
    private string inputNewPassword;

    public void readUsername(string username)
    {
        inputNewUsername = username;
        Debug.Log(inputNewUsername);
    }

    public void readPassword(string password)
    {
        inputNewPassword = password;
        //Debug.Log(inputNewPassword);
    }
}
