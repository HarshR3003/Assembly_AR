using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class GameControl : MonoBehaviour
{
    public GameObject obj;

    ARRaycastManager raycastManager;
    GameObject[] objs;

    private void Awake()
    {
        objs = obj.GetComponentsInChildren<GameObject>();
        Debug.Log(objs.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
