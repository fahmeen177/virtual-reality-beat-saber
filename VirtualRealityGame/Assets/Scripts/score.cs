using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoreeValue = 0;
    Text scoree;
    // Start is called before the first frame update
    void Start()
    {
        scoree = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoree.text = "Score: " + scoreeValue;
    }
}
