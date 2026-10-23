# 🏢 Blazor Expense Approval System

An enterprise-grade, role-based Expense Approval web application built using **C#**, **ASP.NET Core Blazor Server**, and **Bootstrap 5**. The system features hierarchical workflow management, automated business logic thresholds, and dynamic role-filtered dashboard views with file persistence.

---

## 🌟 Key Features

* **🔐 Role-Based Authentication & Session Tracking**:
  * Secure credential authentication for **Employee**, **Manager**, and **Finance** roles.
  * Instant session termination via top-bar **Logout** controls.
  * Auto-redirection from root (`/`) to the `/login` portal.

* **⚙️ Automated Tiered Approval Engine**:
  * **Auto-Approved (< ₹5,000)**: Instant approval processed directly by the rule engine.
  * **Manager Approval Tier (₹5,000 – ₹25,000)**: Routed to managerial review queues.
  * **Finance Approval Tier (> ₹25,000)**: Escalated to finance executive audit queues.

* **📊 Hierarchical Visibility & Data Tables**:
  * **Employee Dashboard**: Interactive submission form paired with a real-time table tracking personal request statuses and approver feedback.
  * **Manager Dashboard**: Filtered queue displaying pending requests within the ₹5K–₹25K tier with approval/rejection action controls.
  * **Finance Master Dashboard**: System-wide audit view across all submitted expenses with granular override controls.

* **💾 Real-Time Data Persistence**:
  * Uses structured JSON file persistence (`users.json`, `expenses.json`) under `Data/` to maintain data across session restarts without database configuration overhead.

---

## 🏗️ Tech Stack

* **Framework**: .NET 8 / Blazor Server (Interactive Server Mode)
* **Language**: C#
* **UI Framework**: Bootstrap 5 + Custom CSS Status Badges
* **Persistence Layer**: `System.Text.Json` Serialization
* **Version Control**: Git & GitHub

---

## 📁 Project Architecture

```text
MyBlazorApp/
├── Components/
│   ├── Layout/
│   │   └── NavMenu.razor            # Sidebar navigation & global controls
│   └── Pages/
│       ├── Home.razor                # Root path redirection logic
│       ├── Login.razor               # User authentication UI
│       ├── SubmitExpense.razor       # Employee expense form & history table
│       └── ApproveExpense.razor      # Tiered Manager & Finance dashboards
├── Data/
│   ├── users.json                    # User credentials & role definitions
│   └── expenses.json                 # Persistent expense ledger
├── Models/
│   ├── User.cs                       # User entity model
│   └── Expense.cs                    # Expense data & status enum definitions
├── Services/
│   ├── AuthenticationService.cs      # Auth state & session tracking
│   └── ExpenseApprovalService.cs     # Business rules & CRUD persistence
└── Program.cs                        # Service registrations & routing configuration

```
👥 Demo User Credentials
1. Employee
Name: Rahul

Email: rahul@company.com

Password: 12345

Scope: Submit expenses & view personal history table

2. Manager
Name: Priya

Email: priya@company.com

Password: 12345

Scope: Approve/Reject expenses between ₹5,000 – ₹25,000

3. Finance
Name: Arun

Email: arun@company.com

Password: 12345

Scope: Master audit table & high-value approvals (> ₹25,000)

🚀 Getting Started Locally
Prerequisites
.NET 8.0 SDK installed on your system.

Running the App
Clone the repository:

Bash
git clone [https://github.com/PRANAV-MS25/Expense-Approval-System.git](https://github.com/PRANAV-MS25/Expense-Approval-System.git)
cd Expense-Approval-System
Run the project:

Bash
dotnet run
Navigate to http://localhost:5227 in your browser.


---

### Update on GitHub:

Run these commands in your command prompt:

```
cmd
git add README.md
DOS
git commit -m "Fix README formatting"
DOS
git push
