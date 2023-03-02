using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;
    [SerializeField] private GameObject Pointer;

    public float speed = 300;
    Vector3 newPosition;

    void Start()
    {
        Debug.Log("Welcome to Space X");
    }

    void Update()
    {
        player.position = Vector2.MoveTowards(player.position, newPosition, speed * Time.deltaTime);
        RandomPositionGenerator();
        Pointer.transform.position = newPosition;
    }

    void RandomPositionGenerator()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newPosition.x = Random.Range(-9.40f, 9.40f);
            newPosition.y = Random.Range(-4.22f, 4.22f);

            Vector3 direction = newPosition - player.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 270f;

            transform.localEulerAngles = Vector3.forward * angle;
        }
    }

}
