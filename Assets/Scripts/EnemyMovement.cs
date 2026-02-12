using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public transform Player;
    private NavMeshAgent navMeshAgent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<navMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
