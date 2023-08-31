using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public float orthographicSize = 5f;
    public GameObject cha;
    public float zAxis;
    public List<float> objectFirstPos = new List<float>();

    void Update()
    {
        transform.position = new Vector3(cha.transform.position.x, cha.transform.position.y + 3f, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            zAxis = cha.transform.position.z;
            if (mainCamera.orthographic)
            {
                SwitchToPerspective();
            }
            else
            {
                SwitchToOrthographic();
                objectFirstPos.Clear();
            }

            for (int i = 0; i < ObjectTransform.instance.worldObjects.Length; i++)
            {
                objectFirstPos.Add(ObjectTransform.instance.worldObjects[i].transform.position.z);
                
                if (mainCamera.orthographic)
                {
                    ObjectTransform.instance.worldObjects[i].transform.position = new Vector3(ObjectTransform.instance.worldObjects[i].transform.position.x,
                        ObjectTransform.instance.worldObjects[i].transform.position.y,
                        zAxis);
                }
                else
                {
                    ObjectTransform.instance.worldObjects[i].transform.position = new Vector3(ObjectTransform.instance.worldObjects[i].transform.position.x,
                        ObjectTransform.instance.worldObjects[i].transform.position.y,
                        objectFirstPos[i]);
                }
            }
        }

        if (mainCamera.orthographic)
        {

            cha.transform.position = new Vector3(cha.transform.position.x, cha.transform.position.y, zAxis);
        }
        else
        {
            cha.transform.position = cha.transform.position;
        }
    }

    void SwitchToOrthographic()
    {
        mainCamera.orthographic = true;
        mainCamera.orthographicSize = orthographicSize;
        cha.GetComponent<Rigidbody>().freezeRotation = true;
    }

    void SwitchToPerspective()
    {
        mainCamera.orthographic = false;
    }
}
