using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool isCreated = false;

    public float TotalScore;

    private void Awake()
    {
        if (!isCreated)
            instance = this;
        else
            Destroy(gameObject);
            
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            ReloadLevel();
    }

    public void PlayAnimation(Animator animator, string animationId,ref string CurrentState)
    {
        if (CurrentState == animationId)
            return;
        print(animator == null);
        
        animator.Play(animationId);
        CurrentState = animationId;
    }
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void LoadLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
