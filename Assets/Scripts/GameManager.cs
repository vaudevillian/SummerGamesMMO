using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public GameObject m_MenuHome;
    public GameObject m_MenuTraining;

	// Use this for initialization
	void Awake ()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);	
	}

    public void openMenu( string panelName )
    {
        m_MenuHome.SetActive(false);
        m_MenuTraining.SetActive(false);
        
        if( panelName == "Training" )
        {
            m_MenuTraining.SetActive(true);
        }
        else
        {
            m_MenuHome.SetActive(true);
        }
    }
}
