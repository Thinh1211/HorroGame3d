using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMaze : MonoBehaviour
{
    public List<GameObject> Room;
    void Start()
    {
        StartCoroutine(DeactivateRandomObjectsOverTime(0.5f, 3));
    }

     void Update()
    {
    }

    IEnumerator DeactivateRandomObjectsOverTime(float duration, int numberOfObjects)
    {
        yield return new WaitForSeconds(duration);

        for (int i = 0; i < numberOfObjects; i++)
        {
            if (Room.Count > 0)
            {
                int randomIndex = Random.Range(0,Room.Count);
                Room[randomIndex].SetActive(false);
                Room.RemoveAt(randomIndex);
            }
        }
    }
}
