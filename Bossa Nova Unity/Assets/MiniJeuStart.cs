using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class MiniJeuStart : MonoBehaviour
{
    public GameObject dustPrefab;
    public int dustNumber;
    public Collider2D border;
    private Vector2 dustPos;
    private int yNb;
    private int xNb;
    private int xNb2 = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        yNb = (int) Mathf.Sqrt(dustNumber);
        xNb = dustNumber / yNb;
        if (dustNumber % yNb != 0)
        {
            xNb2 = xNb + 1;
        }
        

        Debug.Log(border.bounds);
        
    }

    static bool wellplaced (Vector2 point, Collider2D pelle, Collider2D border)
    {
        Vector2 center;
        Vector2 direction;
        Ray2D ray;
        RaycastHit z;
        bool hit;
        center = border.bounds.center;
        direction = center - point;
        ray = new Ray2D(point, direction);
        hit = border.Raycast(point, out z, direction.magnitude);
        return !hit;
    }
    Vector4 coord(int xNb, int yNb, int xNb2, Collider2D zone, int number)
    {
        float divX = zone.bounds.size.x / xNb;
        float divY = zone.bounds.size.y / yNb;
        float divX2 = zone.bounds.size.x / xNb2;
        int yA = (int)Mathf.Ceil((number / xNb) - 2);
        int yB = yA + 1;
        int xA = (number - ((yA - 1) * xNb)) - 1;
        int xB = xA + 1;
        float orX = zone.bounds.min.x;
        float orY = zone.bounds.min.y;
        Vector4 coord = new Vector4();
        if (xNb2 != 0 && yB == yNb)
        {
            coord = new Vector4(orX + (xA * divX2), orY + (yA * divY), orX + (xB * divX2), orY + (yB * divY));
        }
        else
        {
            coord = new Vector4(orX + (xA * divX), orY + (yA * divY), orX + (xB * divX), orY + (yB * divY));
        }
        return coord;
    }
}

