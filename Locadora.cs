public class Locadora : IService
{
    List<IProduto> produtos = new();

    public IProduto Add(IProduto newGame)
    {
        produtos.Add(newGame);
        return newGame;
    }

    public IProduto Delete(int id)
    {
        IProduto? deletedProduct;
        foreach(var n in produtos)
        {
            if (n.GetID() == id)
            {
                deletedProduct = n;
                produtos.Remove(n);
                return deletedProduct;
            }        
        }
        throw new Exception("Produto não encontrado");
    }

    public IEnumerable<IProduto> GetAll()
    {
        IEnumerable<IProduto> gameList = produtos;
        foreach (var g in gameList)
        {
            Console.WriteLine(g.GetGameName());
        }
        return gameList;
    }

    public IProduto Update(IProduto produto)
    {
        IProduto? prod;
        foreach(var n in produtos)
        {
            if (n.GetID() == produto.GetID())
            {
                produtos[produtos.IndexOf(n)] = produto;
                prod = produto;
                return prod;
            }
                
        }
        throw new Exception("Produto não encontrado");
    }
}