using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToShoot : MonoBehaviour
{
    Rigidbody2D rbody;
    Vector2 startpos;
    Vector2 endpos;
    [SerializeField] float power = 2f; // güç

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            LaunchBall();
        }
    }

    void OnMouseDown()
    {
        startpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void LaunchBall()
    {
        Vector2 direction = (startpos - endpos).normalized; // yön ayarla
        rbody.AddForce(direction * power, ForceMode2D.Impulse);
    }
}
