# FilterSortPaginApi

This project is an API built to demonstrate filtering, sorting, and pagination functionalities for managing and displaying data effectively. It provides robust mechanisms to query large datasets with precision and flexibility.

## Features

- **Filtering**: Apply filters to narrow down data results based on specific conditions or criteria.
- **Sorting**: Sort results by multiple fields in ascending or descending order.
- **Pagination**: Paginate large datasets into manageable chunks, allowing efficient data retrieval.
- **Flexible Query Parameters**: Easily configure which fields to filter or sort by using URL query parameters.
  
## Technologies Used

- **ASP.NET Core**: Backend framework for building the API.
- **Entity Framework Core**: ORM for handling data access and database interactions.
- **SQL Server**: Database to store and query data.
- **Swagger UI**: API documentation and testing tool.

## API Endpoints

### GET /api/items
Retrieve a list of items with optional filtering, sorting, and pagination.

#### Query Parameters:
- `filterField`: The field to filter by (e.g., name, category).
- `filterValue`: The value to filter on.
- `sortField`: The field to sort the results by.
- `sortOrder`: The sort order (`asc` or `desc`).
- `page`: The page number to retrieve.
- `pageSize`: The number of items per page.

### Example Request:
```http
GET /api/items?filterField=name&filterValue=example&sortField=date&sortOrder=asc&page=1&pageSize=10
```

### Example Response:
```json
{
  "data": [
    {
      "id": 1,
      "name": "Item 1",
      "category": "Category A",
      "date": "2023-10-15"
    },
    ...
  ],
  "totalCount": 100,
  "page": 1,
  "pageSize": 10
}
```

## Getting Started

### Prerequisites:
- [.NET SDK](https://dotnet.microsoft.com/download)
- SQL Server

### Setup:
1. Clone the repository:
   ```bash
   git clone https://github.com/abdorhl/FilterSortPaginApi.git
   ```
2. Navigate to the project directory:
   ```bash
   cd FilterSortPaginApi
   ```
3. Update the `appsettings.json` file with your database connection string.
4. Run the migrations to set up the database:
   ```bash
   dotnet ef database update
   ```
5. Run the project:
   ```bash
   dotnet run
   ```

### Using Swagger:
Once the application is running, open your browser and navigate to `https://localhost:{port}/swagger` to view and test the available API endpoints.

## Contributing

Contributions are welcome! Please feel free to open an issue or submit a pull request.
