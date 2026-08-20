<div align="center">
  
# 📦 RMD_APP (Inventory Management System)

[![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-512BD4?style=for-the-badge&logo=.net)](https://dotnet.microsoft.com/)
[![VB.NET](https://img.shields.io/badge/Language-VB.NET-00599C?style=for-the-badge&logo=visualbasic)](https://docs.microsoft.com/en-us/dotnet/visual-basic/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows_Forms-0078D7?style=for-the-badge&logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)

*A comprehensive and intuitive desktop application for warehouse and inventory management.*

</div>

---

## 📖 Overview

**RMD_APP** is a robust desktop application built using **VB.NET** and **Windows Forms (.NET Framework 4.8)**. It is designed to streamline warehouse operations, providing modules for inbound logistics, outbound shipments, real-time inventory tracking, and detailed reporting. 

The application offers a user-friendly dashboard and seamlessly integrates with a SQL Server database to ensure data integrity and high performance.

## ✨ Key Features

- 🔐 **Secure Authentication**: Dedicated login system (`FormLogin`) to ensure data privacy and role-based access.
- 📊 **Interactive Dashboard**: A central hub (`FormDashboard`) providing a quick overview of warehouse activities.
- 📥 **Inbound Operations**: Efficiently manage and record incoming shipments and stock replenishments.
- 📤 **Outbound Operations**: Handle dispatch, track outgoing items, and manage delivery processes.
- 📦 **Real-Time Inventory**: Keep track of current stock levels and inventory movements.
- 🗃️ **Master Data Management**: Easily configure and manage core system data.
- 📈 **Advanced Reporting (RDLC)**: Generate detailed printable reports including:
  - Inventory Status (`RptInventory.rdlc`)
  - Inbound History (`RptRiwayatInbound.rdlc`)
  - Outbound History (`RptRiwayatOutbound.rdlc`)

## 🛠️ Technology Stack

- **Framework**: .NET Framework 4.8
- **Language**: Visual Basic .NET (VB.NET)
- **UI Framework**: Windows Forms (WinForms)
- **Reporting**: Microsoft RDLC Report Viewer
- **UI Components**: ReaLTaiizor, C1 WinForms (ComponentOne)
- **Database Connectivity**: SQL Server Types

## 📂 Project Structure

- `FormLogin.vb` & `FormDashboard.vb` - Core application entry and navigation.
- `UC_Inbound.vb`, `UC_Outbound.vb`, `UC_Inventory.vb` - User Controls handling specific module logic.
- `UC_Laporan.vb` - Report generation interface.
- `DsInbound.xsd`, `DsInventory.xsd`, `DsOutbound.xsd` - Typed DataSets for structured data handling.
- `script.sql` - Database schema setup script.

## 🚀 Getting Started

### Prerequisites

1. **Visual Studio 2022** (or compatible version) with the **.NET desktop development** workload installed.
2. **SQL Server** (Express or higher) for database management.
3. Crystal Reports / Microsoft Report Viewer runtime (if required for RDLC).

### Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone <your-repo-url>/RMD_APP.git
   ```
2. **Database Setup**:
   - Open SQL Server Management Studio (SSMS).
   - Execute the provided `script.sql` to create the database schema and tables.
3. **Configure Connection**:
   - Update the connection string in `App.config` to point to your local SQL Server instance.
4. **Build & Run**:
   - Open `RMD_APP.vbproj` in Visual Studio.
   - Restore NuGet packages.
   - Press `F5` to build and run the application.

---
<div align="center">
  <i>Developed with ❤️ by a .NET Developer</i>
</div>
