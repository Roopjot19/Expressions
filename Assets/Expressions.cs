using UnityEngine;

public class Expressions : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SetExpression("Happy");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SetExpression("Sad");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SetExpression("Surprised");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SetExpression("Angry");
            }
        }
       
        
    }

    void SetExpression(string expression)
    {
        // Trigger the specified expression
        animator.SetTrigger(expression);
    }
}
