namespace Services.UI
{
    public interface IUIService
    {
        T OpenElement<T>(EUIShowType showType) where T : UIElementBase;
        void CloseElement<T>() where T : UIElementBase;
    }
}