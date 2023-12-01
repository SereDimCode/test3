using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //=========================================================== Editor
    public HandlerPlayerS handler;
    //=========================================================== Editor
    float _torque;
    float _force;
    float _jumpForce;
    bool _isGrounded;
    bool _isJumpReady;
    float _timerJump;
    float _tarTimerJump;
    private void Awake()
    {
        _tarTimerJump = 0.1f;
        _torque = 8f;
        _force = 3f;
        _jumpForce = 7f;
    }
    private void FixedUpdate()
    {
        //=========================================================== Durable physics
        handler.rb.AddTorque(new Vector3(_torque * Time.fixedDeltaTime, 0f, 0f));
        handler.rb.AddForce(new Vector3(0f, 0f, _force * Time.fixedDeltaTime),ForceMode.Impulse);
        //=========================================================== Durable physics
        
        if (!_isJumpReady && _timerJump >= _tarTimerJump)
        {
            _isJumpReady = true;
        }
        else
        {
            _timerJump += Time.fixedDeltaTime;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "underground")
        {
            _isGrounded = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "underground")
        {
            _isGrounded = false;
        }
    }
    public void Jump()
    {
        if (_isGrounded && _isJumpReady)
        {
            handler.rb.AddForce(new Vector3(0f, _jumpForce, 0f), ForceMode.Impulse);
            _isJumpReady = false;
            _timerJump = 0f;
        }
    }
}
