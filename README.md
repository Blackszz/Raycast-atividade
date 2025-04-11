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

Esse script serve para a esfera fazer uma patrulha em 2 pontos. Criamos variáveis para controlar a velocidade, dizer os pontos de patrulha e dar a posição inicial do objeto que queremos mover. O código envia o objeto para se mover até um certo ponto e quando ele chega nesse ponto, começa a se mover para o outro e assim vai fazendo infinitamente (até ser detruído pelo raycast). As últimas linhas de código são para fazer o objeto rotacionar de maneira suave após ter chegado em um dos pontos e for se mover para o outro. Após fazer o script, colocamos duas esferas no mapa para ser os pontos em que o objeto principal irá se mover. Arrastamos essas esferas até o inspetor do nosso script para localizar os pontos que o objeto principal deve ir e então a patrulha ficou pronta.



# Video da execução


https://github.com/user-attachments/assets/a193b088-c8f1-4e79-88b7-e08d642fbfc3

# Drive da cena

https://drive.google.com/drive/folders/1DgMLIzvemRGjUv-B9ucM-6s8lamMf377?usp=drive_link


