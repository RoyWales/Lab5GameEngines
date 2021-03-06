using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulePlacer : MonoBehaviour
{
    static List<Transform> capsules;

    public static void PlaceCapsule(Vector3 position, Color color, Transform capsule)
    {
        Transform newCapsule = Instantiate(capsule, position, Quaternion.identity);
        newCapsule.GetComponentInChildren<MeshRenderer>().material.color = color;
        if (capsules == null)
        {
            capsules = new List<Transform>();
        }
        capsules.Add(newCapsule);
    }

    public static void RemoveCapsule(Vector3 position, Color color)
    {
        for (int i = 0; i < capsules.Count; i++)
        {
            if (capsules[i].position == position && capsules[i].GetComponentInChildren<MeshRenderer>().material.color == color)
            {
                GameObject.Destroy(capsules[i].gameObject);
                capsules.RemoveAt(i);
                break;
            }
        }
    }
}

