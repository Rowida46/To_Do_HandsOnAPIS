# To_Do_HandsOnAPIS


## Overview

_We are going to create the following __API___:

| _URL_ Endpoint                  | #Description              | #Request body	 | #Response body	      |
| ------------------------------- | ------------------------- | -------------  | -------------------  |
|`GET /api/todoitems`             |  Get all to-do items      |  _None_        | Array of to-do items | 
|`GET /api/todoitems/{id}`        |  Get all to-do item by`id`|  _None_      	 | To-do items          | 
|`POST /api/todoitems`            |  Add a new item           |  To-do item    | To-do items          | 
!`PUT /api/todoitems/{id}`        |	 Edit an existing item    |  To-do item  	 |  _None_              | 
|`DELETE /api/todoitems/{id}  `   |  Delet a to-do items      |  _None_      	 |  _None_              | 
| ------------------------------- | ------------------------- | -------------  | -------------------  |





## Model SnapShot
```c#
namespace To_Do_HandsOnAPIS.Models
{
    // The model for this app is a single TodoItem class.
    public class ToDoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; } // allow null val
        public bool IsComplete { get; set; }
    }
}

```
