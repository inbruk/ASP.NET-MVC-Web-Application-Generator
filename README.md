# ASP.NET-MVC-Web-Application-Generator

It uses code based configuration. It generates some sources for such layers:
1. Data Layer - sql scripts.
2. Data Access Layer - no soureces generated. It is expected that EF 6.0 ORM is used in DB first mode.
3. Business Logic Layer (Include DTO objects) - c# classes for CRUD and other usually staff.
4. Web Service Layer - c# classes 
5. Web Service client - c# classes
6. Web User Interface Model Layer - c# classes
7. Web User Interface Controller Layer - c# classes
8. Web User Interface View Layer - c# classes and cshtml

Generated Web User Interface contains such type of pages:
1. Grid with filters and sorting
2. Crud1 edit from
3. CrudN edit from
4. Attach/detach 1 to N entities
5. Attach/detach M to N entities



