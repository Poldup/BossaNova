using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class MiniJeuStart : MonoBehaviour
{
    public GameObject instructions;
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
    private static int layerMask;
    public AudioSource music;
    public AudioSource musicAutre;


    private void Awake()
    {
        //layerMask = 1<<5;
        //layerMask = ~layerMask;
        layerMask = LayerMask.GetMask("Objets", "Poussieres");
        layerMask = ~layerMask;
    }

    void Start()
    {
        StartCoroutine(BalaiStart());
    }

    
    
    IEnumerator BalaiStart()
    {
        Debug.Log("test");
        instructions.SetActive(true);
        musicAutre.Stop();
        music.Play();

        yield return new WaitForSeconds(2);
        instructions.SetActive(false);

        yNb = (int)Mathf.Sqrt(dustNumber);
        xNb = dustNumber / yNb;
        if (dustNumber % yNb != 0)
        {
            xNb2 = xNb + 1;
        }
        divX = border.bounds.size.x / xNb;
        divY = border.bounds.size.y / yNb;
        divX2 = border.bounds.size.x / xNb2;
        for (int i = 1; i <= dustNumber; i++)
        {
            Vector4 section = coord(xNb, yNb, xNb2, border, i);
            float dustX;
            float dustY;
            Vector3 dustPos;
            int secu = 0;
            dustX = UnityEngine.Random.Range(section.x, section.z);
            dustY = UnityEngine.Random.Range(section.y, section.w);
            dustPos = new Vector3(dustX, dustY, 0);
            //Debug.Log("dust pos =" + dustPos);
            if (wellplaced(dustPos, pelle, border))
            {
                GameObject dust = Instantiate(dustPrefab, dustPos, dustPrefab.transform.rotation, Dusts.transform);
                //Debug.Log("dust placé");
                DustCounter.instance.Dusts.Add(dust);
            }
        }
        DustCounter.instance.started = true;
    }
    static bool wellplaced(Vector3 point, Collider2D pelle, Collider2D border)
    {
        Vector3 center;
        Vector3 direction;
        bool hit;
        bool inPelle=false;
        RaycastHit2D hitBorder;
        center = border.bounds.center;
        direction = center - point;
        hitBorder = Physics2D.Raycast(point, direction, direction.magnitude, layerMask);
        hit = hitBorder.collider;
        if (point.x>=pelle.bounds.min.x && point.x<=pelle.bounds.max.x && point.y >= pelle.bounds.min.y && point.y <= pelle.bounds.max.y)
        {
            inPelle=true;
        }
        return !(hit||inPelle);

    }

    Vector4 coord(int xNb, int yNb, int xNb2, Collider2D zone, int number)
    {
        int yA = (int)Mathf.Ceil(((float)number / (float) xNb)) - 1;
        int yB = yA + 1;
        int xA = (number - ((yA) * xNb)) - 1;
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

