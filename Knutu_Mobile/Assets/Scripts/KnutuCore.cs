using UnityEngine;

public class KnutuCore : MonoBehaviour
{
    void Awake()
    {
        KnutuCore[] objs = FindObjectsOfType<KnutuCore>();

        if (this.isGameInit(objs)) {
            DontDestroyOnLoad(gameObject);
            return;
        }

        Destroy(gameObject);
    }

    bool isGameInit(KnutuCore[] _objs)
    {
        return _objs.Length == 1;
    }
}
