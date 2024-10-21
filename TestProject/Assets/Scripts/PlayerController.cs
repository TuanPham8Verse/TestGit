using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForge = 15f;
    [SerializeField] private LayerMask layerMask;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position + new Vector3(0, -1), -Vector2.up);
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, -1), -Vector2.up, 0.2f, layerMask);
        if (hit)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForge);
            }
        }
    }
}
