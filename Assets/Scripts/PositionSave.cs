using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSave : MonoBehaviour
{
    public float posX;
    public float posY = 1f;
    public float posZ;

    public string checkpoint;

    public Vector3 Position;

    // Start is called before the first frame update
    void Start()
    {
        CargarPos();
    }

    // Update is called once per frame
    void Update()
    {
       checkpoint = PlayerPrefs.GetString("Collider");
    }

    public void GuardarPos()
    {
       PlayerPrefs.SetFloat("PositionX", transform.position.x);
       PlayerPrefs.SetFloat("PositionY", transform.position.y);
       PlayerPrefs.SetFloat("PositionZ", transform.position.z);
    }

    public void CargarPos()
    {
       posX = PlayerPrefs.GetFloat("PositionX");
       posY = PlayerPrefs.GetFloat("PositionY");
       posZ = PlayerPrefs.GetFloat("PositionZ");

       Position.x = posX;
       Position.y = posY;
       Position.z = posZ;

       transform.position = Position;

       checkpoint = PlayerPrefs.GetString("Collider");
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "checkpoint")
        {
           PlayerPrefs.SetString("Collider", other.gameObject.name);
           GuardarPos();
        }
    }
}
