using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("button pressed "+vb.VirtualButtonName);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("button released " + vb.VirtualButtonName);
    }

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
