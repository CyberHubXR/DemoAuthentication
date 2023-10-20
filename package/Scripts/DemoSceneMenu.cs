using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Foundry;
using Foundry.Networking;

public class DemoSceneMenu : MonoBehaviour
{
    public TMPro.TMP_Dropdown networkMode;
    public TMPro.TMP_InputField roomName;
    public void StartSession()
    {
        NetworkManager.instance.StartSession((networkMode.value == 0) ? Foundry.Networking.SessionType.Host : Foundry.Networking.SessionType.Client);
        Destroy(gameObject);
    }
}
