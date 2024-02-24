using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private bool isTouched = false;
    private float countdownTimer = 10f;
    public int Index;
    public AudioSource moosic;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isTouched && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (TouchingObject(touch.position))
            {
                animator.SetTrigger("Open");
                moosic.Play();
                isTouched = true;

                StartCoroutine(StartCountdown());
            }
        }

        if (isTouched)
        {
            countdownTimer -= Time.deltaTime;

            if (countdownTimer <= 0f)
            {
                SceneManager.LoadScene(Index); 
            }
        }
    }

    bool TouchingObject(Vector2 touchPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(touchPosition);

        RaycastHit hit;
        return Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject;
    }

    IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(countdownTimer);
    }
}
