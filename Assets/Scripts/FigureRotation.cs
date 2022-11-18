using UnityEngine;

public class FigureRotation : MonoBehaviour
{
    [SerializeField] GameObject figure;
    [SerializeField] float rotatSpeed = 0.1f;

    float startSpeed;

    Touch myTouch;
    Vector2 touchPosition;
    Quaternion rotationFigureY;
    FigureMovement movement;

    private void Start()
    {
        movement = FindObjectOfType<FigureMovement>();
        startSpeed = movement.FigureSpeed;
    }

    private void Update()
    {
        RotationProcess();
    }

    void RotationProcess()
    {
        if(Input.touchCount > 0 && !movement.IsStop)
        {
            myTouch = Input.GetTouch(0);
            movement.FigureSpeed = 3f;

            if (myTouch.phase == TouchPhase.Moved)
            {
                rotationFigureY = Quaternion.Euler(0f, - myTouch.deltaPosition.x * rotatSpeed, 0f);
                figure.transform.rotation = rotationFigureY * transform.rotation;

            }
        }
        else if(!movement.IsStop)
        {
            movement.FigureSpeed = startSpeed;
        }
    }
}
