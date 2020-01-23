using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRaycast : MonoBehaviour
{

    public Camera camera;
    private bool onClick;
    public GameObject center;
    public GameObject cylinder;
    public float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        this.onClick = false;   
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonUp(0))
        {
            onClick = false;
        }

        if (Input.GetMouseButtonDown(0) && !onClick)
        {
            onClick = true;
            RaycastHit[] hits;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            hits = Physics.RaycastAll(ray);
            Debug.Log("Start Raycast");
            if (hits.Length >0)
            {
                for (int i = 0; i < hits.Length; i++)
                {

                    GameObject hit = hits[i].transform.gameObject;
                    if (hit.transform.tag.Equals("vuMark")){
                        Debug.Log("Raycast "+ hit.transform.name);
                        GameObject clone = GameObject.Instantiate(cylinder);
                        clone.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y,0);
                        x = hit.transform.position.x;
                        y = hit.transform.position.y;
                        z = hit.transform.position.z;
                        //clone.transform.localPosition = new Vector3(0, 0, 0);
                        clone.transform.tag = "Untagged";
                        clone.transform.name = ""+Random.Range(0f, 9f);
                    }

                }
            }
            this.onClick = false;
        }

    }
}
