using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private GameObject _Genius;
    public void CargarEscena(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
    public void PausarJuego()
    {
        Time.timeScale = 0f;
    }
    public void RetomarJuego()
    {
        Time.timeScale = 1f;
    }

    public void gameover()
    {
        _gameOver.SetActive(true);
    }

    public void playerwin()
    {
        _Genius.SetActive(true);
    }

    //responsabilidades game manager
    //1. cargar una escena o un nivel
    //2. reiniciar el juego o el nivel
    //3. salir del juego
    //4. pausar el juego

}
