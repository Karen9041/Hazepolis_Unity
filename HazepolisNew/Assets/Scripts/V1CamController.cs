using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1CamController : MonoBehaviour
{

    public static V1CamController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    private Cinemachine.CinemachineConfiner confiner;
    private Collider2D mapConfiner;

    private void Start()
    {
        confiner = GetComponent<Cinemachine.CinemachineConfiner>();
    }
    // Update is called once per frame
    void Update()
    {
        mapConfiner = GameObject.FindWithTag("MapConfiner").GetComponent<Collider2D>();
        confiner.m_BoundingShape2D = mapConfiner;
    }
}
