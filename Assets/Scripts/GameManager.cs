using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PositionSave positionSave;
    
    // Start is called before the first frame update
    void Start()
    {
        positionSave = GameObject.Find("Player").GetComponent<PositionSave>();
    }
}