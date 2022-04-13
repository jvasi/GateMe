using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//class that handles all navigation
public class NavigationController : MonoBehaviour
{
    public GameObject trigger; // trigger to spawn and despawn AR arrows
    public Transform[] destinations; // list of destination positions
    public GameObject person; // person indicator
    private NavMeshPath path; // current calculated path
    public LineRenderer line; // linerenderer to display path
    public Transform target; // current chosen destination
    private bool destinationSet; // bool to say if a destination is set

    //create initial path, get linerenderer.
    void Start()
    {
        path = new NavMeshPath();
        //line = transform.GetComponent<LineRenderer>();
        destinationSet = false;
    }

    void Update()
    {
        //if a target is set, calculate and update path
        if (target != null)
        {
            NavMesh.CalculatePath(person.transform.position, target.position,
                          NavMesh.AllAreas, path);
            //Debug.Log("===== person.transform.position" + person.transform.position);
            //Debug.Log("===== target.position" + target.position);
            //Debug.Log("===== NavMesh.AllAreas" + NavMesh.AllAreas);
            //Debug.Log("===== path" + path);
            //lost path due to standing above obstacle (drift)
            if (path.corners.Length == 0)
            {
                Debug.Log("Try moving away for obstacles (optionally recalibrate)");
            }
            Debug.Log("========== Updatingg line");
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            line.enabled = true;
        }
    }

    //set current destination and create a trigger for showing AR arrows
    public void setDestination(int index)
    {
        target = destinations[index];
        GameObject.Instantiate(trigger, person.transform.position,
             person.transform.rotation);
    }
}