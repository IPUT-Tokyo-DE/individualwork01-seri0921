using UnityEngine;

public enum ShapeType { Circle, Triangle, Square }

public class PlayerFormSwitcher : MonoBehaviour
{
    public GameObject circleForm;
    public GameObject triangleForm;
    public GameObject squareForm;

    private ShapeType currentShape;

    public ShapeType CurrentShape => currentShape;

    void Start()
    {
        SwitchShape(ShapeType.Circle); // èâä˙å`èÛÇÅZÇ…
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) SwitchShape(ShapeType.Circle);
        if (Input.GetKeyDown(KeyCode.X)) SwitchShape(ShapeType.Triangle);
        if (Input.GetKeyDown(KeyCode.C)) SwitchShape(ShapeType.Square);
    }

    void SwitchShape(ShapeType shape)
    {
        currentShape = shape;

        circleForm.SetActive(shape == ShapeType.Circle);
        triangleForm.SetActive(shape == ShapeType.Triangle);
        squareForm.SetActive(shape == ShapeType.Square);
    }
}
