using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class WindowGraph : MonoBehaviour
{
    private Sprite circleSprite;
    private int ySeparators;
    private int xPoints;

    // Start is called before the first frame update
    private RectTransform graphContainer;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateY;

    private Color color;

    private List<float?> pointList;

    const string CIRCLE_NAME = "Circle";
    const string LINE_SEGMENT_NAME = "Segment";

    //private RectTransform labelTemplateX;
    //private RectTransform dashTemplateX;

    private void Awake()
    {
        this.ySeparators = 5;
        this.xPoints = 25;

        graphContainer = transform.Find("GraphContainer").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("LabelTemplateY").GetComponent<RectTransform>();
        dashTemplateY = graphContainer.Find("DashTemplateY").GetComponent<RectTransform>();
        this.circleSprite = Resources.Load<Sprite>("Sprites/circle");
        //labelTemplateX = graphContainer.Find("LabelTemplateX").GetComponent<RectTransform>();
        //dashTemplateX = graphContainer.Find("DashTemplateX").GetComponent<RectTransform>();

        pointList = new List<float?>();

        for(int i = 0; i < xPoints; i++)
        {
            pointList.Add(null);
        }
    }

    public void AddPoint(float point, float yAxisMin, float yAxisMax, Color color)
    {
        if (pointList[pointList.Count -1] == null)
        {
            PaintAxis(yAxisMin, yAxisMax);
        }

        this.color = color;

        pointList.RemoveAt(0);
        pointList.Add(point);

        UpdateGraph(pointList, yAxisMin, yAxisMax);
    }

    private GameObject CreateCircle(Vector2 position)
    {
        GameObject gameObject = new GameObject(CIRCLE_NAME, typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;

        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = position;
        rectTransform.sizeDelta = new Vector2(0.0005f, 0.0005f);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);

        return gameObject;
    }

    private void UpdateGraph(List<float?> values, float yAxisMin, float yAxisMax)
    {
        ClearGraph();

        float graphHeight = graphContainer.sizeDelta.y;
        float xSize = graphContainer.sizeDelta.x / (xPoints - 1);

        GameObject lastCircleGameObject = null;
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i].HasValue)
            {
                float xPos = i * xSize;
                float yPos = (values[i].Value - yAxisMin) / (yAxisMax - yAxisMin) * graphHeight;
                var circleGameObject = CreateCircle(new Vector2(xPos, yPos));

                if (lastCircleGameObject != null)
                {
                    CreateSegment(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                }

                lastCircleGameObject = circleGameObject;
            }
        }
    }

    private void ClearGraph()
    {
        var children = new List<GameObject>();
        var toBeDestroyed = new List<string>() { CIRCLE_NAME, LINE_SEGMENT_NAME };

        foreach (RectTransform child in graphContainer)
        {
            if (toBeDestroyed.Contains(child.name))
            {
                children.Add(child.gameObject);
            }
        }

        children.ForEach(child => Destroy(child));
    }

    private void PaintAxis(float yAxisMin, float yAxisMax)
    {
        float graphHeight = graphContainer.sizeDelta.y;

        for (int i = 0; i <= ySeparators; i++)
        {
            var labelY = Instantiate(labelTemplateY);
            labelY.SetParent(graphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / ySeparators;
            labelY.anchoredPosition = new Vector2(-0.006f, normalizedValue * graphHeight);
            labelY.GetComponent<TextMeshPro>().text = Convert.ToInt32(yAxisMin + (normalizedValue * (yAxisMax - yAxisMin))).ToString();

            var dashY = Instantiate(dashTemplateY);
            dashY.SetParent(graphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(0f, normalizedValue * graphHeight);
        }
    }

    private void CreateSegment(Vector2 dotA, Vector2 dotB)
    {
        GameObject gameObject = new GameObject(LINE_SEGMENT_NAME, typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);

        gameObject.GetComponent<Image>().color = color;

        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        var direction = (dotB - dotA).normalized;
        var distance = Vector2.Distance(dotA, dotB);

        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 0.0008f);
        rectTransform.anchoredPosition = dotA + (0.5f * distance * direction);

        rectTransform.localEulerAngles = new Vector3(0, 0, GetAngleFromVectorFloat(direction));
    }
    private static float GetAngleFromVectorFloat(Vector3 direction)
    {
        direction = direction.normalized;

        float n = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (n < 0)
        {
            n += 360;
        }

        return n;
    }
}