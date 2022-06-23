using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]

public class Inimigo : MonoBehaviour
{
    private GameObject player;
    private UnityEngine.AI.NavMeshAgent navMesh;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag ("Player");
        navMesh = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMesh.destination = player.transform.position;
    }
}
