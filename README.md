# Google-Form(Using Visual Basic Language and Typescript)
This application consists of a frontend built with VB.NET and a backend built with Node.js and TypeScript. The application allows users to create submissions and view them. The submissions include details like name, email, phone number, GitHub link, and the time recorded by a stopwatch. The data is stored in a local JSON file (db.json).
## FRONTEND
The frontend of this application is built using VB.NET in a Windows Forms application. The application allows users to create and view submissions, which include details like name, email, phone number, GitHub link, and the time recorded by a stopwatch.

**Prerequisites**
- Visual Studio (with .NET desktop development workload)
- VB.NET
- Ensure that all required NuGet packages are restored.
  
-The frontend application has three main forms: Form1, CreateSubmissionForm, and ViewSubmissionsForm.
### Form1 (Main Form)
The main form provides navigation to the "Create Submission" and "View Submissions" forms.
### CreateSubmissionForm
This form allows users to create a new submission. Users can enter details like name, email, phone number, GitHub link, and record the time using a stopwatch.
### ViewSubmissionsForm
This form allows users to view previously submitted submissions. Users can navigate through submissions using the previous and next buttons or keyboard shortcuts.

## BACKEND SETUP AND INSTRUCTIONS
The backend of this application is built using Node.js with TypeScript. It leverages Express.js for the server framework and jsonfile for handling JSON file operations.

### Backend setup
- ├── src/
- │   ├── index.ts
- │   ├── db.json
- ├── tsconfig.json
- ├── package.json
### index.ts
The main entry point for the backend server, written in TypeScript. It sets up the Express server, handles routing, and manages data storage.
### db.json
JSON file used to store submissions data. The file contains an array of submissions, each with details such as id, Name, Email, PhoneNumber, GitHubLink, and StopwatchTime.
### tsconfig.json
Configuration file for TypeScript. It specifies compiler options and the files to be included in the compilation.
### package.json
This file contains metadata about the project and manages its dependencies.

**Dependencies**
- Express: A web framework for Node.js used to build the RESTful API.
- Body-parser: Middleware to parse incoming request bodies.
- Jsonfile: A module for reading and writing JSON files.
- TypeScript: A typed superset of JavaScript that compiles to plain JavaScript.
- Ts-node: A TypeScript execution environment and REPL for Node.js.
  
**Dev Dependencies**
- @types/body-parser: Type definitions for body-parser.
- @types/express: Type definitions for express.
- @types/node: Type definitions for Node.js.
- ts-node: To run TypeScript directly.
- typescript: To compile TypeScript code.
  
### Installations
- Install all necessary packages with npm
- make sure the db.json should need to be empty
- open the new terminal and start the server by writing npm start
- The server starts running on the localhost:3000

## Conclusion
By following these setup instructions, you can set up, run, and interact with both the frontend and backend of the Submission Application. Ensure the backend server is running before interacting with the frontend application for proper data submissions and retrievals. If you encounter any issues, check the server logs and Visual Studio output for debugging information.
