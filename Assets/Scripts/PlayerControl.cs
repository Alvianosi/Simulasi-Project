using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Vector3 touchPosition;
    private Vector3 direction;
    private Rigidbody2D rb;
    private float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // private void OnEnable() {
    //     EnhancedTouchSupport.Enable();
    // }

    // private void OnDisable() {
    //     EnhancedTouchSupport.Disable();
    // }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.touchCount > 0)
        {
            // The screen has been touched so store the touch
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if (touch.phase == TouchPhase.Ended){
                rb.velocity = Vector2.zero;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
        }

        // Debug.Log("Jump!");
    }

    // public void Move(InputAction.CallbackContext context)
    // {
    //     Debug.Log("This touch is at " + context.ReadValue<Vector2>());
    //     // The screen has been touched so store the touch

    //     Vector2 touchPosition = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    //     transform.position = Vector2.Lerp(transform.position, new Vector2(touchPosition.x, touchPosition.y), Time.deltaTime * 1.0f);
    // }
}
