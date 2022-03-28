using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScripts : MonoBehaviour
{
    public GameObject SubMenuGameObject;
    
    public void ToggleSubMenu()
    {
        if (SubMenuGameObject.activeSelf) SubMenuGameObject.SetActive(false); 
        else SubMenuGameObject.SetActive(true);
    }
}
