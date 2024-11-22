namespace Demo.Pages

{
public partial class  Counter
{
    [Microsoft.AspNetCore.Components.Parameter]
    public int? Increment { get;  set;}  = 4;
    private int increment = 1; 
    private int currentCount = 0;

    private void IncrementCount()
    {
        logger.LogInformation ("Es zaehlt!!");
        currentCount += increment;
    }
     protected override void OnParametersSet()
    { if (Increment.HasValue)
            increment = Increment.Value;
    }

}
}