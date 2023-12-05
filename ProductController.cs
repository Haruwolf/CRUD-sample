public class ProductController
{
    public IProduto _produto {get; private set;}

    public ProductController (IProduto produto)
    {
        _produto = produto;
    }
}