using System;
using UnityEngine.AI;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    private PathTracing pathTracing;
    private NavMeshPath path;
    private Vector3 endPosition;
    // set movespeed this void subscribed on changeMoveSpeedEventHandler
    public void ChangeMoveSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
    
//start moving to endPosition
    public void MoveTo(Vector3 endPosition)
    {
        this.endPosition = endPosition;
        navMeshAgent.SetDestination(endPosition);
    }

    //update path visualization function
    private void Update()
    {
        if (Time.frameCount %5==0 && navMeshAgent.velocity.magnitude >0.1f)
        {
            SetPath();
        }
    }
    
//calculation path vectors and send to pathTracing component
    private void SetPath()
    {
        path = new NavMeshPath();
        navMeshAgent.CalculatePath(endPosition, path);
        pathTracing.RenderPath(path.corners);
    }
    
// subscribe to events and initialization
    private void OnEnable()
    {
        UIListener.ChangeMoveSpeedEventHandler += ChangeMoveSpeed;
        pathTracing = FindObjectOfType<PathTracing>();
        TryGetComponent(out NavMeshAgent meshAgent);
        navMeshAgent = meshAgent;

    }
    
//unsubscribe events
    private void OnDisable()
    {
        UIListener.ChangeMoveSpeedEventHandler -= ChangeMoveSpeed;
    }
    
    
    
}
