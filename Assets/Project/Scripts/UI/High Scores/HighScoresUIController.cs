using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HighScoresUIController : MonoBehaviour {
    [SerializeField] private Transform _content;
    [SerializeField] private UIScoreRecord _scoreRecordPrefab;
    [SerializeField] private UIWindow _window;

    // megjelenítjuk az ablakot, betöltjük és megjelenítjük a pontszámokat
    private void Start() {
        _window.Show();

        var scores = LoadScores();
        ShowScores(scores);
    }

    // pontszámok megjelenítése (1 prefab példány 1 pontszámot jelenít meg)
    private void ShowScores(IEnumerable<ScoreRecord> scores) {
        foreach (var scoreRecord in scores) {
            var record = Instantiate(_scoreRecordPrefab, _content);
            record.ScoreRecord = scoreRecord;
        }
    }

    // pontszámok betöltése (egyelőre csak placeholder megoldás)
    private List<ScoreRecord> LoadScores() {
        return new List<ScoreRecord> {
                new ScoreRecord {Name = "F. Ádám", Score = 13000},
                new ScoreRecord {Name = "Péter", Score = 5000},
                new ScoreRecord {Name = "Marcell", Score = 8000},
                new ScoreRecord {Name = "Ádám", Score = 3000}
            }
            .OrderByDescending(r => r.Score)
            .ToList();
    }
}