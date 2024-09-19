Este é um jogo de Pedra, Papel e Tesoura implementado em C#. Vou explicar como ele funciona e fornecer instruções para jogar:

Objetivo do jogo:
Você jogará contra o computador, escolhendo entre pedra, papel ou tesoura. O computador também fará sua escolha aleatoriamente. O jogo seguirá estas regras:

Pedra ganha de tesoura (pedra esmaga tesoura)
Tesoura ganha de papel (tesoura corta papel)
Papel ganha de pedra (papel embrulha pedra)
Se ambos escolherem a mesma opção, o resultado será um empate.
Instruções:
O jogo começa com a mensagem:
"Escolha: pedra, papel ou tesoura (ou 'sair' para encerrar):"

Digite sua escolha (pedra, papel ou tesoura) e pressione Enter.

O computador fará sua escolha aleatoriamente, e o programa exibirá a escolha do computador, por exemplo:
"Computador escolheu: tesoura"

O resultado será calculado:

Se você e o computador escolherem a mesma opção, a mensagem será: "Empate!"
Se você vencer, a mensagem será: "Você venceu!"
Se o computador vencer, a mensagem será: "Você perdeu!"
Após o resultado, o jogo continua para a próxima rodada. Caso deseje parar, digite 'sair' para finalizar o jogo.

Quando você digitar "sair", o jogo exibirá a mensagem:
"Obrigado por jogar!"
e será encerrado.

Como o código funciona:
O jogo utiliza um laço while (true) para continuar indefinidamente até que o jogador digite "sair".
A função Random() gera uma escolha aleatória para o computador.
O código verifica o resultado da partida comparando as escolhas do jogador e do computador e exibe o resultado correspondente.
Basta rodar o código e seguir as instruções que aparecerão no console.