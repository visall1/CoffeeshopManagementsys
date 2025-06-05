
# ☕ CoffeeShopManagementSys

**CoffeeShopManagementSys** is a Windows Forms application developed in **C#** using **Entity Framework Core** and **MS SQL Server**, designed to efficiently manage coffee shop operations. It features order management, inventory tracking, employee records, payment processing, and PDF receipt generation – all in a user-friendly interface.

---

## 🔧 Features

- 🧾 **Order Management** – Add, edit, and process customer orders easily.
- ☕ **Menu Management** – Customize your menu with item categories and pricing.
- 📦 **Inventory Control** – Track ingredients and stock with automatic alerts.
- 👥 **Employee Records** – Manage staff information and access roles.
- 💳 **Payment & PDF Receipts** – Handle payments and print/download receipts.
- 📈 **Sales Reports** – View daily, weekly, and monthly sales analytics.
- 🔐 **Login System** – Admin and staff access control.

---

## 🛠️ Tech Stack

- **C# WinForms**
- **.NET 8 / .NET Framework**
- **Entity Framework Core**
- **MS SQL Server**
- **PdfSharp / iTextSharp** – for generating PDF receipts

---

## 🎥 Demo

![Demo GIF or Screenshot Placeholder](https://github.com/visall1/CoffeeshopManagementsys/blob/main/demo/demo.gif)

> Replace the above URL with your actual demo GIF or screenshot file once available.

---

## 🚀 Deployment

### Prerequisites

- Visual Studio 2022 or newer
- .NET SDK 8+
- MS SQL Server (Express or full version)

### Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone https://github.com/visall1/CoffeeshopManagementsys.git
   ```

2. **Open the solution file** in Visual Studio.

3. **Configure your database connection string**  
   In `App.config` or directly in your `DbContext` file.

4. **Run EF Core migrations (if needed):**
   ```
   Tools > NuGet Package Manager > Package Manager Console

   PM> Update-Database
   ```

5. **Build and run** the application.

---

## 📂 Folder Structure

```
CoffeeshopManagementsys/
├── Forms/             # All Windows Forms (UI)
├── Models/            # Entity Framework Core models
├── Data/              # DbContext and EF migrations
├── Services/          # Business logic, helpers
├── Utils/             # PDF generator, logger, etc.
├── Program.cs         # Main entry point
└── App.config         # Configuration settings
```

---

## 📸 Screenshots

> Add these to the `/demo/` folder and link them here:

- Dashboard view  
- Order processing screen  
- Inventory management  
- PDF receipt preview

---

## 🙋‍♂️ Author

**Visal**  
Student at IT Academy Step Cambodia  
GitHub: [https://github.com/visall1](https://github.com/visall1)

---

## 📄 License

This project is licensed under the **MIT License** – see the [LICENSE](https://github.com/visall1/CoffeeshopManagementsys/blob/main/LICENSE) file for details.
