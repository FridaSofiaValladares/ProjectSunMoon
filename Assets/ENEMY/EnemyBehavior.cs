using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Enemybehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 3;
    public GameObject Explosion;
    public Transform pos;
    [SerializeField]private AudioClip explosionClip;
  

    private void Start()
    {
        Hitpoints = MaxHitpoints;
       
    }
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if (Hitpoints <= 0)
        {
            
            Destroy(gameObject);
            

            Instantiate(Explosion, pos.position, transform.rotation);
            AudioSource.PlayClipAtPoint(explosionClip, pos.position, 1f);

            Destroy(Explosion);
            
        }
    }
}
