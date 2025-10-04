# 🍽️ .NET Restaurant Application

A full-stack restaurant management system built with React.js frontend and .NET Core Web API backend. This application allows restaurant staff to manage customer orders, food items, and track order history with an intuitive user interface.

## 📋 Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Database Schema](#database-schema)
- [Usage](#usage)
- [Contributing](#contributing)

## ✨ Features

### Order Management
- **Create New Orders**: Generate unique order numbers automatically
- **Customer Selection**: Choose from existing customers
- **Food Item Search**: Search and add food items to orders with real-time filtering
- **Quantity Management**: Increase/decrease item quantities with intuitive controls
- **Payment Methods**: Support for Cash and Card payments
- **Order Tracking**: View order details with automatic grand total calculation
- **Order History**: View, edit, and delete previous orders

### Real-time Operations
- **Dynamic Pricing**: Automatic calculation of order totals based on quantity and price
- **Order Validation**: Form validation for required fields (customer, payment method)
- **Instant Feedback**: Success/error notifications for user actions
- **Responsive UI**: Material-UI components for better user experience
- **Live Search**: Real-time food item filtering as you type

## 🛠️ Tech Stack

### Frontend 
- **React.js** - User interface library with functional components and hooks
- **Material-UI (@material-ui/core)** - UI component library for consistent design
- **Axios** - HTTP client for API requests
- **React Hooks** - State management (useState, useEffect, custom hooks)

### Backend 
- **.NET Core 6** - Web API framework
- **Entity Framework Core** - ORM for database operations with SQL Server
- **SQL Server** - Database management system
- **Swagger/OpenAPI** - API documentation and testing
- **CORS** - Cross-origin resource sharing support

### Additional (4.8%)
- **HTML/CSS** - Styling and markup
- **SQL Server Migrations** - Database version control

## 📁 Project Structure

```
.Net-Restaurant-Application/
├── restaurant-app/                 # React Frontend
│   ├── src/
│   │   ├── components/
│   │   │   └── Order/
│   │   │       ├── index.js              # Main order component
│   │   │       ├── OrderForm.js          # Order form with customer/payment
│   │   │       ├── OrderedFoodItems.js   # Cart with quantity controls
│   │   │       ├── OrderList.js          # Order history management
│   │   │       └── SearchFoodItems.js    # Food item search & selection
│   │   ├── layouts/               # Reusable UI layouts (Form, Table, Popup)
│   │   ├── hooks/                 # Custom React hooks (useForm)
│   │   ├── controls/              # UI controls (Input, Button, Select)
│   │   ├── api/                   # API integration with axios
│   │   └── utils/                 # Utility functions
│   └── package.json
└── RestaurantAPI2/                # .NET Core Backend
    ├── Controllers/
    │   ├── CustomerController.cs   # Customer management endpoints
    │   ├── FoodItemController.cs   # Food item management endpoints
    │   └── OrderController.cs      # Order CRUD operations
    ├── Models/
    │   ├── Customer.cs
    │   ├── FoodItem.cs
    │   ├── OrderMaster.cs
    │   ├── OrderDetail.cs
    │   └── RestaurantDbContext.cs
    ├── Migrations/
    └── Program.cs
```

## 🚀 Getting Started

### Prerequisites
- Node.js (v14 or higher)
- .NET 6 SDK
- SQL Server (LocalDB or Express)
- Visual Studio Code or Visual Studio

### Backend Setup (.NET Core API)

1. **Navigate to the API directory**
   ```bash
   cd RestaurantAPI2/RestaurantAPI2
   ```

2. **Update Connection String**
   ```json
   // appsettings.json
   {
     "ConnectionStrings": {
       "DevConnection": "Server=(localdb)\\mssqllocaldb;Database=RestaurantDB;Trusted_Connection=true;MultipleActiveResultSets=true;"
     }
   }
   ```

3. **Run Database Migrations**
   ```bash
   dotnet ef database update
   ```

4. **Start the API**
   ```bash
   dotnet run
   ```
   API will be available at: `http://localhost:21485`

### Frontend Setup (React App)

1. **Navigate to the React app directory**
   ```bash
   cd restaurant-app
   ```

2. **Install Dependencies**
   ```bash
   npm install
   ```

3. **Start the Development Server**
   ```bash
   npm start
   ```
   Frontend will be available at: `http://localhost:3000`

## 🔌 API Endpoints

### Base URL: `http://localhost:21485/api`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/Customer` | Get all customers |
| GET | `/FoodItem` | Get all food items |
| GET | `/Order` | Get all orders with customer details |
| GET | `/Order/{id}` | Get order by ID with order details |
| POST | `/Order` | Create new order with order details |
| PUT | `/Order/{id}` | Update existing order |
| DELETE | `/Order/{id}` | Delete order |

## 🗃️ Database Schema

### Tables

1. **Customers**
   - CustomerID (Primary Key, Identity)
   - CustomerName (nvarchar(100))

2. **FoodItems**
   - FoodItemId (Primary Key, Identity)
   - FoodItemName (nvarchar(100))
   - Price (decimal(18,2))

3. **OrderMasters**
   - OrderMasterId (Primary Key, Identity)
   - OrderNumber (nvarchar(75))
   - CustomerId (Foreign Key → Customers)
   - PMethod (nvarchar(10)) - Payment Method
   - GTotal (decimal(18,2)) - Grand Total

4. **OrderDetails**
   - OrderDetailId (Primary Key, Identity)
   - OrderMasterId (Foreign Key → OrderMasters)
   - FoodItemId (Foreign Key → FoodItems)
   - Quantity (int)
   - FoodItemPrice (decimal(18,2))

## 🎯 Key Features Breakdown

### Order Management Workflow
1. **Order Creation**: Generate unique 6-digit order number automatically
2. **Customer Selection**: Choose from dropdown of existing customers
3. **Food Selection**: Search food items with real-time filtering
4. **Cart Management**: Add items, adjust quantities, remove items
5. **Payment Method**: Select Cash or Card payment
6. **Order Submission**: Validate form and save to database
7. **Order History**: View, edit, or delete previous orders

### Technical Highlights
- **Form Validation**: Custom validation for required fields (customer, payment method)
- **State Management**: Custom useForm hook for efficient state handling
- **API Integration**: RESTful API calls with comprehensive error handling
- **Responsive Design**: Material-UI components for mobile-friendly interface
- **Real-time Search**: Filter food items as user types
- **Database Operations**: Entity Framework Core with complex joins and relationships
- **CORS Configuration**: Cross-origin support between React (port 3000) and API (port 21485)

## 📱 Usage

1. **Start both servers** (Backend on port 21485, Frontend on port 3000)
2. **Access the application** at `http://localhost:3000`
3. **Create an order**:
   - Select a customer from the dropdown
   - Search and add food items from the left panel
   - Adjust quantities using +/- buttons in the right panel
   - Choose payment method (Cash/Card)
   - Submit the order
4. **View order history** using the "Orders" button
5. **Edit existing orders** by clicking on order numbers in the list
6. **Delete orders** using the delete icon in the order list

## 🔧 Application Components

### Frontend Components
- **OrderForm**: Handles customer selection, payment method, and order submission
- **SearchFoodItems**: Provides real-time search and food item selection
- **OrderedFoodItems**: Manages cart items with quantity controls
- **OrderList**: Displays order history with edit/delete functionality

### Backend Controllers
- **OrderController**: Comprehensive CRUD operations with complex joins
- **CustomerController**: Customer management
- **FoodItemController**: Food item retrieval

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 👨‍💻 Author

**Hafar Sadok** - [@haffarsadok](https://github.com/haffarsadok)

---

⭐ Star this repository if you found it helpful!
