using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    #region Properties
    private Enemy[] _enemies;
    private static int _nextLevelIndex = 0;
    #endregion

    #region Public API
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }
        }

        Debug.Log("You killed all enemies");

        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;

        SceneManager.LoadScene(nextLevelName);
    }
    #endregion

    #region Private API
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }
    #endregion
}
