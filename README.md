# 👩‍💻 Personal Portfolio Management System (.NET Core 6.0)

This project was developed to enhance my technical skills in software development and gain hands-on experience through real-world applications. It was carried out under the guidance of 👨‍🏫 Murat Yücedağ at 🏫 M&Y Software Training Academy & Consultancy.

Built with ⚙️ .NET Core 6.0, this portfolio management system offers a comprehensive solution with a dynamic data structure, user-friendly interface, and fully manageable admin panel. All functional scenarios have been successfully implemented, tested, and the system is ready for deployment.

---

## 🚀 Technologies Used

- 🧩 **ASP.NET Core 6.0** – For building modern and high-performance web applications.  
- 🛠️ **Entity Framework Core (Code First)** – Database modeling with code and MSSQL Server integration.  
- 🗄️ **MSSQL Server** – A secure and relational database management system.  
- 🧱 **MVC Architecture** – Modular and clean structure for efficient development.  
- 🧩 **PartialView & ViewComponent** – Reusable and modular UI components.  
- 🔍 **LINQ** – Fast and readable data access.  
- 🎨 **Bootstrap 5** – Responsive and modern front-end design framework.  
- 🖥️ **HTML5 & CSS3** – Structuring and styling of the web pages.  
- 🚨 **SweetAlert** – Stylish and user-friendly alert popups.  
- 🗺️ **Google Maps API** – Map integration on the contact page.  
- ⚠️ **404 Error Page** – Custom-designed error page for invalid URL routing.  
- 🧩 **Single-Layer Architecture** – Simple and easily manageable project structure.

---

## 🎀 Project Structure

### 💊 User Interface (UI Panel)

- 🔄 All content is dynamically fetched from the database.  
- 🌐 Nested PartialView used for the social media component.  
- 👤 The About Me section displays data dynamically.  
- 📊 **Statistics (via ViewBag + LINQ):**  
  - 🔢 Total number of references  
  - 📂 Number of portfolio projects  
  - 🧠 Number of skills  
  - 🔀 Random number between 10 and 20 (changes on page reload)  
- 🧪 Skills are listed dynamically.  
- 🎓 Education & Experiences are displayed from the database.  
- 📁 Projects can be filtered by category.  
- 🧰 Services: 8 records in the database, only 6 displayed on the UI.  
- 🗣️ References & Testimonials are dynamically listed.  

### 📬 Contact / Message Sending

- 🧾 **Left side:** contact information  
- ✉️ **Right side:** contact form  
- ✅ **SweetAlert** used to confirm successful submission  
- 🗺️ **Map & Footer:** Integrated Google Maps API and dynamic location data.  
- ⚠️ **404 Page:** Custom error page design.

---

### 🧑🏻‍💻 Admin Panel

- 🛠️ **Full CRUD (Create, Read, Update, Delete)** operations available for all content.

- 🗂️ **Manageable sections include:**
  - 📄 Experiences  
  - 🎓 Education  
  - 👤 About Me  
  - 📞 Contact Information  
  - 🧰 Services  
  - 🗣️ References  
  - 📁 Projects (category-based filtering and card view)  
  - 🧪 Skills  

### 📥 Inbox (Contact Messages)

- 🕓 All messages are marked as "Unread" by default.  
- 👁️ Messages can be viewed, status can be updated, and they can be deleted.  
- 🔤 Substring is used for message previews.

### 📊 Statistics Dashboard

- 🔢 Total number of skills  
- 🧮 Total skill score  
- 🎯 Skills with scores above 70  
- 📈 Average skill score  
- 📄 Total number of experiences  
- 💼 Experiences with the title “IT Intern”  
- 📬 Number of read and unread messages  
- 🧰 Total number of services  
- 👩‍💻 Number of references with the title 
