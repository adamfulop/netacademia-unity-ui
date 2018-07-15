using DG.Tweening;
using UnityEngine;

public class UIWindow : MonoBehaviour {
    [SerializeField] private float _tweenDurationSeconds;

    private void Start() {
        transform.localScale = Vector3.zero;    // kezdetben scale 0
    }

    public void Show() {
        transform
            .DOScale(1, _tweenDurationSeconds)    // scale-t 1-re animáljuk _tweenDurationSeconds másodperc alatt
            .SetEase(Ease.OutBounce);            // animáció legyen "pattogós"
    }
}
