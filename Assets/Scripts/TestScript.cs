using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Start Function";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
