using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Follow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Vector3 GameObjectPosition;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        GameObjectPosition = GameObject.Find("Player").transform.position;
        enemy.SetDestination(GameObjectPosition);
        
    }
}
