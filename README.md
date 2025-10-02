# 🔢 Projeto MDC
> Projeto desenvolvido em **C# com Visual Studio 2022**, focado em estudos e prática de programação.  

---

## 📖 Sobre o projeto  
Eu usei o SelectedIndexChanged de dois componentes principais: No ComboBox do Universo (CBUNI), é possível selecionar uma das duas opções de universos (Marvel ou DC), e também quando selecionada novamente, limpa as opções e os dados anteriores. No ComboBox de Personagens (CBPERSONAGEM), o evento é responsável por carregar a imagem e o texto de descrição do personagem selecionado, apenas com os heróis do universo escolhido, usando o método Items.Add().

Uma técnica que me desafiou e ensinou muito foi a de carregar as imagens de forma dinâmica. Usei o método Directory.GetFiles do C# para percorrer todos os arquivos em uma pasta específica.

Para garantir que a imagem correta fosse carregada, precisei manipular as strings (os caminhos completos dos arquivos). Usei o método Split('\\') para separar o caminho por barras e isolar o nome do arquivo, e depois Split('.') para remover a extensão e obter o nome do personagem, garantindo que ele coincidisse com a opção selecionada no ComboBox.

Usei o componente PictureBox para exibir a imagem, definindo sua propriedade ImageLocation e o SizeMode como StretchImage. A descrição do personagem foi exibida em um Label (lblcharacter).

Foi fundamental usar a estrutura if para gerenciar a lógica de qual descrição e qual imagem carregar para cada personagem. O foreach foi essencial para iterar sobre a lista de arquivos de imagem e encontrar a correta.

---

## 🚀 Tecnologias utilizadas  
- **C#**  
- **.NET**  
- **Visual Studio 2022**  
- **Git & GitHub**  

---

## 📂 Estrutura do repositório  
- `ProjectMDC.sln` → arquivo da solução do Visual Studio  
- `ProjectMDC/` → pasta com os arquivos do projeto (código-fonte)  
- `.gitignore` → define arquivos/pastas ignorados pelo Git  

---

## ▶️ Como executar o projeto  
1. Clone este repositório:  
   ```bash
   git clone https://github.com/carlos7nas/Projeto-MDC.git
2. Abra o arquivo ProjectMDC.sln no Visual Studio 2022
3. Compile o projeto (Ctrl + Shift + B)
4. Execute (F5)

✨ Autor
👤 Carlos Vitor
🔗 [GitHub](https://github.com/carlos7nas)
🔗 [LinkedIn] (https://www.linkedin.com/in/carlosvitordonascimento)
