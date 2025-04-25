using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext;
    [SerializeField] private TextMeshProUGUI lifetext;
    [SerializeField] private GameObject endscreencontainer;
    [SerializeField] private TextMeshProUGUI endresults;
    [SerializeField] private Button retrybutton;

    void Start()
    {
        retrybutton.onClick.AddListener(retrybuttonClicked);
        scoretext.text = $"´puntaje: 0";
    }

    public void showendscreen(bool isWin)
    {
        if (isWin)
        {
            endresults.text = "ganaste";
        }
        else
        {
            endresults.text = "perdiste";
        }
        endscreencontainer.SetActive(true);
    }
    private void retrybuttonClicked()
    {
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
    }

    public void updatescore(int newScore) { scoretext.text = $"puntaje: {newScore}"; }
    public void updatelife (int life) { lifetext.text = $"vidas: {life}"; }
}
