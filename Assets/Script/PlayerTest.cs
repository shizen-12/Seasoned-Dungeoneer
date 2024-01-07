using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTest : MonoBehaviour
{
    public float gravityPower = -30;
    public float jumpForce = 2.0f;
    public float speed = 10.0f;
    private Vector2 move;
    public bool jumpNow;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.current != null)
        {
            move = Gamepad.current.leftStick.ReadValue();
        }
        else
        {
            move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
    private void FixedUpdate()
    {
        Gravity();  //ジャンプ中に落下速度を変更する
        Vector3 movement = new Vector3(move.x, 0.0f, move.y);
        rb.AddForce(movement * speed);

        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = cameraForward * move.y + Camera.main.transform.right * move.x;
        rb.velocity = moveDirection * speed + new Vector3(0, rb.velocity.y, 0);

        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }

    }
    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);     //フェーズの表示を追加
        // Performedフェーズの判定を行う
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("ジャンプ入力を受け付けました");
            if (jumpNow == false)
            {
                rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                jumpNow = true;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (jumpNow == true)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                jumpNow = false;
            }
        }
    }
    void Gravity()
    {
        if (jumpNow == true)
        {
            rb.AddForce(new Vector3(0, gravityPower, 0));
        }
    }
}
