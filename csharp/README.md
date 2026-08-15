# Estudos de C#

Esta pasta reúne atividades introdutórias, oito listas de exercícios e projetos práticos. Os arquivos foram preservados como soluções independentes e receberam nomes padronizados para facilitar a navegação.

## Trilhas de conteúdo

| Seção | Conteúdo principal | Exercícios |
| --- | --- | ---: |
| `atividades-iniciais` | Sintaxe, operadores, entrada e saída, condicionais e laços | 36 |
| `lista-01` | Fundamentos, variáveis e cálculos | 13 |
| `lista-02` | Estruturas condicionais e `switch` | 15 |
| `lista-03` | Estruturas de repetição | 10 |
| `lista-04` | Repetições, validações e problemas aplicados | 8 |
| `lista-05` | Vetores e operações com conjuntos de dados | 10 |
| `lista-06` | Matrizes e processamento bidimensional | 9 |
| `lista-07` | Métodos, parâmetros, vetores e matrizes | 13 |
| `lista-08` | Strings, processamento de texto e CSV | 11 |
| `projetos/jogo-do-rato` | Labirinto aleatório, busca em largura e movimentação no console | 1 projeto |

## Projetos práticos

### Jogo do Rato

O arquivo [`JogoDoRato.cs`](projetos/jogo-do-rato/JogoDoRato.cs) gera um labirinto aleatório, valida se existe um caminho entre a entrada e a saída e acompanha a movimentação de um rato pelo cenário no console.

## Como executar um exercício

Cada arquivo contém um programa separado. Para testar um exercício sem misturar as classes e os métodos `Main` dos demais arquivos:

1. crie um projeto de console com `dotnet new console`;
2. substitua o conteúdo do `Program.cs` pelo código do exercício escolhido;
3. execute o projeto com `dotnet run`.

> O arquivo de projeto mantido nesta pasta pertence ao histórico de estudos. Como há vários programas independentes no mesmo diretório, eles não foram projetados para compilação conjunta.
