## Sobre o projeto

Um cliente tem necessidade de buscar livros em um catálogo. Esse cliente quer ler e buscar esse catálogo de um arquivo JSON, e esse arquivo não pode ser modificado. Então com essa informação, é preciso desenvolver:

- Criar uma API simples para buscar produtos no arquivo JSON disponibilizado.
- Que seja possivel buscar livros por suas especificações(autor, nome do livro ou outro atributo)
- É preciso que o resultado possa ser ordenado pelo preço.(asc e desc)
- Disponibilizar um método que calcule o valor do frete em 20% o valor do livro.

Será avaliado no desafio:

- Organização de código;
- Manutenibilidade;
- Princípios de orientação à objetos;
- Padrões de projeto;
- Teste unitário
- Conhecimento em controle de versão;

Para nos enviar o código, crie um fork desse repositório e quando finalizar, mande um pull-request para nós.
O projeto deve ser desenvolvido em C#, utilizando o .NET Core 2.2 ou superior.
Gostaríamos que fosse evitado a utilização de frameworks, e que tivesse uma explicação do que é necessário para funcionar o projeto e os testes.

## Declarações iniciais

Projeto feito usando exclusivamente a linguagem C#.
Resolvi não usar o XUnit para sair da zona de conforto.
Fiz os testes no mesmo projeto para evitar duplicação desnecessaria de codigo.
Todos os arquivos de test estão na pasta Test.

A arquitetura do projeto esta muito simples, sem o uso de DTOS, UnitOfWorks, DDD e por aí vai.

Fluxograma da API:
A requisição chega no BooksController que destina para o metodo Get de acordo com o requerimento, aciona os metodos que estão no caminho Repositories.SearchBooksRepository.
Os metodos do arquivo SearchBooksRepository fazem uma busca linq no arquivo Json já desserializado pelo metodo estatico LoadAllJson que esta na pasta raiz.ManageJson e retorna para controller com resultado da busca, o ActionResult faz Ok-200 e a serialização do arquivo Json ou null acionando assim o BadRequest 404.

Fluxograma do Teste:
A requisição chega no TestConstroller que faz a requisição em cadeia das classes que por sua vez fazem o acionamento em cadeia dos metodos testes, retornão para o Get da controller que concatena os resultados e retorna um Json com todos os testes.

## Instruções de uso

Solução: BackendTest/ApiGetBooks/ApiGetBooks.sln

Para os teste da API e os testes unitarios não necessario o Debug. Bastando assim


# Endpoints


## GET /Books/  

|  /Books/ | Ação  | Exemplo  |
|:---|:---|:---|
|  / |  Mostra todos os registros ordenados por id | /
|  /ascending |  Mostra todos os registros ordenados por preço ascendente. |/ascending
|  /descending |  Mostra todos os registros ordenados por preço desendente. |/descending
|  /id/numero |  Mostra o livro do id informado |  /id/1
|  /name/nome do livro |  Mostra os livros pesquisados por nome e ordenados pelo id | /name/leagues
|  /name/nome do livro/ascending |  Mostra os livros pesquisados por nome ordenados por preço ascendente | /name/l/ascending
|  /name/nome do livro/descending |  Mostra os livros pesquisados por nome ordenados por preço descendente| /name/l/descending
|  /price/numero |  Mostra o registro do livro com o preço informado | /price/11.15
|  /originally_published/nome | Mostra os livros pesquisados por data de publicação e ordenados pelo id | originally_published/November
|  /originally_published/nome/ascending | Mostra os livros pesquisados por data de publicação e ordenados por preço ascendente  | originally_published/November/ascending
|  /originally_published/nome/descending | Mostra os livros pesquisados por data de publicação e ordenados por preço descendente | originally_published/November/descending
|  /author/nome | Mostra os livros pesquisados por autor e ordenados pelo id | author/j
|  /author/nome/ascending | Mostra os livros pesquisados por autor e ordenados por preço ascendente  | author/j/ascending
|  /author/nome/descending | Mostra os livros pesquisados por autor e ordenados por preço descendente | author/j/descending
|  /page_count/numero | Mostra os livros pesquisados por numero de pagina e ordenados pelo id | page_count/715
|  /page_count/numero/ascending | Mostra os livros pesquisados por numero de pagina e ordenados por preço ascendente  | page_count/715/ascending
|  /page_count/numeor/descending | Mostra os livros pesquisados por numero de pagina e ordenados por preço descendente | page_count/715/descending
|  /illustrator/nome | Mostra os livros pesquisados por ilustrador e ordenados pelo id | illustrator/r
|  /illustrator/nome/ascending | Mostra os livros pesquisados por ilustrador e ordenados por preço ascendente  | illustrator/r/ascending
|  /illustrator/nome/descending | Mostra os livros pesquisados por ilustrador e ordenados por preço descendente | illustrator/r/descending
|  /genres/nome | Mostra os livros pesquisados por genero e ordenados pelo id | genres/r
|  /genres/nome/ascending | Mostra os livros pesquisados por genero e ordenados por preço ascendente  | genres/r/ascending
|  /genres/nome/descending | Mostra os livros pesquisados por genero e ordenados por preço descendente | genres/r/descending
|  /shipping/id | Mostra o valor do frete em 20% do valor do livro pesquisado | shipping/1

## GET /Test/  

|  /Test/ | Ação  | Exemplo  |
|:---|:---|:---|
|  / |  Mostra o teste de todas as classes e metodos as aplicação| /