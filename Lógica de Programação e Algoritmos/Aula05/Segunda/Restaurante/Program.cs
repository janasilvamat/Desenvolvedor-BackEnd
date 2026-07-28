async Task Principal()
{
    Console.WriteLine("Pedido anotado");
      await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkShake());    
    Console.WriteLine("Pedido entregue");

}

async Task PrepararHamburguer()
{
    Console.WriteLine("Preparando o hambúrguer...");
    await Task.Delay(3000);
    Console.WriteLine("Hambúrguer pronto!");
}

async Task PrepararBatata()
{
    Console.WriteLine("Preparando batata frita...");
    await Task.Delay(2500);
    Console.WriteLine("Batata Frita pronta!");
}

async Task PrepararMilkShake()
{
    Console.WriteLine("Preparando Milk Shake...");
    await Task.Delay(4000);
    Console.WriteLine("Milk Shake pronto!");
}
await Principal();

//task é usada para representar uma operação assíncrona que pode ser aguardada. O método Principal é assíncrono e aguarda a conclusão de várias tarefas (PrepararHamburguer, PrepararBatata e PrepararMilkShake) usando Task.WhenAll. Cada uma dessas tarefas simula a preparação de um item do pedido com um atraso específico usando Task.Delay.