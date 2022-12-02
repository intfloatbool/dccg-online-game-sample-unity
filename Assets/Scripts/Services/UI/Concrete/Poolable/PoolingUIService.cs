namespace Services.UI.Concrete.Poolable
{
    public class PoolingUIService : IUIService
    {
        public T OpenElement<T>(EUIShowType showType) where T : UIElementBase
        {
            throw new System.NotImplementedException();
        }

        public void CloseElement<T>() where T : UIElementBase
        {
            throw new System.NotImplementedException();
        }
    }
}