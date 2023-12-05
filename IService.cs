public interface IService
{
    public IEnumerable<IProduto> GetAll();
    public IProduto Add(IProduto novoProduto);
    public IProduto Update (IProduto novoProduto);
    public IProduto Delete (int id);
}