using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class NPCMovement : MonoBehaviour
{
    private NavMeshAgent nav;


    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        nav.SetDestination(GameObject.Find("Замок").transform.position);

    }
}
