using UnityEngine.AI;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent navMeshAgent;

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if (Physics.Raycast(ray, out raycastHit))
        {
            navMeshAgent.SetDestination(raycastHit.point);
        }

    }
}
