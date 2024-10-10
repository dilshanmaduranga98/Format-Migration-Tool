# Format Migration Tool

This repository contains a .NET application for transforming YAML API templates. It is designed to read input YAML files, process them, and produce output YAML files.

## File Structure
```
FORMAT-MIGRATION-TOOL/ 
├── bin/ 
├── data/ # Store input YAML files 
│ └── api.yaml
├── obj/ 
├── outPut/ # Store output YAML files 
│ └── output.yaml
├── ApiTemplateTransformer.csproj 
├── ApiTemplateTransformer.sln 
├── OutputApiTemplate.cs   
└── Program.cs
```


## Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

### Setup

1. **Clone the repository**:

   ```bash
   git clone <repository-url>
   cd FORMAT-MIGRATION-TOOL


### Add your input YAML file:

Place your input YAML file(s) in the data folder. The application expects an api.yaml file to be present.

# Build and Run
Build the application:

1. **Open your terminal and run**:
    ```bash
    dotnet build

2. **Run the application**:
    ```bash
    dotnet run

# Output
The processed output YAML files will be stored in the outPut folder.

    
    ├── outPut/ # Store output YAML files 
      └── output.yaml
    

---
---

Feel free to adjust the content to better fit your project and needs! Let me know if you need any modifications or further assistance.