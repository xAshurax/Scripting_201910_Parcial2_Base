using UnityEngine;

public class Root : Node
{
    [SerializeField]
    private Composite child;

    public override void Execute()
    {
        

        if (child != null)
        {
           child.Execute();
        }

      
    }

    private void Update()
    {
        Execute();
    }
}