using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Screen : MonoBehaviour
{
    public Transform text;
    public int value;

    public int a1;
    public int a2;
    public int a3;
    public int b1;
    public int b2;
    public int b3;

    public GameObject FilmGameObject11;
    public GameObject FilmGameObject12;
    public GameObject FilmGameObject13;
    public GameObject FilmGameObject21;
    public GameObject FilmGameObject22;
    public GameObject FilmGameObject23;
    private PolarizingFilm film11;
    private PolarizingFilm film12;
    private PolarizingFilm film13;
    private PolarizingFilm film21;
    private PolarizingFilm film22;
    private PolarizingFilm film23;

    private Button buttonSweetness;
    private Button buttonSalinity;
    private Button buttonGreasiness;

    // Start is called before the first frame update
    void Start()
    {
        film11 = FilmGameObject11.GetComponent<PolarizingFilm>();
        GameObject button11 = FilmGameObject11.transform.Find("ButtonSweetness").gameObject;
        buttonSweetness = button11.GetComponent<Button>();

        film12 = FilmGameObject12.GetComponent<PolarizingFilm>();
        GameObject button12 = FilmGameObject12.transform.Find("ButtonSalinity").gameObject;
        buttonSalinity = button12.GetComponent<Button>();

        film13 = FilmGameObject13.GetComponent<PolarizingFilm>();
        GameObject button13 = FilmGameObject13.transform.Find("ButtonGreasiness").gameObject;
        buttonGreasiness = button13.GetComponent<Button>();

        film21 = FilmGameObject21.GetComponent<PolarizingFilm>();

        film22 = FilmGameObject22.GetComponent<PolarizingFilm>();

        film23 = FilmGameObject23.GetComponent<PolarizingFilm>();

    }

    // Update is called once per frame
    void Update()
    {
        if (buttonSweetness.lightBeam.activeSelf)
        {
            a1 = film11.Value;
        }
        else { a1 = 0; }
        if (buttonSalinity.lightBeam.activeSelf)
        {
            a2 = film12.Value;
        }
        else { a2 = 0; }
        if (buttonGreasiness.lightBeam.activeSelf)
        {
            a3 = film13.Value;
        }
        else { a3 = 0; }
        b1 = film21.Value;
        b2 = film22.Value;
        b3 = film23.Value;
        value = DotProduct(a1, a2, a3, b1, b2, b3);
        text.GetComponent<TextMeshPro>().text = value.ToString();
        int alpha = value * 255 / 300;
        text.GetComponent<TextMeshPro>().faceColor = new Color32(225, 135, 0, Convert.ToByte(alpha));
    }

    private int DotProduct(int a1, int a2, int a3, int b1, int b2, int b3)
    {
        return a1 * b1 + a2 * b2 + a3 * b3;
    }
}
