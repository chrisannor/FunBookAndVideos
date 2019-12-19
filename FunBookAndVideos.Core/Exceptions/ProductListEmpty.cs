namespace FunBookAndVideos.Core.Exceptions
{
    public class ProductListEmpty : FunBookAndVideosException
    {
        public ProductListEmpty() : base(ErrorCode.EmptyProductList, "Product list is empty")
        {
        }
    }
}
