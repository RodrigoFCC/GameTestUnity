using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject RightArm;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;
    public AudioClip PunchAttackSound;

    void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (CanAttack)
            {
                RightArmAttack();
            }
        }
    }

    public void RightArmAttack()
    {
        CanAttack = false;
        Animator anim = RightArm.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(PunchAttackSound);
        StartCoroutine(ResetAttackCooldown());
    }

    IEnumerator ResetAttackCooldown()
    {
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    }

}
