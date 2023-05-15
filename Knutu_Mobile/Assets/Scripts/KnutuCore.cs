using UnityEngine;

public class KnutuCore : MonoBehaviour
{
    private void Awake()
    {
        KnutuCore[] objs = FindObjectsOfType<KnutuCore>();


        if (objs.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
