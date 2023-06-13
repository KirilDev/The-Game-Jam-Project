using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlller : MonoBehaviour
{
    [Header("Enemy Speed")]
    [Min(1)]
    public float speed;
    [Space(18f)]
    [Header("Player Transform for Enemy")]
    private Transform player;
    public GameObject deadScreen;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("This work!");
        deadScreen.SetActive(true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Element"))
        {
            Destroy(collision.gameObject);
        }
    }
}
