using UnityEngine;
using UnityEngine.AI;

public class Sample : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        agent.SetDestination(target.position);
    }

    void Update()
    {
        var path = new NavMeshPath();
        var hasPath = agent.CalculatePath(target.position, path);
        print("CalculatePath return: " + hasPath);
        print("path.status: " + path.status);
        print("agent.pathStatus: " + agent.pathStatus);
    }
}