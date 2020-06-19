using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision)
    {
        var contactsCount = myCollision.contactCount;
        List<ContactPoint> points = new List<ContactPoint>();
        for (int i = 0; i < contactsCount; i++)
        {
            points.Add(myCollision.GetContact(i));
        }
        List<Vector3> vectors = new List<Vector3>();

        foreach (ContactPoint pnt in points)
        {
            vectors.Add(pnt.point);
        }
            
        bool flag = true;
        if (flag)
        {
            String stringEnd = contactsCount > 1 ? "точках" : "точке";
            Debug.Log($"{gameObject.name} пересекается с {myCollision.gameObject.name} в {stringEnd}:");
            foreach(Vector3 vector in vectors)
            {
                Debug.Log($"x:{vector.x} y:{vector.y} z:{vector.z}");
            }
        }
        else
        {
            Debug.Log($"{gameObject.name} пересекается с {myCollision.gameObject.name}");
        }
    }
} 