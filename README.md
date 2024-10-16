Atividade: Usando o conceito de Clean Architectur, para fazer um projeto de catalogo de produtos e categorias, em um formato Web.

Escopo geral: 
- Criar um projeto WEB para trata com produtos e categorias que podem ser usados par criar
catalogo de produtos e vendas;
- Aplicação ASP.NetCore MVC;
- Definir no projeto as funcionalidades: CRUD;
- Definir o modelo de dominio usando classes e com propriedades e coportamentos: Product e Catergory;
- Definir qual arquitetura a ser usada: Clean Architecture;
- Definir os padroes que iremos implementar: MVC, Repository e CQRS;
-Relacionamento: um para muitos.

Persistencia dos dados usado:
- SQL server;
- ORM: EF (code-first);
- Provedor do BD: microsoft.entityframeworkCore.sqlserver;
- migrations: microsoft.entityframeworkcore.tools;
- Desacoplar a camada de acesso a dados do ORM: Padrao repository.

Estrutura: Clean Architecture: Regra de dependencia;

Criação de uma solução e 5 projetos separados em camadas com responsabilidades definidas:
- CleanArchMvc:
	- CleanArchMvc.Domain: Modelo de dominio, regras de negocio, interfaces;
	- CleanArchMvc.Application: Regras de dominio da aplicação, mapeamentos, serviços, DTOs e CQRS;
	- CleanArchMvc.infra.Data: EF Core, Contexto, Configurações, Migrations, Repository
	- CleanArchMvc.infra.IoC: Dependency Injection, registro dos serviços, tempo de vida;
	- CleanArchMvc.WebUI: MVC, Controllers, Views, Filtros, ViewModels;
   
"Os projetos, não sendo WebUI, são do tipo Class Libraty (.net 5.0)"

Relacionamento e dependencia entre os projetos;
- CleanArchMvc.Domain: não possui nenhuma dependencia
- CleanArchMvc.Application: dependencia com o projeto: domain
- CleanArchMvc.infra.Data: dependencia com o projeto: domain
- CleanArchMvc.infra.IoC: dependencia com os projetos domain, aplication, infra.data
- CleanArchMvc.WebUI: dependencia com o projeto: infra.Ioc
