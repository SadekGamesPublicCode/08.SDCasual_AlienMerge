using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WikisSC : MonoBehaviour
{
    private string specieURL, planetURL;
    private string eggyURL, creepURL, araURL, terrorURL, megaURL, primaURL, drakiURL, gigantURL, terraURL;
    private string hivemindURL, essenseSphereURL, nuclepinosURL;
    void Start()
    {
        AssistLinks();
    }
    public void ToWikies(int a)
    {
        switch (a)
        {
            case 0:
                //Morpinos Specie
                Application.OpenURL(planetURL); 
                break;
            case 1:
                //Planet
                Application.OpenURL(specieURL);
                break;
            case 2:
                Application.OpenURL(eggyURL);
                break;
            case 3:
                Application.OpenURL(creepURL);
                break;
            case 4:
                Application.OpenURL(araURL);
                break;
            case 5:
                Application.OpenURL(terrorURL);
                break;
            case 6:
                Application.OpenURL(drakiURL);
                break;
            case 7:
                //Morpinos Specie
                Application.OpenURL(megaURL);
                break;
            case 8:
                //Planet
                Application.OpenURL(primaURL);
                break;
            case 9:
                Application.OpenURL(terraURL);
                break;
            case 10:
                Application.OpenURL(gigantURL);
                break;
            case 11:
                Application.OpenURL(hivemindURL);
                break;
            case 12:
                Application.OpenURL(nuclepinosURL);
                break;
            case 13:
                Application.OpenURL(essenseSphereURL);
                break; 
        }
    }
    private void AssistLinks()
    {
        planetURL = "https://sadekgame.wordpress.com/2025/09/22/magnar-planet/";
        specieURL = "https://sadekgame.wordpress.com/2025/02/27/morpinos/";
        eggyURL = "https://sadekgame.wordpress.com/2026/04/06/eggy/";
        creepURL = "https://sadekgame.wordpress.com/2024/08/16/creepling/";
        araURL = "https://sadekgame.wordpress.com/2024/08/16/arachiling/";
        terrorURL = "https://sadekgame.wordpress.com/2026/01/19/terrorling/";
        megaURL = "https://sadekgame.wordpress.com/2024/08/16/megarhino/";
        primaURL = "https://sadekgame.wordpress.com/2024/08/16/primanos/";
        drakiURL = "https://sadekgame.wordpress.com/2024/08/16/drakinos/";
        gigantURL = "https://sadekgame.wordpress.com/2026/04/06/gigantinoS/";
        terraURL = "https://sadekgame.wordpress.com/2026/04/06/TERRANOS";
        hivemindURL = "https://sadekgame.wordpress.com/2026/01/19/morpinos-imperatos/";
        essenseSphereURL = "https://sadekgame.wordpress.com/2025/10/31/morpinos-genopinos/";
        nuclepinosURL = "https://sadekgame.wordpress.com/2026/04/14/morpinos-nuclepinos/";
    }
}
