namespace Services.UI
{
    public interface IUIService
    {
        T OpenScreen<T>() where T : UIElementBase;
        T OpenDialogue<T>() where T : UIElementBase;
        
    }
}