# Smarthealth API 0.0.1

- Está implementado o InMemoryDataBase, então para efetuar os testes basta fazer o clone/download do projeto e iniciar a aplicação com a variável de ambiente Development;
- Dentro da pasta Files contém o arquivo .json com toda documentação da API para ser importada para o Postman (https://www.postman.com/) e pronta para utilização, também há uma documentação da API funcionando.
- O projeto está feito com .net6 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

TODOS:
- [ ] Implementar o JWT Token;
- [ ] Implementar o UnitOfWork;
- [ ] Implementar o Middleare de padronização de APIs;
- [ ] Implementar autenticação, autorização e polices de segurança;
- [ ] Implementar o MiniValidator da MinimalAPI para validações dos objetos de DTO;
- [ ] Implementar o AsNoTracking no método Find do RepositoryBase com TPrimaryKey genérica para o EF não dar lock na entidade de pesquisa;
- [ ] Implementar as classes de excessão da camada de Application e Data;
- [ ] Implementar a validação e notificação das classes de Domínio;