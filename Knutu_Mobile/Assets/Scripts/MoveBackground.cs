using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float speed;
    Vector3 startPos;
    float width;
    float newX;
    Vector3 direction = new Vector2(-1, 1); // 남동방향 이동

    void Start()
    {
        this.startPos = this.transform.position;
        this.width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        this.newX = Mathf.Repeat(Time.time * -this.speed, this.width);
        this.transform.position = this.startPos + this.direction * this.newX;
    }
}
