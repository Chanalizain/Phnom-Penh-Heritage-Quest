# Phnom Penh Heritage Quest

A 2D cultural exploration game where players travel through locations in Phnom Penh, interact with environments, learn about Khmer culture, and complete quizzes to earn the title of Cultural Master.

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
1. The player will first see the start scene, where a play button appears
2. After the play button is clicked, the map of phnom penh city from the sky view will be shows
3. Player selects a location to explore
4. Then they will enter an interior learning scene (Royal Palace, National Museum, or Tranditional Khmer Restaurant)
5. Explores the area with side scrolling and zoom in and out abilities 
6. Clicks on interacable object with the number indicator icon on top to learn from the npm dialouge 
7. They can either interact with all interactable objects (all number indicators change to tick icons)
8. Or take the quiz directly

---

## Art Direction
- Style: 2D stylized illustration
- Perspective: 
  - Sky view for the map
  - Side view for the interior learning area
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
- Location-based background music that match with the mood

Sound Effects:
- Click interaction sounds

---

## Technical Requirements
- Engine: Unity 2D
- Platform: macOS (Apple Silicon)
- Controls:
  - Side Scrolling: Mouse drag or Arrow keys
  - Zoom In/Out: Mouse wheel or Arrow keys
  - Interact: Mouse click

### Key Scripts
- QuizManager: Handles the dynamic injection of questions and processes user answers during the assessment phase.
- Win Script: The core logic for progression. It enforces the "80% Game Rule" and utilizes PlayerPrefs to permanently save badge data (0 or 1) once the passing threshold is met.
- HorizontalRoomScroll: Manages the camera's X-axis movement to allow for smooth exploration of the 2D landmark environments.
- CameraZoom2D: Controls the orthographic size of the camera, enabling players to zoom in on cultural artifacts for closer inspection.
- DishInteractable: Manages individual object states. It tracks player interaction and updates the "learning state" UI (changing icons to checkmarks) once an item is studied.
- NPCController: Manages the dialogue system, pulling historical facts from the data layer and displaying them via the NPC UI panel.

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
