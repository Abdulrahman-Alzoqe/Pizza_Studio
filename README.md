# 🍕 Pizza Studio

A Windows Forms desktop app built with **C#** and **.NET** where you build your own pizza: pick the size, crust, toppings and service type, then watch the pizza and the order summary update live.

This project is part of **Course 14** of Dr. Mohammed Abu-Hadhoud's roadmap (.NET with C#). The course gives the base idea; I redesigned the interface with my own visual identity.

## Screenshots

| Cover | Main screen |
|---|---|
| ![Cover](screenshots/cover.png) | ![Main](screenshots/main.png) |

## Features

- **Cover screen** with a *Get Started* button that opens the main form
- **Size**: Small, Medium or Large
- **Crust**: Thin or Thick
- **Service**: Eat In or Take Out
- **Toppings**: Extra Cheese, Mushrooms, Tomatoes, Onion, Olives, Green Peppers
- **Live pizza preview**: the pizza image changes as you select toppings and crust (toppings are drawn as layers)
- **Live order summary and total price**, recalculated on every change
- **Order** button with a confirmation dialog, which locks the form after the order is placed
- **Reset** button that restores the default selection (Small, Thin, Eat In, no toppings)

## Tech stack

- C# and Windows Forms
- [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms) for the modern controls
- GDI+ for the custom-drawn framed group boxes

## What I practiced

- Handling events (`CheckedChanged` vs `Click`) and wiring several controls to one handler
- Recalculating the total from the current selection on every change instead of adding and subtracting, which keeps Reset and default values safe
- Storing prices in each control's `Tag`, so no prices are hard-coded in the logic
- Drawing the pizza from layered images with `Graphics.DrawImage` instead of stacking transparent PictureBoxes
- Building a consistent visual identity: colors, typography, selected and unselected states, and a cover screen

## Getting started

1. Clone the repository
```bash
   git clone https://github.com/<your-username>/<repo-name>.git
```
2. Open the `.sln` file in **Visual Studio**
3. Restore NuGet packages (the **Guna.UI2.WinForms** package is required)
4. Press **F5** to run

**Requirements:** Windows, Visual Studio with the *.NET desktop development* workload.

## Project structure

```
PizzaStudioProject/
├── Form1.cs          # Main form: selection logic, price, order summary
├── FrmCover.cs       # Cover screen with the Get Started button
├── Properties/       # Resources (pizza base, topping layers, backgrounds)
└── Program.cs
```

## Credits

- Course content: Dr. Mohammed Abu-Hadhoud
- Images and backgrounds: [add sources and licenses here]

## License

[Choose a license, e.g. MIT]
