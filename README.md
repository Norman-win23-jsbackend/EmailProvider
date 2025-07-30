# 📧 EmailProvider

**EmailProvider** is a lightweight Azure Functions backend built with **.NET 8**, designed to handle email-related workflows.  
It enables sending, validating, and potentially logging email activities via a secure and modular cloud function.

---

## 🚀 Features

- ✉️ Send transactional or confirmation emails  
- ⚙️ Built with **Azure Functions** (.NET 8)  
- 🔐 Secure setup with configuration via `local.settings.json`  
- 🔌 Ready for SMTP or third-party providers (SendGrid, Mailjet, etc.)  
- 🧱 Easily integrable into other microservices (Account, Course, etc.)

---

## 📁 Project Structure

```

EmailProvider/
├── Program.cs               # Entry point
├── host.json               # Azure Functions runtime settings
├── local.settings.json     # Dev environment variables (excluded from Git)
├── EmailProvider.csproj    # Project file
└── Functions/              # Email function(s)

````

---

## 🛠️ Getting Started

### 1. Install Tools

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)  
- [Azure Functions Core Tools](https://learn.microsoft.com/en-us/azure/azure-functions/functions-run-local)

### 2. Clone & Run

```bash
git clone https://github.com/Norman-Deen/EmailProvider.git
cd EmailProvider
func start
````

Access the API at:

```
http://localhost:7071
```

---

## ☁️ Azure Integration

* Fully deployable to Azure Functions
* Configurable via environment variables or Azure Key Vault
* Can be combined with Event Grid, Queues, or Logic Apps

---

## 🔐 Security Best Practices

* Never commit `local.settings.json` with credentials
* Use managed identities or secrets vault in production
* Protect your SMTP/API keys with proper permissions

---

## 📄 License

This project is part of a modular backend system built for educational or demo purposes.
Released under the [MIT License](LICENSE).

---

 **Nour Tinawi**
 
[LinkedIn](https://www.linkedin.com/in/nour-tinawi) • [Portfolio](https://www.pure-art.co) • [GitHub](https://github.com/Norman-Deen)
