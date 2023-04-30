using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class BulletCollision : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void OnCollisionEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("bullet"))
    //    {
    //        Vector3 newPos = new Vector3(door.transform.position.x, 90f, door.transform.position.z);
    //        door.transform.position = newPos;
    //        Debug.Log("Door opened");

    //        MeshRenderer doorMeshRenderer = door.GetComponent<MeshRenderer>();
    //        if (doorMeshRenderer != null)
    //        {
    //            doorMeshRenderer.enabled = false;
    //        }
    //    }

    //    if (other.gameObject.CompareTag("bullet"))
    //    {
    //        MeshRenderer thiss = this.gameObject.GetComponent<MeshRenderer>();
    //        thiss.enabled = false;
    //    }
    //}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Quaternion newRot = Quaternion.Euler(door.transform.rotation.x, 90f, door.transform.rotation.z);
            door.transform.rotation = newRot;

            Vector3 newPos = new Vector3(0, door.transform.position.x,  door.transform.position.z);
            door.transform.position = newPos;
            Debug.Log("Door opened");

            //MeshRenderer doorMeshRenderer = door.GetComponent<MeshRenderer>();
            //if (doorMeshRenderer != null)
            //{
            //    doorMeshRenderer.enabled = false;
            //}
        }

        //if (other.gameObject.CompareTag("bullet"))
        //{
        //    MeshRenderer thiss = this.gameObject.GetComponent<MeshRenderer>();
        //    thiss.enabled = false;
        //}
    }
}
