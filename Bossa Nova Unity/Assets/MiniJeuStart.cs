using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class MiniJeuStart : MonoBehaviour
{
    public GameObject dustPrefab;
    public GameObject Dusts;
    public int dustNumber;
    public Collider2D border;
    public Collider2D pelle;
    private int yNb;
    private int xNb;
    private int xNb2 = 0;
    private float divX;
    private float divY;
    private float divX2; 
    


    // Start is called before the first frame update
    void Start()
    {
        yNb = (int) Mathf.Sqrt(dustNumber);
        Debug.Log("sqrt"+Mathf.Sqrt(6));
        xNb = dustNumber / yNb;
        if (dustNumber % yNb != 0)
        {
            xNb2 = xNb + 1;
        }
        divX = border.bounds.size.x / xNb;
        divY = border.bounds.size.y / yNb;
        divX2 = border.bounds.size.x / xNb2;
        Debug.Log("divY"+divY);
        for (int i=1; i<=dustNumber; i++)
        {
            Vector4 section = coord(xNb, yNb, xNb2, border, i);
            float dustX = UnityEngine.Random.Range(section.w, section.y);
            float dustY = UnityEngine.Random.Range(section.x, section.z);
            Vector3 dustPos = new Vector3(dustX, dustY, 0);
            Debug.Log("dust pos =" + dustPos);
            if (!wellplaced(dustPos, pelle, border))
            {
                GameObject dust = Instantiate(dustPrefab, dustPos, dustPrefab.transform.rotation, Dusts.transform);
                Debug.Log("dust placé");
            }
        }

        
        
    }

    static bool wellplaced(Vector3 point, Collider2D pelle, Collider2D border)
    {
        Vector3 center;
        Vector3 centerPelle;
        Vector3 direction;
        Vector3 directionPelle;
        bool hit;
        bool hit2;
        RaycastHit2D hitBorder;
        RaycastHit2D hitPelle;
        center = border.bounds.center;
        centerPelle = pelle.bounds.center;
        direction = center - point;
        directionPelle = centerPelle - point;
        hitBorder = Physics2D.Raycast(point, direction, direction.magnitude);
        hitPelle = Physics2D.Raycast(point, directionPelle, directionPelle.magnitude);
        hit = hitBorder.collider;
        hit2 = hitPelle.collider;
        
        return hit || hit2;

    }

    Vector4 coord(int xNb, int yNb, int xNb2, Collider2D zone, int number)
    {
        Debug.Log("(int)Mathf.Ceil((" + number + '/' + xNb + ")-1");
        int yA = (int)Mathf.Ceil(((float)number / (float) xNb)) - 1;
        int yB = yA + 1;
        int xA = (number - ((yA) * xNb)) - 1;
        int xB = xA + 1;
        Debug.Log("yA" + yA + "yB" + yB + "xA" + xA + "xB" + xB);
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

