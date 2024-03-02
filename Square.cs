 
	public Vector2 targetPosition;

	public float moveStep;

void Start () 
	{
		targetPosition = GetRandomPoint();
	}


Vector2 GetRandomPoint()
    {
        Vector2 randomVector = new Vector2();
 
        randomVector.x = Random.Range(-6, 6);
        randomVector.y = Random.Range(-3, 3);
 
        return randomVector;
    }
