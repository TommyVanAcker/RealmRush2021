using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1.3f;

    
    void Start()
    {
       StartCoroutine(FollowPath());
    }

   IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            SetEnemyPosition(waypoint);
            yield return new WaitForSeconds(waitTime);
        }
    }

    void SetEnemyPosition(Waypoint tile)
    {
        transform.position = tile.transform.position;
    }
}
