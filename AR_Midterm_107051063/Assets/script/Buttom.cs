
using UnityEngine;

public class Buttom : MonoBehaviour
{

    [Header("女")]
    public Animator female;

    [Header("男")]
    public Animator male;

    public void Attack()
    {
        female.SetTrigger("攻擊");
        male.SetTrigger("攻擊");
    }

    public void Run()
    {
        female.SetTrigger("跑步");
        male.SetTrigger("跑步");
    }
}
