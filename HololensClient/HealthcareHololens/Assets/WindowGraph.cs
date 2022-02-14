using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using System;

public class WindowGraph : MonoBehaviour
{
    // Start is called before the first frame update
    private RectTransform graphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;

    [SerializeField] private Sprite circleSprite;

    private void Awake()
    {
        graphContainer = transform.Find("GraphContainer").GetComponent<RectTransform>();
        labelTemplateX = graphContainer.Find("LabelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("LabelTemplateY").GetComponent<RectTransform>();
        dashTemplateX = graphContainer.Find("DashTemplateX").GetComponent<RectTransform>();
        dashTemplateY = graphContainer.Find("DashTemplateY").GetComponent<RectTransform>();

        var values = new List<int>() { 0, 15, 18, 56, 26, 48, 89, 56, 26, 48, 89, 56, 33, 100 };
        ShowGraph(values);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject CreateCirlce(Vector2 position)
    {
        GameObject gameObject = new GameObject("Circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;

        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = position;
        rectTransform.sizeDelta = new Vector2(5, 5);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);

        return gameObject;
    }

    private void ShowGraph(List<int> values)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float xSize = 20f;
        float ySize = 50f;
        float yMax = 100f;

        GameObject lastCircleGameObject = null;
        for (int i = 0; i < values.Count; i++)
        {
            float xPos = xSize + (i * xSize);
            float yPos = (values[i] / yMax) * graphHeight;
            var circleGameObject = CreateCirlce(new Vector2(xPos, yPos));

            if (lastCircleGameObject != null)
            {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
            }

            lastCircleGameObject = circleGameObject;

            /*
            var labelX = Instantiate(labelTemplateX);
            labelX.SetParent(graphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPos, -10f);
            labelX.GetComponent<Text>().text = i.ToString();      
          
            var dashX = Instantiate(dashTemplateX);
            dashX.SetParent(graphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(xPos, -7f);
            */
        }

        int separatorCount = 10;

        for (int i = 0; i <= separatorCount; i++)
        {
            var labelY = Instantiate(labelTemplateY);
            labelY.SetParent(graphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / separatorCount;
            labelY.anchoredPosition = new Vector2(-10f, normalizedValue * graphHeight);
            labelY.GetComponent<Text>().text = Convert.ToInt32(normalizedValue * yMax).ToString();

            var dashY = Instantiate(dashTemplateY);
            dashY.SetParent(graphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(-4f, normalizedValue * graphHeight);
        }
    }

    private void CreateDotConnection(Vector2 dotA, Vector2 dotB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);

        gameObject.GetComponent<Image>().color = Color.yellow;

        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        var direction = (dotB - dotA).normalized;
        var distance = Vector2.Distance(dotA, dotB);
      
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 3f);
        rectTransform.anchoredPosition = dotA + direction * distance * 0.5f;

        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(direction));

    }
}