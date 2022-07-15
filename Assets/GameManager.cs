using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public IdleAgent idleAgent;
    public Transform owner;
    public ConvGroup curGroup;
    public Transform cam;
    public request req;
    private static GameManager gm;
    public static GameManager Instance
    {
        get
        {
            if (gm == null) Debug.LogError("Game Manager is null!");
            return gm;
        }
    }
    // Start is called before the first frame update
    private void Awake()
    {
        gm = this;
    }
}
