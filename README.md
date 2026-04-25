  ## 🏥 Tasaneem WebSite – Patient Management System
  🔗 **Live Demo:** https://testdoctortasneem.runasp.net/
  🔗 **LikedIn Post:**
   A professional Patient Management System designed for physiotherapy and clinical nutrition clinics. This system streamlines patient record management, 
   tracks body measurements over time, and generates comprehensive reports for healthcare providers.
  ---
  ## 🎯 Project Overview
  This project is built using **ASP.NET MVC** with a clean **3-Tier Architecture** to ensure:
    - Separation of concerns  
    - Maintainability  
    - Scalability  
  It allows doctors to efficiently manage patients and monitor their progress over time.
  ---
  ## 🧠 Architecture
  The system follows a **3-Tier Architecture**:
    - **Presentation Layer (PL)**  
      Handles UI (Controllers & Views)
    - **Business Logic Layer (BLL)**  
      Contains services, validation, and AutoMapper 
    - **Data Access Layer (DAL)**  
      Manages database operations using repositories
|            Layer               |     Project Name      |                                 Responsibility                                                   |
-------------------------------------------------------------------------------------------------------------------------------------------------------------
| **Presentation Layer (PL)**    | `TasanemoForMepo_MVC` | Handles the UI, Controllers, and Views. Manages user interactions and displays data.             |
| **Business Logic Layer (BLL)** | `Tass_BLL`            | Contains services, business rules, validation logic, and AutoMapper configurations.              |
| **Data Access Layer (DAL)**    | `Tass_DAL`            | Manages database operations, Entity Framework Core configurations, migrations, and repositories. |
  ---
  ## 📂 Project Structure 
  🏥 TasaneemWebSite (Solution)
  │
  ├── 📦 Tass_BLL (Business Logic Layer)
  │   ├── 📁 AddService
  │   ├── 📁 Global
  │   ├── 📁 Mapper     # AutoMapper profiles for DTO/Entity mapping
  │   ├── 📁 Response   # Standardized service response models
  │   ├── 📁 Services   # Business logic implementations and interfaces
  │   └── 📁 ViewModes  # Data transfer objects for the UI
  │
  ├── 📦 Tass_DAL (Data Access Layer)
  │   ├── 📁 AddService
  │   ├── 📁 Configration
  │   ├── 📁 Data          # DbContext and database initialization
  │   ├── 📁 Entities      # Database models (Patient, Measurements)
  │   ├── 📁 Global
  │   ├── 📁 Migrations    # EF Core database migrations
  │   └── 📁 Repositories  # Generic and specific repository implementations
  │
  ├── 🌐 TasanemoForMepo_MVC (Presentation Layer)
  │   ├── 📄 .gitignore
  │   ├── 📁 Controllers  # MVC Controllers (Patient, Measurement, Home)
  │   ├── 📁 Global
  │   ├── 📁 Models
  │   ├── 📄 Program.cs   # Application entry point and dependency injection
  │   ├── 📁 Properties
  │   ├── 📁 Views        # Razor views for the web interface
  │   └── 📁 wwwroot      # Static assets (CSS, JS, Images)
  │
  └── 🧾 TasaneemWebSite.sln
  ---
   ##✨ Key Features
      •👤 Patient Management: Full CRUD operations for patient profiles including clinical diagnosis and contact information.
      •📊 Measurement Tracking: Record and monitor physical metrics such as Weight, Chest, Upper Abdomen, Lower Abdomen, and Buttocks.
      •♻️ Data Integrity: Implementation of Soft Delete (IsDeleted) to prevent accidental data loss while allowing for restoration.
      •🖨️ Clinical Reporting: Generate printable patient reports optimized for professional medical documentation.
      •🔍 Advanced Filtering: Search and filter through patient records efficiently.
      •📱 Responsive Design: Fully accessible across desktop and mobile devices.
  ---
  ##⚙️ Technologies Used
    •Framework: ASP.NET MVC (Core)
    •ORM: Entity Framework Core
    •Mapping: AutoMapper
    •Database: SQL Server
    •Frontend: HTML5, CSS3, Bootstrap, JavaScript
    •Pattern: Repository Pattern & Dependency Injection
  ---  
   🚀 Key Highlights
      • Clean implementation of **Generic Repository Pattern**
      • Use of **AutoMapper** for mapping between Entities and ViewModels
      • Implementation of **Soft Delete using IsDeleted**
      • Separation between layers for better maintainability
  ---
   📌 Future Improvements
      • Authentication & Authorization  
      • Notification
      • Web API version
  ---       
  🔐 Configuration & Security
      This project is configured for production deployment.
      Sensitive files such as `appsettings.json` are not included in this repository to protect environment-specific settings and credentials.
      To run the project locally, create your own `appsettings.json` and configure the database connection string.



