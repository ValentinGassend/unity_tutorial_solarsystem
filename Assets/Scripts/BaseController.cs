using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController<ControllerType> : MonoBehaviour
where ControllerType : Object
{

    public static ControllerType instance = null;

    public static ControllerType Instance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<ControllerType>();
        }
        return instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
