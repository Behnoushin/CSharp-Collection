# 📒 Simple Phone Book App

A colorful and interactive C# console application to manage your phone contacts easily.  
You can **add, edit, delete, search, and view contacts**, and all data is **saved to a file** for persistence 😍💖

---

## 🌟 Features

- ✅ Add new contacts with **name and phone number**  
- ✅ View all contacts **sorted alphabetically by name**  
- ✅ Search contacts by **name or phone number**  
- ✅ Edit existing contacts with **validation**  
- ✅ Delete single or multiple contacts with **confirmation**  
- ✅ Clear all contacts with **confirmation**  
- ✅ **Persistent storage** in a text file  
- ✅ Interactive **console input and colorful output**  
- ✅ Handles **invalid input gracefully**  

---

## 🖥 How to Run

1. Make sure you have **.NET SDK** installed.  
2. Clone this repository:

```bash
git clone <url>
```

Navigate to the project folder:
```bash
cd "PhoneBook app"
```

Run the program:
```bash
dotnet run
```
Follow the prompts and use the menu to manage your contacts 🎉

## 📝 Example
```bash
Welcome to the simple Phone Book!

Choose an option:
1. Add Contact
2. Show Contacts
3. Search Contact
4. Edit Contact
5. Delete Contact
6. Clear All Contacts
7. Exit

Enter contact name: John Doe
Enter phone number: 1234567890
Contact added successfully!

Choose an option:
2

Saved Contacts:
Name: John Doe - Phone: 1234567890

Choose an option:
3
Enter name or phone number to search: John
Found 1 contact(s):
Name: John Doe - Phone: 1234567890

Choose an option:
4
Enter phone number or name to edit: John
Current Name: John Doe, Phone: 1234567890
Enter new name (leave empty to keep current): John D.
Enter new phone number (leave empty to keep current): 
Contact updated successfully.

Choose an option:
5
Enter phone number or name to delete: John D.
Are you sure you want to delete 1 contact(s)? (y/n)
y
1 contact(s) removed successfully.

Choose an option:
7
Goodbye!
```

