using System;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField] float speed = 1;
    private Rigidbody2D rb;

    [SerializeField] private PlayerAnim _playerAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            rb = collision.GetComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (rb == null)
        {
            return;
        }

        rb.gravityScale = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, speed);
            _playerAnim.OnLadderAnimation(true);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -speed);
            _playerAnim.OnLadderAnimation(true);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
            _playerAnim.OnLadderAnimation(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            _playerAnim.OnLadderAnimation(false);
            rb.gravityScale = 1;
            rb = null;
        }
    }
}
