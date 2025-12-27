# Phnom Penh Heritage Quest

A 2D cultural exploration game where players travel through locations in Phnom Penh, interact with environments, learn about Khmer food and culture, and complete quizzes to become a Cultural Master.

---

## Game Overview
- Title: Phnom Penh Heritage Quest
- Genre: 2D Educational / Exploration
- Target Audience: Students and cultural explorers
- Goal: Educate players about Khmer culture , through exploration and quizzes.

---

## Story & Setting
The game is set in a stylized 2D map representing different cultural locations in Phnom penh, such as restaurants, museum, and royal palace.
Each location introduces players to aspects of Khmer culture through interactive objects and NPC explanations.

Players explore each location, learn key information, and complete quizzes to unlock progress.

---

## Core Gameplay

### Player Abilities
- Navigate a 2D environment using horizontal scrolling
- Click on interactive objects to learn information
- Zoom in and out to explore details
- Read educational dialogue from NPC panels
- Complete quizzes after learning all required items

### Interactive Objects
- Traditional Khmer dishes placed in the restaurant environment
- Temples, and Khmer musical instruments in the museum environment
- Important building, sculpture, and informations in the royal palace environment.
- Each object displays a numbered indicator
- When clicked:
  - An NPC panel appears with information
  - The number changes into a green tick to mark progress
- Learned objects can be clicked again to review information

### NPC Behavior
- NPC appears as a UI panel
- NPC explains object-related knowledge
- Camera movement is disabled while the NPC panel is open
- NPC panel closes on user input

---

## Win & Lose Conditions

### Win Conditions
- Complete quizzes in all locations
- Earn at least 80% score in each quiz
- Collect all three location badges

### Lose Conditions
- Failing the quiz (player can retry)

---

## Gameplay Flow
1. Player selects a location from the map
2. Enters an interior scene (for example, a restaurant)
3. Explores the room by scrolling left and right
4. Clicks on dishes to learn food-related information
5. Completes all interactions (all ticks collected)
6. Takes a quiz related to the learned content

---

## Art Direction
- Style: 2D stylized illustration
- Perspective: Side-view
- Visual Theme: Warm colors inspired by Khmer culture
- Assets Include:
  - Traditional Khmer dishes
  - All location furniture and decorations
  - Khmer temple images
  - Khmer musical instruemnts
  - Building in royal palace
  - Player character
  - UI icons (numbers, ticks)
  - UI buttons
  - Scene backgrounds and map icons

---

## Audio
Music:
- Calm background music for exploration
- Subtle cultural ambience
- Location-based background music that math with the mood

Sound Effects:
- Click interaction sounds

---

## Technical Requirements
- Engine: Unity 2D
- Platform: macOS (Apple Silicon)
- Controls:
  - Scroll Left/Right: Mouse drag or Arrow keys
  - Zoom In/Out: Mouse wheel or Arrow keys
  - Interact: Mouse click

### Key Scripts
- HorizontalRoomScroll: Handles left/right camera movement
- CameraZoom2D: Controls zoom in and out
- DishInteractable: Manages obbject interaction and learning state
- NPCController: Controls NPC UI panel and dialogue
- QuizManager: Handles quiz logic and results

---

## Scope

### Scenes
- Start Scene
- Map Scene
- Interior Locations
- Quiz Scene
- Result Scene

### Mechanics
- Location-based learning
- Object interaction
- NPC dialogue system
- Progress tracking with ticks
- Quiz-based assessment

### Assets
- Custom 2D assets
- Free UI and educational assets
- Simple animations and transitions

---

## Course Information
- Course: Game Development
- Institute: Cambodia Academy of Digital Technology
- Lecturer: Dr. VA Hongly

---

## Team Members
- CHUM Chanlinna
- IN Chanaliza
