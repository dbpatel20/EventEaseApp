\# 🟣 EventEase App

\### A Blazor WebAssembly Event Management Application



\*\*EventEase\*\* is a Blazor-based web application designed to help users browse, register, and track attendance for corporate and social events.  

It was developed as part of a three-activity project focused on using \*\*Microsoft Copilot\*\* for AI-assisted software development.



---



\## 🚀 Features



\### 🧩 Activity 1 – Foundation

\- Created a reusable \*\*Event Card component\*\* (`EventCard.razor`) with fields for Event Name, Date, and Location.  

\- Implemented \*\*data binding\*\* to dynamically display event details.  

\- Set up \*\*routing\*\* and page navigation between Events, Details, and Registration pages.



\### 🧠 Activity 2 – Debugging \& Optimization

\- Added \*\*validation\*\* for invalid inputs in `EventCard`.  

\- Improved \*\*routing\*\* to gracefully handle missing pages (custom 404 message in `App.razor`).  

\- Optimized performance with an `@foreach` loop and `@key` directive for rendering large event lists efficiently.



\### ⚙️ Activity 3 – Advanced Features

\- Built a \*\*Registration Form\*\* with Blazor’s `EditForm` and `DataAnnotationsValidator` for input validation.  

\- Implemented \*\*state management\*\* via a `UserSessionService` singleton to track user sessions.  

\- Added an \*\*Attendance Tracker\*\* page to display the registered user’s details.  

\- Updated navigation for seamless user flow between \*\*Home\*\*, \*\*Events\*\*, \*\*Registration\*\*, and \*\*Attendance\*\*.



---



\## 🧠 How Microsoft Copilot Assisted



| Stage | Copilot’s Role |

|-------|----------------|

| \*\*Component Creation\*\* | Suggested the initial structure for `EventCard.razor` with parameter binding. |

| \*\*Routing Setup\*\* | Assisted in generating `App.razor` routing and page directives (`@page`). |

| \*\*Debugging\*\* | Provided code suggestions for validation, null checks, and performance improvements. |

| \*\*Feature Expansion\*\* | Helped outline and generate Blazor form validation, dependency injection, and service registration code. |

| \*\*Documentation\*\* | Generated structured explanations, summaries, and README content. |



---



\## 💻 Tech Stack

\- \*\*Framework:\*\* Blazor WebAssembly (.NET 9.0)

\- \*\*Language:\*\* C# / Razor

\- \*\*IDE:\*\* Visual Studio with Microsoft Copilot

\- \*\*Tools:\*\* Git, GitHub



---



\## 🧭 Running the App



1\. Clone this repository:

&nbsp;  ```bash

&nbsp;  git clone https://github.com/dbpatel20/EventEaseApp.git

&nbsp;  cd EventEaseApp



