# Cadastro de Usuário — .NET MAUI (C#)

![.NET](https://img.shields.io/badge/.NET%20MAUI-8A2BE2?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

---

## Descrição
Aplicação simples para **cadastrar usuários** com os campos:  
- **Nome completo**  
- **Data de nascimento**  
- **Gênero**  
- **Idade**  

> O objetivo é servir como **base reutilizável**: você pode replicar a lógica/estrutura para qualquer outro aplicativo.

Desenvolvido com **.NET MAUI (C#)** na **IDE Visual Studio 2022+** com a versão **9.0 da linguagem C#**.  

---

## Principais recursos
- Formulário com campos essenciais de cadastro  
- Validação básica (campos obrigatórios e formatos)  
- Arquitetura organizada (Views / Models / ViewModels – MVVM)  
- Projeto .NET MAUI em **C# (versão 9.0)**  

---

## Pré-requisitos
- **Windows 10/11**  
- **Visual Studio** com a carga de trabalho **“.NET Multi-platform App UI development (MAUI)”**  
  - Inclui Android SDKs e Emulador Android  
- **.NET SDK** compatível com MAUI já instalado (o instalador do VS cuida disso)  
- (Opcional) **Dispositivo Android** com modo desenvolvedor ou emulador configurado  
- (Opcional – macOS) Para compilar iOS/MacCatalyst, é necessário ambiente Apple


> dotnet workload install maui
 
---
 
## Como obter o projeto
### Opção 1 — Git (recomendado)
- git clone https://github.com/seu-usuario/seu-repo.git
- cd seu-repo
 
 
### Opção 2 — Download
- Baixe o .zip do repositório
- Extraia em uma pasta local
- Abra o .sln no Visual Studio
 
---
 
## Executando o app
- Abra a solução no Visual Studio
- Selecione o destino:
- Android Emulator
- Windows Machine (WinUI 3), se o projeto tiver alvo Windows
- Dispositivo físico Android
- Clique em Run/Play (F5)
 
---
 
## Como usar
- Preencha os campos (nome, data de nascimento, gênero e idade)
- Clique em Salvar
- Veja a confirmação ou mensagens de erro
 
---
 
## Validações implementadas (sugestão)
- Nome completo: obrigatório
- Data de nascimento: formato válido e não no futuro
- Gênero: precisa estar selecionado
- Idade: numérica (> 0) — ou calculada automaticamente
 
---
 
## Reutilizando em outros projetos
- Copie Models, ViewModels e a tela de cadastro
- Ajuste o namespace
- Adapte regras no Usuario.cs e MainViewModel.cs
- Estilize pelo App.xaml
 
---
 
## Solução de problemas
- “No devices/emulators found” → configure no Android Device Manager
- Workload/SDK → rode dotnet workload restore
- Build lento → limpe/Rebuild a solução
- Falha USB → ative depuração no dispositivo
 
---
 
## Roadmap
- Persistência local (SQLite/Preferences)
- Cálculo automático da idade
- Internacionalização (pt-BR, en-US)
- Testes unitários
 
---
 
## Contribuindo
- Fork
- Branch: feat/sua-melhoria
- Commit
- Pull Request
 
---
 
📜 **Licença**
- Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
 
---
**Autoria**
- Projeto desenvolvido no Senac Lapa Tito sob direção da docente Fernanda Nalon para a turma TDS03.
