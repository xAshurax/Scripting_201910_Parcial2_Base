using UnityEngine;

public abstract class Composite : RootChild
{
    [SerializeField]
    private RootChild[] children;

    public override void SetTargetAI(GameObject target)
    {
        base.SetTargetAI(target);

        foreach (Node node in children)
        {
            node.SetTargetAI(TargetAI);
        }
    }

  

    public override void Execute()
    {
      

        foreach (Node node in children)
        {
          node.Execute();

            
        }

        
    }
}