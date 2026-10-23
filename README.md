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
👥 Demo User CredentialsTest the hierarchical workflow using these pre-configured user credentials:RoleNameEmailPasswordScope / VisibilityEmployeeRahulrahul@company.com12345Can submit expenses & view personal historyManagerPriyapriya@company.com12345Can review expenses between ₹5,000 – ₹25,000FinanceArunarun@company.com12345Master audit access & high-value approvals (> ₹25,000)🚀 Getting Started LocallyPrerequisites.NET 8.0 SDK installed on your system.Visual Studio 2022 or VS Code.Installation & RunClone the repository:Bashgit clone [https://github.com/PRANAV-MS25/Expense-Approval-System.git](https://github.com/PRANAV-MS25/Expense-Approval-System.git)
cd Expense-Approval-System
Restore dependencies & run:Bashdotnet run
Launch in Browser:
Navigate to http://localhost:5227 (or your local IIS Express port). The application will automatically route you to the Login screen.📄 LicenseThis project is open-source and available under the MIT License.
---

### Step 2: Commit and push the README to GitHub

Run these three commands in your terminal at `C:\MyBlazorApp`:

```cmd
git add README.md
DOSgit commit -m "Docs: Add comprehensive README documentation"
DOSgit push
