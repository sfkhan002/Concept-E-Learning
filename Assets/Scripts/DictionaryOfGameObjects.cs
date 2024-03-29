using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryOfGameObjects : MonoBehaviour
{
    // Start is called before the first frame update
    private Dictionary<string, GameObject> welcomeObjects = new Dictionary<string, GameObject>();
    void Start()
    {
        List<GameObject> listfromUIScript = UIScript.Instance.welcomeCanvasObjects;
    }

    private void storeWelcomeListDic()
    {

    }
}
