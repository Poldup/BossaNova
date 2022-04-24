using UnityEngine;
using TMPro;
using TMPro.Examples;
using UnityEngine.EventSystems;

public class POINTS : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private TextMeshPro numero;
    public LigneConnection ligneConnectionBase;
    public POINTS prochainPoint;
    
    [SerializeField]
    public bool estRelie;
    

    public static bool ecranEstFini;
    
        // Start is called before the first frame update
        void Start()
        {
            numero.text = this.gameObject.name;

        }

        // Update is called once per frame
        void Update()
        {

        }
 
        public void OnPointerDown(PointerEventData eventData)
        {
            
            if (!estRelie && Instantiate(ligneConnectionBase.gameObject,transform).TryGetComponent(out LigneConnection nouvelleConnection))
            {
                //Debug.Log("bouton active");
                nouvelleConnection.PositionPoints(this, prochainPoint);
                nouvelleConnection.quandRelie.AddListener((() =>
                {
                    estRelie = true;
                }));
                nouvelleConnection.SuivreSouris(this);

            }

            
            
        }


        
}


