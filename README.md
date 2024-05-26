# Address Book Web API

The Address Book Web API is a RESTful API built with C# and ASP.NET Core for managing a book address. It provides CRUD (Create, Read, Update, Delete) functionality for address entries.

## Controllers

The API consists of the following controllers:

- **ContactsController**: Handles CRUD operations for managing contact entries.

## DTOs (Data Transfer Objects)

The following DTO (Data Transfer Object) is used for data exchange between the API and clients:

- **ContactDTO**: Represents the data structure for a contact entry.

## Services

The API includes the following services:

- **IContactService**: Interface defining contract for contact-related operations.
- **ContactService**: Implementation of the contact service interface for handling contact operations.

## Mappers

The API uses AutoMapper for mapping between entity models and DTOs. The following mappers are defined:

- **AutoMapperConfig**: Configuration for AutoMapper mappings between Contact entity and ContactDTO.
- **MyMapper**: Additional custom mapper for mapping between Contact entity and ContactDTO.

## Getting Started

To get started with the Address Book Web API, follow these steps:

1. Clone the repository: `git clone https://github.com/sabbatj/AddressBookWebAPI.git`
2. Open the solution in Visual Studio or your preferred IDE.
3. Build and run the project.
4. Use tools like Postman or Swagger UI to interact with the API endpoints.

## Future Enhancements

- Integration with Angular frontend for a complete web application experience.
