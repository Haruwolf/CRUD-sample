public class Program
{
public static void Main()
{
    /// <summary>
    /// Aqui serviço vem de uma interface chamada IService, Locadora é um serviço desse tipo, se eu quiser posso implementar outro tipo de serviço que irá funcionar.
    /// </summary>
    IService service = new Locadora();

    /// <summary>
    /// A ideia aqui é a mesma, o produto pode ser qualquer coisa que implemente IProduto
    /// </summary>
    IProduto produto = new Game("Zelda Majora's", 1);

    /// <summary>
    /// Essa é a parte mais importante, criamos um controlador para que a dependencia possa ser injetada, no construtor, passamos a sua dependencia.
    /// </summary>
    ServiceController controller = new ServiceController(service);

    /// <summary>
    /// Aqui temos a mesma ideia, um controlador para que a dependência necessária seja injetada, e assim controlar as funções de sua dependência.
    /// </summary>
    ProductController productController = new ProductController(produto);

    /// <summary>
    /// Usando o controlador, o qual passamos o serviço que é necessário, adicionamos o produto em uma lista.
    /// </summary>
    controller.service.Add(productController._produto);

    /// <summary>
    /// Recupera toda a lista do controlador.
    /// </summary>
    controller.service.GetAll();

    
}

}