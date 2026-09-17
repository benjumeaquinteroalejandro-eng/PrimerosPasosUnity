using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public void CargarEscena(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    //responsabilidades game manager
    //1. cargar una escena o un nivel
    //2. reiniciar el juego o el nivel
    //3. salir del juego
    //4. pausar el juego

}
