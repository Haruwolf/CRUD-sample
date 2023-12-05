public class Game : IProduto
{
    public string _productName {get; private set;}
    public int _productID {get; private set;}

    public Game (string gameName, int gID)
    {
        _productName = gameName;
        _productID = gID;
    }

    public string GetGameName()
    {
        return _productName;
    }

    public int GetID()
    {
        return _productID;
    }

//Arrumar isso aqui, deixar pra retornar como propriedade

}