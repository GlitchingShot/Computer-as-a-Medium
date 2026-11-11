using UnityEngine;
using UnityEngine.InputSystem;
public class playerdash : MonoBehaviour
{
    
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        colorSwap();
    }
    void colorSwap()
    {
        if (Keyboard.current.qKey.isPressed)
        {
            animator.SetBool("colorswap", true);
        }
        else
        {
            animator.SetBool("colorswap", false);
        }
    }
}
