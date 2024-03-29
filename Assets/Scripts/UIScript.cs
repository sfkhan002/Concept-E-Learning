using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private static UIScript instance;

    public static UIScript Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<UIScript>();
                if(instance == null)
                {
                    GameObject singleton = new GameObject(typeof(UIScript).Name);
                    instance = singleton.AddComponent<UIScript>();
                }
            }
            return instance;
        }
    }
    public List<GameObject> welcomeCanvasObjects;
}
