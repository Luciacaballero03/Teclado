using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public Key[] keys; // los corchetes indican a un array; por convención se expresan en plural 

    // Start is called before the first frame update
    void Start()
    {
        keys = GameObject.FindObjectsOfType<Key>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
