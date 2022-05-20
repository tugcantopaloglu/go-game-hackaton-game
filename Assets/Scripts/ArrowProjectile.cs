using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowProjectile : MonoBehaviour
{
    public float force;
    public Rigidbody rigidbodyArrow;
    Cinemachine.CinemachineImpulseSource source;
    private void Awake()
    {
        rigidbodyArrow = GetComponent<Rigidbody>();
        rigidbodyArrow.centerOfMass = transform.position;
    }

    public void Fire()
    {
        rigidbodyArrow.AddForce(transform.forward * (100 * Random.Range(1.3f, 1.7f)), ForceMode.Impulse);
        source = GetComponent<Cinemachine.CinemachineImpulseSource>();

        source.GenerateImpulse(Camera.main.transform.forward);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Player")
        {
            rigidbodyArrow.isKinematic = true;
            StartCoroutine(Countdown());
        }
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }


}
