using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLevel : MonoBehaviour
{
    private float transitionTime = 1f;

    public Animator animatorTransition;
    // Start is called before the first frame update
    void Start()
    {
        animatorTransition.SetTrigger("AnimationStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameScene()
    {

        StartCoroutine(PremierEcran());
    }

    IEnumerator PremierEcran()
    {
     animatorTransition.SetTrigger("AnimationStart");
     yield return new WaitForSeconds(transitionTime);
    }


    public void SceneJeu()
    {
        StartCoroutine(ChargementSceneJeu());
    }



    IEnumerator ChargementSceneJeu()
    {
        animatorTransition.SetTrigger("AnimationStart");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("Scenes/Scène Hub");
    }
    
    
}
