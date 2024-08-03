using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class Ending : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI winText;

    private void Start()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Winning");
            winText.transform.localScale = Vector3.zero;
            winText.DOFade(1, 2f).SetEase(Ease.InOutQuad);
            winText.transform.DOScale(1, 1f).SetEase(Ease.OutBounce);

            winText.transform.localPosition = new Vector3(winText.transform.localPosition.x, winText.transform.localPosition.y, 0);
            winText.transform.DOLocalMoveY(90, 1f).SetEase(Ease.OutBack);
            winText.DOColor(Color.red, 2f).SetEase(Ease.OutElastic);
            Invoke("LoadScene", 2);
        }
    }

    private void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
