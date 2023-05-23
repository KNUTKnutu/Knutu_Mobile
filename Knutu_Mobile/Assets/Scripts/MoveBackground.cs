using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed = 0.5f;
    Vector3 startpos;
    float width;
    float newX;
    Vector3 direction = new Vector2(-1, 1); // 남동방향 이동

    void Start()
    {
        startpos = transform.position;
        Debug.Log(startpos);
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log(width);
    }

    void Update()
    {
        newX = Mathf.Repeat(Time.time * -speed, width);
        transform.position = startpos + direction * newX;
    }
}
