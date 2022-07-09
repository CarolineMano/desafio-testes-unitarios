<h1 align="center">Desafio Testes Unitários</h1> 

<p style="text-align: justify">Implementação de testes unitários dos exercícios realizados na semana de estudos de POO, além da resolução e testes de um exercício retirado da plataforma Dojo Puzzles. Para maiores informações sobre os exercícios realizados anteriormente, consultar o README do repositório: </p>

[Exercícios de POO](https://github.com/CarolineMano/estudo-poo)

---
## :memo: Descrição dos testes 

**<h3>Exercício 01</h3>**

<h3>Veiculo</h3>

- Ao_acelerar_um_veiculo_a_30kmh_a_velocidade_devera_ser_50: teste para verificar se a velocidade do veículo aumenta em 20 Km/h com o método acelerar;
- Ao_abastecer_um_tanque_de_60L_que_possui_10L_de_combustivel_com_mais_20L_total_deve_ser_30: teste para verificar se o abastecimento com valor permitido pelo volume do tanque e pela quantidade já existente é efetuado.
- Ao_abastecer_um_tanque_de_60L_que_possui_10L_de_combustivel_com_mais_60L_total_deve_ser_10: verifica se o método de abastecimento não permite que ele seja feito caso a entrada seja um valor maior do que o comportado pelo tanque.
- Ao_abastecer_um_tanque_de_60L_que_possui_10L_de_combustivel_com_valor_negativo_total_deve_ser_10: verifica se o método de abastecimento não permite valores de combustível negativos.
- Ao_frear_um_veiculo_a_30kmh_a_velocidade_devera_ser_10: verifica se a velocidade do veículo diminui em 20 Km/h com o método frear.
- Ao_frear_um_veiculo_a_30kmh_duas_vezes_a_velocidade_devera_ser_0: confere se não é possível frear ainda mais, para valores negativos, caso o veículo esteja parado.
- Ao_ligar_o_veiculo_desligado_ele_devera_se_encontrar_ligado: verifica se é possível ligar um veículo desligado.
- Ao_ligar_o_veiculo_ligado_ele_devera_se_continuar_ligado: verifica se o veículo permanece ligado ao liga-lo novamente.
- Ao_desligar_o_veiculo_desligado_ele_devera_se_continuar_desligado: verifica se o veículo permanece desligado ao desliga-lo novamente.
- Ao_desligar_o_veiculo_ligado_ele_devera_se_encontrar_desligado: verifica se é possível desligar um veículo ligado.

**<h3>Exercício 02</h3>**

<h3>Livro</h3>

- Imposto_livro_educativo_deve_ser_0: verifica se um livro educativo não tem imposto.
- Imposto_livro_nao_educativo_deve_ser_10_porcento: verifica se qualquer outro tipo de livro tem imposto de 10%.

<h3>Videogame</h3>

- Imposto_videogame_novo_deve_ser_45_porcento: verifica se o imposto de um console novo é igual a 45%.
- Imposto_videogame_usado_deve_ser_25_porcento: verifica se o imposto de um console usado é igual a 25%.

<h3>Loja</h3>

- Dada_loja_com_livros_a_listagem_deve_retornar_true: para uma loja com livros, confirma que existem livros cadastrados na loja.
- Dada_loja_com_videogames_a_listagem_deve_retornar_true: para uma loja com videogames, confirma que existem videogames cadastrados na loja.
- Dada_loja_sem_livros_a_listagem_deve_retornar_false: para uma loja sem livros, confirma que não existem livros cadastrados na loja.
- Dada_loja_sem_videogames_a_listagem_deve_retornar_false: para uma loja sem videogames, confirma que não existem videogames cadastrados na loja.
- Dada_loja_com_um_livro_e_um_videogame_o_patrimonio_deve_ser_1100: para uma loja com produtos cadastrados, confirma que o patrimônio final é o mesmo que a soma dos produtos individuais.
- Dada_loja_sem_produtos_o_patrimonio_deve_ser_0: para uma loja sem estoque, confirma que a loja não possui patrimônio.

**<h3>Exercício 03</h3>**

<h3>Personagem</h3>

- Dado_um_personagem_level_1_subir_de_level_deve_elevar_level_atual_para_2: confirma que o level de um personagem sobe. 
- Dado_um_personagem_level_1_subir_de_level_deve_elevar_vida_atual_para_400: confirma que a vida de um personagem sobe de forma esperada com o aumento de level.
- Dado_um_personagem_level_1_subir_de_level_deve_elevar_mana_atual_para_80: confirma que a mana de um personagem sobe de forma esperada com o aumento de level.
- Dado_um_personagem_level_1_subir_de_level_deve_elevar_xp_atual_para_200: confirma que o xp de um personagem sobe de forma esperada com o aumento de level.
- Dado_um_personagem_level_1_subir_de_level_deve_elevar_inteligencia_atual_para_40: confirma que a inteligência de um personagem sobe de forma esperada com o aumento de level.
- Dado_um_personagem_level_1_subir_de_level_deve_elevar_forca_atual_para_40: confirma que a força de um personagem sobe de forma esperada com o aumento de level.
- Dada_a_criacao_de_um_novo_personagem_de_tipo_guerreiro_a_contagem_de_personagens_deve_ser_18: confirma que a propriedade estática de número de personagens sobe de acordo com a criação de novos personagens, mesmo que eles sejam de classes filhas. Atentar que este método só irá passar no teste caso todos os testes sejam executados, por conta de todas as chamadas realizadas ao construtor. Se apenas os testes da classe PersonagemTests ou apenas este teste for executado, ele irá falhar.

<h3>Guerreiro</h3>

- Dado_um_guerreiro_level_1_subir_de_level_deve_elevar_level_atual_para_2: confirma que o level é subido de acordo com a classe mãe.
- Dado_um_guerreiro_level_1_subir_de_level_deve_elevar_forca_atual_para_90: confirma que a força é aumentada de acordo com as definições da classe mãe e com suas próprias.
- Dado_um_guerreiro_level_1_subir_de_level_deve_elevar_vida_atual_para_600: confirma que a vida é aumentada de acordo com as definições da classe mãe e com suas próprias.
- Dado_um_guerreiro_sem_habilidade_aprender_nova_deve_elevar_a_quantidade_para_1: confirma que aprender uma habilidade aumenta a lista de habilidades em 1.
- Dado_um_guerreiro_sem_habilidade_aprender_habilidade_vazia_deve_manter_a_quantidade_em_0: confirma que aprender uma habilidade vazia não acarreta em aumento da lista de habilidades.

<h3>Mago</h3>

- Dado_um_mago_level_1_subir_de_level_deve_elevar_level_atual_para_2: confirma que o level é subido de acordo com a classe mãe. 
- Dado_um_mago_level_1_subir_de_level_deve_elevar_mana_atual_para_140: confirma que a mana é aumentada de acordo com as definições da classe mãe e com suas próprias.
- Dado_um_mago_level_1_subir_de_level_deve_elevar_inteligencia_atual_para_100: confirma que a mana é aumentada de acordo com as definições da classe mãe e com suas próprias.
- Dado_um_mago_sem_magia_aprender_nova_deve_elevar_a_quantidade_para_1: confirma que aprender uma magina aumenta a lista de magias em 1.
- Dado_um_mago_sem_magia_aprender_magia_vazia_deve_manter_a_quantidade_em_0: confirma que aprender magia vazia não acarreta em aumento da lista de magias.

**<h3>Exercício 07</h3>**

<h3>Funcionário</h3>

- Dado_um_funcionario_a_bonificacao_deve_ser_igual_ao_salario: garante que a bonificação de um funcionário é igual ao salário.

<h3>Vendedor</h3>

- Dado_um_vendedor_cujo_salario_e_2000_a_bonificacao_deve_ser_5000: garante que a bonificação de um vendedor é igual à soma do salário e um valor de 3000. 

<h3>Supervisor</h3>

- Dado_um_supervisor_cujo_salario_e_2000_a_bonificacao_deve_ser_7000: garante que a bonificação de um supervisor é igual à soma do salário e um valor de 5000. 

<h3>Gerente</h3>

- Dado_um_gerente_cujo_salario_e_2000_a_bonificacao_deve_ser_12000: garante que a bonificação de um gerente é igual à soma do salário e um valor de 10000. 

**<h3>Índice de Equilíbrio</h3>**

<h3>Proposta do exercício</h3>

O exercício do índice de equilíbrio pode ser verificado diretamente do site de onde foi retirado: 

[Índice de Equilíbrio](https://dojopuzzles.com/problems/indice-de-equilibrio/)

<h3>Testes</h3>

- Dado_um_vetor_com_indice_de_equilibrio_3_o_resultado_deve_ser_3: confirma que o código resolve o exemplo proposto na descrição do exercício.
- Dado_um_vetor_sem_indice_de_equilibrio_o_resultado_deve_ser_1_negativo: confirma que, caso não haja um índice de equilíbrio, o código retorne o valor -1.
- Dado_um_vetor_com_indice_de_equilibrio_1_o_resultado_deve_ser_1: confirma que um vetor válido diferente do proposto no exercício tenha seu índice de equilíbrio avaliado corretamente.

---
## :loudspeaker: Informações importantes

Para rodar todos os testes, basta navegar até a pasta DesafioTdd.Tests e executar o comando:

> dotnet test

Os testes também podem ser executados individualmente ou por classe, mas o teste Dada_a_criacao_de_um_novo_personagem_de_tipo_guerreiro_a_contagem_de_personagens_deve_ser_18() não irá passar se for executado com alguma fração dos testes.

Por fim, alguns dos métodos dos exercícios entregues anteriormente foram pontualmente modificados para que pudessem ser testados de uma maneira mais eficaz. 

Os métodos ToString() sobrescritos não foram alvo de testes.