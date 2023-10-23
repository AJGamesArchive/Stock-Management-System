# Object Orientated Programming Assessment

## Assessment Info

- Task 1: Enum Report | Due: **Friday 8th December**
- Task 2: Developing the Stock Management & Point of Sales System | Due: **Friday 8th December**
- Task 3: Interfaces Report | Due: **Friday 8th December**
- Task 4: Optional Unit Test Creation | Due: **Friday 8th December**

## System Requirements

- Add a new item to the inventory (list of items sold)
- Add a new supplier
- Get a list of items requiring restock by from a given supplier
- Sell an item to a new customer
- Sell and item to an existing customer
- Get a list of all purchases by a customer

## GUI Design Information

### Font Size(s)

- Page Headers / Titles = 15
- Standard Info Text & Input Boxes = 12

### Shop Tab Data Flow

- **Select Customer** (New, Existing)
- - **Enter Customer Details** (Required Detials Based On Class)
- - **Select Customer** (Saved Previous Customers)

- **Select Shopping Method** (Search/Filter For Spesific Item, Browse Items)
- - **Select Item Type** (Clothing, Shoe, Accessory)
- - - **Select Clothing Style** (Shorts, Capris, Leggings, Vests, Tops, Jackets)
- - - - **Select Size & Colour** (Stocked Sizes & Colours)
- - - - - **Display Item Details** (Name, Price, Stock Level, Size, Colour, Style)
- - - **Select Shoe Type** (Racer, Stability, Neutral, Trial, Track)
- - - - - **Select Size** (Stocked Sizes)
- - - - - - **Display Item Detials** (Name, Price, Stock Leve, Size, Type)
- - - **Select Accessories** (Bags, Nutrition, Watches)
- - - - **Select Capacity** (Stocked Capacities)
- - - - - **Display Item Details** (Name, Price, Stock Level, Accessory Type, Capacity)
- - - - **Select Nutrition Type** (Carbs,  Protein)
- - - - - **Select Quantity** (Stocked Quantities)
- - - - - - **Display Item Details** (Name, Price, Stock Level, Accessory Type, Nutrition Type, Quantity)
- - - - **Select Watch Type** (Simple, Heart Rate, GPS, GPSandHeartRate)
- - - - - **Display Item Detials** (Name, Price, Stock Level, Accessory Type, Watch Type)
- - **Select Item Name** (Stocked Items)
- - - **Display Item Details** (Name, Price, Stock Level, + Applicable Details From Above)

# Useful Resource

- [UML Class Diagram Info](https://www.visual-paradigm.com/guide/uml-unified-modeling-language/uml-class-diagram-tutorial/)
- [C# OOP Info](https://www.w3schools.com/cs/cs_class_members.php)
- [Tab Control For Navigation Info](https://stackoverflow.com/questions/57250325/can-we-open-second-form-on-same-window-of-first-form-in-net-windows-form)