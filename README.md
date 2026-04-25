  ## 🏥 Tasaneem WebSite – Patient Management System
    🔗 **Live Demo:**
    🔗 **LikedIn Post:**
    A full-featured **Patient Management System** designed for a physiotherapy and clinical nutrition clinic.  
    The system helps manage patient records, track body measurements, and generate printable reports.
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
  ## ✨ Features
    - 👤 Patient Management (Add / Edit / View)
    - 📊 Measurement Tracking (Weight, Body Measurements)
    - ♻️ Soft Delete & Restore
    - ❌ Permanent Delete
    - 🖨️ Printable Patient Report (PDF)
    - 📱 Responsive Print Layout (Mobile Friendly)
    - 🔍 Filtering & Search
    ---
  ## ⚙️ Technologies Used
    - ASP.NET MVC  
    - Entity Framework Core  
    - AutoMapper  
    - SQL Server  
    - HTML / CSS / Bootstrap
    ---  
  ## 🚀 Key Highlights
    - Clean implementation of **Generic Repository Pattern**
    - Use of **AutoMapper** for mapping between Entities and ViewModels
    - Implementation of **Soft Delete using IsDeleted**
    - Separation between layers for better maintainability
    ---
  ## 📌 Future Improvements
    - Authentication & Authorization  
    - Notification
    - Web API version
        
  ## 🔐 Configuration & Security
    This project is configured for production deployment.
    Sensitive files such as `appsettings.json` are not included in this repository to protect environment-specific settings and credentials.
    To run the project locally, create your own `appsettings.json` and configure the database connection string.



