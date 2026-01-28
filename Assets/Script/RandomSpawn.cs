using UnityEngine;
using UnityEngine.InputSystem;

public class RandomSpawn : MonoBehaviour
{

    SpriteRenderer sprite;
    float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            SpawnObject();
        }
    }
    void SpawnObject()
    {
        t += Time.deltaTime;
        Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0f);

        sprite.transform.position = randomPosition;
        sprite.GetComponent<Renderer>().transform.position = randomPosition;

        if (t >= 1f)
        {
            t = 0f;
        }
    }
}
