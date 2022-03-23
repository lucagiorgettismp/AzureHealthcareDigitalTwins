using UnityEngine;

public class Progress : MonoBehaviour
{
    // Start is called before the first frame update
    private RectTransform rectComponent;
    private readonly float rotateSpeed = 200f;

    private void Start()
    {
        rectComponent = GetComponent<RectTransform>();
    }

    private void Update()
    {
        rectComponent.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
