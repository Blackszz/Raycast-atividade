# Raycast-atividade
## Igor Cafazzi e Guilherme Santos

## Script "Mover"

![mover](https://github.com/user-attachments/assets/d1f5c345-6698-415e-b05b-3cba55ccc9e9)


Esse é o script de movimentação do cubo, nós usamos o método fisico LinearVelocity, ele move o Rigidbody do objeto em uma direçêo de sua escolha, e nós escolhemos o eixo X (direita e esquerda).
A variavel cubo representa o Rigidbody do nosso objeto que será movido, e a variavel velocidade representa a velocidade que o nosso objeto irá se mover.
por fim no update setamos a LinearVelocity do nosso objeto como direita, multiplicamos pelo input do eixo horizontal, assim fazendo o objeto só se mover quando apertarmos as teclas A, D, Seta Direita e Seta Esquerda e depois multiplicamos pela velocidade escolhida.

## Script "raycast"

![raycst](https://github.com/user-attachments/assets/81d71356-14ce-44a9-b383-68a1b26d853a)

Esse é o script do Raycast. Nós criamos variaveis para o Ray (raio), para o Raycasthit (hit) e para a Camera (tela).
No update criamos o Ray onde que quando clicamos com o botão esquerdo do mouse ele atira, o ponto inicial dele é o meio da camera, e o final é onde o clique do mouse acertar.
Por fim criamos a função hitou, que pega o Gameobject atingido usando o hit, e transformamos em uma variavel, para depois destrui-lo.

## Script "patrulha"

![moveresfera](https://github.com/user-attachments/assets/86956393-75fb-4647-9005-035800953eeb)

Esse script serve para a esfera fazer uma patrulha em 2 pontos.



# Video da execução


https://github.com/user-attachments/assets/a193b088-c8f1-4e79-88b7-e08d642fbfc3

