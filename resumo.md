```markdown
# Comandos do .NET no Terminal

Aqui estão alguns dos principais comandos do .NET que podem ser utilizados no terminal para desenvolvimento, compilação e execução de aplicativos.

## 1. dotnet new

Cria um novo projeto com base em um modelo específico.
Para especificar uma pasta -o e o nome do proejto
```bash
dotnet new <TEMPLATE>
```

Exemplo:
```bash
dotnet new console -n MeuAppConsole
```

## 2. dotnet restore

Restaura as dependências do projeto.

```bash
dotnet restore
```

## 3. dotnet build

Compila o projeto.

```bash
dotnet build
```

## 4. dotnet run

Executa o aplicativo.

```bash
dotnet run
```

## 5. dotnet test

Executa os testes no projeto.

```bash
dotnet test
```

## 6. dotnet publish

Publica o aplicativo para distribuição.

```bash
dotnet publish -c Release
```

## 7. dotnet add

Adiciona uma referência ao projeto.

```bash
dotnet add reference <CaminhoParaAssembly>
```

## 8. dotnet ef

Fornece ferramentas para Entity Framework Core.

```bash
dotnet ef migrations add <NOME_DA_MIGRACAO>
```

## 9. dotnet pack

Empacota o projeto em um formato NuGet.

```bash
dotnet pack
```

## 10. dotnet watch

Observa as alterações no código e reinicia automaticamente o aplicativo.

```bash
dotnet watch run
```

## 11. dotnet clean

Remove os arquivos gerados durante a compilação.

```bash
dotnet clean
```

---

Esse é um resumo rápido dos comandos mais comuns do .NET no terminal. Consulte a documentação oficial do .NET para obter informações mais detalhadas sobre cada comando: [Documentação do .NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/).
```

Lembre-se de adaptar os comandos de acordo com suas necessidades específicas e consulte a documentação oficial do .NET para obter informações mais detalhadas sobre cada comando.