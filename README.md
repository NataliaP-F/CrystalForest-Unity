# 🌲 Crystal Forest

**Crystal Forest** é um jogo 2D desenvolvido na Unity, onde o jogador explora um ambiente de plataforma enquanto evita inimigos e armadilhas perigosas como o Goblin (inimigo estático que causa dano ao contato).

---

## 🎮 Sobre o Jogo

O objetivo do jogo é explorar o cenário com cuidado, evitando obstáculos e inimigos presentes no mapa. O jogador deve sobreviver aos perigos enquanto se movimenta pelo ambiente.

Atualmente o jogo conta com:
- Sistema de movimentação do jogador
- Sistema de vida e dano
- Inimigo estático (Goblin) que causa dano ao contato
- Cenário com plataformas e level design básico

---

## ⚙️ Mecânicas

- 🧍 **Movimentação do jogador**
- ❤️ **Sistema de vida**
- 💥 **Dano ao encostar em inimigos**
- 👾 **Inimigo estático (tipo armadilha)**
- 🌍 **Exploração de cenário 2D**

---

## 🎮 Controles

- **A / D** → Movimentar para esquerda/direita  
- **W / Espaço** → Pular  
- **Encostar no inimigo** → Recebe dano  

---

## 🧠 Como o sistema funciona

- O jogador possui um sistema de vida (`PlayerHealth`)
- O inimigo (Goblin) usa um `Collider2D` com **Is Trigger**
- Ao encostar no jogador, o sistema detecta o contato e aplica dano
- O Goblin e os espinhos funcionam como armadilhas estáticas (sem IA ou movimento)

---

## ▶️ Como executar o projeto

1. Clone o repositório:
```bash
git clone https://github.com/NataliaP-F/CrystalForest-Unity.git
