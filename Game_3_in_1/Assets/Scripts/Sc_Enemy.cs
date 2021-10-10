using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Enemy : MonoBehaviour
{
    public bool isDestroy = false;
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime); 
    }
    public void OnMouseDown()
    {
        Debug.LogError("OnMouseDown");
        isDestroy = true;
    }
}
