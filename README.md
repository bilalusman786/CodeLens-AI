# CodeLens AI
CodeLens AI is a modern, desktop-based developer utility designed to transform messy, undocumented code into clean, readable, and well-explained logic. Powered by OpenRouter, it provides senior-level code reviews and documentation in seconds.

# Features
AI Code Documentation: Automatically injects professional, context-aware inline comments into your functions.

Plain-English Summaries: Breaks down complex algorithmic logic into easy-to-understand summaries.

Modern VS-Code Aesthetics: Features a high-contrast dark theme, custom padding, and a borderless "Fluent" UI design to minimize eye strain.

Multi-Model Intelligence: Integrated with OpenRouter to leverage the world's most powerful LLMs (like Gemini, Claude, and GPT).

Live Status Tracking: Real-time visual feedback on API connection and analysis states.

# Tech Stack
Language: C#

Framework: .NET / Windows Forms (Modernized)

API Integration: OpenRouter (REST API)

Dependencies: Newtonsoft.Json for high-performance JSON parsing.

# Getting Started
Prerequisites
Visual Studio 2022 or later.

.NET Framework / .NET Desktop Development workload installed.

An OpenRouter API Key.

Installation
Clone the repository:

Bash
git clone https://github.com/your-username/CodeLens-AI.git
Open the solution:
Launch CodeLens AI.sln in Visual Studio.

Install Dependencies:
Open the NuGet Package Manager and install Newtonsoft.Json.

Add your API Key:
In Form1.cs, find the ApiKey variable and paste your OpenRouter key:

C#
private const string ApiKey = "YOUR_OPENROUTER_KEY";
Build & Run:
Press F5 to launch the application.

# Interface Preview
Note: The UI uses a custom header panel and a dark palette (RGB 28, 28, 28) to provide a "developer-first" experience.

Top Editor: Paste your raw code here.

Left Output: Receive your code back with professional comments.

Right Output: Read the plain-English logic summary.

# License
Distributed under the MIT License. See LICENSE for more information.
