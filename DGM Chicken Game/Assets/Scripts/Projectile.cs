using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public int damage = 1;

    public int time = 5;

    void  Start(){   
        StartCoroutine(DestroyBullet());
        
    }

    IEnumerator DestroyBullet(){
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}