using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using System.Threading.Tasks;

public class LoginLogic : MonoBehaviour
{
    private string inputUsername;
    private string inputPassword;

    public void readUsername(string username)
    {
        inputUsername = username;
        Debug.Log(inputUsername);
    }

    public void readPassword(string password)
    {
        inputPassword = password;
        //Debug.Log(inputPassword);
    }

    public void submitPressed()
    {
        if (inputUsername == null)
        {
            Debug.LogWarning("Error: Missing or Invalid Username");
        }
        else if (inputPassword == null)
        {
            Debug.LogWarning("Error: Password Missing or Invalid");
        }
        else
        {
            Debug.Log("Attempting Sign In");
            SignInWithUsernamePasswordAsync(inputUsername, inputPassword);
        }
    }

    public async Task SignInWithUsernamePasswordAsync(string username, string password)
    {
        Debug.Log("Sign In Requested");
        try
        {
            Debug.Log("Contacting Services...");
            await AuthenticationService.Instance.SignInWithUsernamePasswordAsync(username, password);
            Debug.Log("Sign In is successful.");
        }
        catch (AuthenticationException ex)
        {
            Debug.Log("Sign In Failed");
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            Debug.Log("Sign In Failed");
            Debug.LogException(ex);
        }
    }
}
