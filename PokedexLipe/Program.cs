
//1 - salvar imagem

var url = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/";
var path = @"C:\Users\fpont\OneDrive\Área de Trabalho\Felipe\Pokemons\";
HttpClient HttpClient = new HttpClient();

for (int i = 1; i <= 999; i++)
{

    await SalvarImg(i);
}

async Task SalvarImg(int numero)
{
    var idPokemon = numero.ToString().PadLeft(3, '0');
    var fullUrl = url + idPokemon + ".png";
    var response = await HttpClient.GetAsync(fullUrl);
    using (var fs = new FileStream(path + idPokemon + ".png", FileMode.CreateNew))
    {
        var result = response.Content.CopyToAsync(fs);
        result.Wait();
    }

}