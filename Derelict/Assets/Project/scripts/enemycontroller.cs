using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{

    public delegate void EnemyKilled();

    public static event EnemyKilled OnEnemyKilled;

    // Start is called before the first frame update
    void Start()
    {

        setRigidbodyState(true);
        setColliderState(false);
        GetComponent<Animator>().enabled = true;
    }
    public void die()
    {

        GetComponent<Animator>().enabled = false;
        setRigidbodyState(false);
        setColliderState(true);

        if (gameObject != null)

        {
            Destroy(gameObject, 3f);
        }
        if(OnEnemyKilled!=null)
        {
            OnEnemyKilled();
        }
    }

    void setRigidbodyState(bool state)
    {

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rigidbodies)
        {

            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = !state;
    }
    void setColliderState(bool state)
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled=! state;

    }
}