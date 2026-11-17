using UnityEngine;

public class BrickWall : MonoBehaviour
{
    public Transform[] bricks;
    public float timeToDestroy = 3f;

    // Update is called once per frame
    void Update()
    {
        timeToDestroy -= Time.deltaTime;

        foreach (Transform brick in bricks)
        {
            if (brick != null)
                brick.localScale = Vector3.Lerp(brick.localScale, Vector3.zero, Time.deltaTime);
        }

        if (timeToDestroy <= 0)
            Destroy(gameObject);
    }
}
