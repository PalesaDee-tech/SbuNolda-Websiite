# SbuNolda Construction – ASP.NET Core MVC Website

A professional multi-page website for **SbuNolda Construction**, built with **ASP.NET Core 8 MVC**, Razor Views, C#, and CSS.

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Framework | ASP.NET Core 8 MVC |
| Backend | C# (.NET 8) |
| Views | Razor (.cshtml) |
| Styling | Custom CSS (no frameworks) |
| Icons | Font Awesome 6 |
| Email | System.Net.Mail (SMTP) |

## 📄 Pages

- **Home** – Hero section, animated stat counters, feature cards
- **About** – Company story, values, team members
- **Services** – Full service listing with CTA
- **Contact** – Working contact form that sends emails via SMTP

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)

### Run locally

```bash
git clone https://github.com/YOUR_USERNAME/sbunolda-website.git
cd sbunolda-website
dotnet run
```

Open your browser at `https://localhost:5001`

## 📧 Email Setup

The contact form sends enquiries directly to the business email.

1. Open `appsettings.json`
2. Fill in your SMTP credentials:

```json
"Smtp": {
  "Host": "smtp.gmail.com",
  "Port": "587",
  "User": "your-gmail@gmail.com",
  "Password": "your-app-password"
}
```

> **Gmail tip:** Use an [App Password](https://support.google.com/accounts/answer/185833) (not your main password) with 2FA enabled.

## 📁 Project Structure

```
SbuNolda/
├── Controllers/
│   └── HomeController.cs       # All page actions + email POST
├── Models/
│   └── ContactMessage.cs       # Form model with validation
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml        # Home page
│   │   ├── About.cshtml        # About page
│   │   ├── Services.cshtml     # Services page
│   │   └── Contact.cshtml      # Contact page + form
│   └── Shared/
│       ├── _Layout.cshtml      # Shared navbar + footer
│       └── _ValidationScriptsPartial.cshtml
├── wwwroot/
│   ├── css/site.css            # All styles
│   └── js/site.js              # Counter animation + mobile menu
├── appsettings.json
└── Program.cs
```

## 🌐 Deployment

This project can be deployed to:
- **Azure App Service** (free tier available)
- **Railway.app** (simple .NET hosting)
- **Render.com**

---

Built with ❤️ in South Africa 🇿🇦
