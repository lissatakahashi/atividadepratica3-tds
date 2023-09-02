# Atividade Prática 3: Feedback de Clientes Com Razor Pages e Persistência
Esta é atividade prática 3 da disciplina de Tecnologia em Desenvolvimento de Sistemas. O tema é "Gestão de Feedbacks de Clientes com Minimal API e ASP.NET Razor Pages".

## Descrição da atividade:

Desenvolva uma aplicação WEB utilizando a Minimal API do .NET Core que permita o gerenciamento de feedbacks deixados por clientes sobre um serviço ou produto específico. A aplicação deve permitir o cadastro, consulta, atualização e exclusão de feedbacks, integrando-se com ASP.NET Razor Pages. Utilize uma coleção em memória para armazenar os dados temporariamente.

Cada feedback deve ter as seguintes propriedades:

- IdFeedback: inteiro;
- NomeCliente: string;
- EmailCliente: string (opcional);
- DataFeedback: DateTime;
- Comentário: string;
- Avaliação: inteiro (uma escala de 1 a 5, onde 1 é "Muito insatisfeito" e 5 é "Muito satisfeito").

A aplicação deve permitir que os usuários insiram seus feedbacks através de um formulário simples. Além disso, deve ser possível visualizar todos os feedbacks em uma lista, bem como editar ou excluir um feedback específico.

 
