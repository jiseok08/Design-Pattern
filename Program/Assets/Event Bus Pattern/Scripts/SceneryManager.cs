using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] static SceneryManager instance;

    [SerializeField] Slider slider;
    [SerializeField] GameObject screen;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(instance);

            return;
        }
    }

    public void LoadScene(int buildIndex)
    {
        StartCoroutine(TranstionScene(buildIndex));
    }

    public IEnumerator TranstionScene(int index)
    {
        slider.value = 0;
        
        screen.SetActive(true);

        // <AsyncOperation>
        // - allowSceneActivation
        // ����� �غ�� ��� ����� Ȱ���Ǵ� ���� ����ϴ� �����Դϴ�.

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        // <AsyncOperation>
        // - isDone
        // �ش� ������ �Ϸ�Ǿ����� ��Ÿ���� �����Դϴ�. (�б� ����)

        while (asyncOperation.isDone == false)
        {
            // <AsyncOperation>
            // - progress
            // �۾��� ���� ���¸� ��Ÿ���� �����Դϴ�. (�б� ����)

            yield return null; // null�� ������ ����
            
            
            if(asyncOperation.progress >= 0.9f)
            {
                slider.value = Mathf.Lerp(slider.value, 1.0f, Time.deltaTime);

                if (slider.value >= 0.99f)
                {
                    slider.value = 1.0f;

                    asyncOperation.allowSceneActivation = true;
                }
            }
            else
            {
                slider.value = asyncOperation.progress;               
            }

            yield return null;
        }
        if (screen != null)
        {
            screen.SetActive(false);
        }
    }
}
