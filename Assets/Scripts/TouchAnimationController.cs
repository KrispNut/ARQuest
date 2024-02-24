using UnityEngine;

public class TouchAnimationController : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {

    }

    private void Update()
    {
        for (int i = 0;i < Input.touchCount;++i) 
        {                    
            if (Input.GetTouch(i).phase == TouchPhase.Began && animator.GetCurrentAnimatorStateInfo(0).IsName("Stop"))
            {
                animator.Play("Open");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && animator.GetCurrentAnimatorStateInfo(0).IsName("Stop"))
            {
                animator.Play("Open");
            }
            else if (Input.GetTouch(i).phase == TouchPhase.Began && animator.GetCurrentAnimatorStateInfo(0).IsName("Open"))
            {
                animator.Play("Stop");
            }
        }
    }
}