# 🩸 Blood Management System

A web-based application designed to streamline the process of blood donation, request handling, and inventory management for hospitals, blood banks, and donors. The system aims to improve efficiency, accessibility, and transparency in blood distribution.

---

## 🚀 Features

- **Donor Registration** – Securely register donors with blood type and contact details.
- **Blood Request Management** – Hospitals or users can request specific blood types.
- **Inventory Tracking** – Monitor blood availability and expiry in real-time.
- **Admin Dashboard** – Admins can manage donor data, requests, and inventory levels.
- **Search Functionality** – Quickly find donors by location or blood group.

---

## 🛠️ Tech Stack

- **Frontend**: HTML, CSS, JavaScript  
- **Backend**: Node.js, Express.js  
- **Database**: MongoDB (or MySQL, depending on implementation)  
- **Authentication**: JWT (JSON Web Tokens)

---

## 📦 Installation & Setup


# Clone the repository
git clone https://github.com/GaneshPelluru/Blood-Management-System.git

# Navigate into the project directory
cd Blood-Management-System

# Install dependencies
npm install

# Configure environment variables
# Create a .env file and add DB_URI and PORT
touch .env
Example .env file:

env

    DB_URI=mongodb://localhost:27017/blood_management
    PORT=5000
  
# Start the application
    npm start
  Visit http://localhost:5000 to use the application locally.


📁 Project Structure

    ├── public/              # Frontend assets (HTML/CSS)
    ├── src/                 # Backend source code
    │   ├── controllers/     # Route controllers
    │   ├── models/          # Mongoose/DB models
    │   └── routes/          # API route definitions
    ├── config/              # DB and environment configs
    ├── server.js            # Main entry point
    ├── .env                 # Environment variables
    └── package.json         # Node dependencies

🙌 Contributing
Contributions are welcome! Feel free to fork the repository, raise issues, or open pull requests to improve the system.

📄 License
This project is licensed under the MIT License.

      Let me know if you want to add a logo, screenshots, or deployment instructions too!
