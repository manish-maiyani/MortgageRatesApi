**Mortgage Rates API**<br>
A minimal .NET Core Web API that provides mortgage rate data via a GET /api/rates?loanType=owner-occupied&term=30 endpoint, returning static/mock JSON data.

**Setup Instructions**
1. Clone the repository:<br>
	git clone https://github.com/manish-maiyani/MortgageRatesApi.git<br>
	cd MortgageRatesApi
2. Restore dependencies:<br>
	dotnet restore
3. Run the application:<br>
	dotnet run
4. The API will be available at https://localhost:7282 or http://localhost:5239.

**Usage**
- **Endpoint:**<br> GET /api/rates?loanType=owner-occupied&term=30
- **Example Request:**<br>
	curl "https://localhost:7282/api/rates?loanType=owner-occupied&term=30"
- **Example Response:**<br>
	{<br>
		"loanType": "owner-occupied",<br>
		"term": 30,<br>
		"interestRate": 5.25<br>
	}
- **Error Responses:**<br>
	400 Bad Request: Invalid loanType or term.<br>
	404 Not Found: No rates found for the specified criteria.

**Design Notes**
- Follows **SOLID** principles:<br>
	**Single Responsibility:** Each class handles one concern (e.g., controller for HTTP, service for data).<br>
	**Open/Closed:** Extensible via dependency injection.<br>
	**Interface Segregation:** IRateService defines only necessary methods.<br>
	**Dependency Inversion:** Controller depends on IRateService abstraction.<br>
- Uses dependency injection for loose coupling.<br>
- Includes input validation and error handling.

**Testing**<br>
- Use tools like Postman or curl to test the endpoint.<br>
- Example invalid request: GET /api/rates?loanType=invalid&term=0 returns a 400 error.

**Notes**<br>
- This is a minimal implementation with mock data. In a real application, replace RateService with a database-backed service.<br>
- The API runs in development mode with a developer exception page for easier debugging.

