# 🎯 Number Guessing Game (C# CLI)

A command-line number guessing game built in C# as part of the roadmap.sh backend projects.

---

## 📌 Project Overview

This is a simple CLI-based game where the computer randomly selects a number between **1 and 100**, and the player must guess it within a limited number of attempts.

The number of attempts depends on the selected difficulty level.

---

## 🚀 Features

- 🎲 Random number generation (1–100)
- 🎚 Difficulty levels:
  - Easy → 10 attempts
  - Medium → 5 attempts
  - Hard → 3 attempts
- 🔁 Input validation using `int.TryParse`
- 📉 Feedback after each guess:
  - Too high
  - Too low
- 🏁 Game ends when:
  - Player guesses correctly
  - Player runs out of attempts
- 🧮 Displays number of attempts taken to win

---

## 🛠 Tech Stack

- Language: C#
- Runtime: .NET (Console Application)

---

## ▶️ How to Run

```bash
git clone https://github.com/marin-mohanadas/number-guessing-game.git
cd number-guessing-game
dotnet run
```

---

## 🎮 How to Play

1. Start the game
2. Choose a difficulty level:
   - 1 → Easy (10 attempts)
   - 2 → Medium (5 attempts)
   - 3 → Hard (3 attempts)
3. Enter your guesses
4. After each guess, you will be told:
   - If your guess is too high
   - If your guess is too low
5. Win by guessing correctly before running out of attempts

---

## 📚 Requirements (roadmap.sh)

This project follows the official requirements from:
https://roadmap.sh/projects/number-guessing-game

---

## 🔧 Future Improvements

- 🔁 Replay option (play again)
- ⏱ Timer system
- 🧠 Hint system
- 🏆 High score tracking

---

## 👨‍💻 Author

- GitHub: https://github.com/marin-mohanadas

---

## 📄 License

This project is open source under the MIT License.
