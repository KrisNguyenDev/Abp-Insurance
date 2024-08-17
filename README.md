
# Angular

npm install

npm run dev

# Abp web api
1. Cấu hình lại 2 file appsettings.json ở project Inspol.DbMigrator và Inspol.HttpApi.Host

```bash
  {
  "ConnectionStrings": {
    "Default": "Server=VNHQ1GPCL031;Database=InspolDatabase;Trusted_Connection=True;TrustServerCertificate=true"
  },
  "OpenIddict": {
    "Applications": {
      "Inspol_App": {
        "ClientId": "Inspol_App",
        "RootUrl": "http://localhost:4200"
      },

      "Inspol_Swagger": {
        "ClientId": "Inspol_Swagger",
        "RootUrl": "https://localhost:44340/"
      },

      "React_Spa": {
        "ClientId": "React_Spa",
        "RootUrl": "http://localhost:3000"
      }
    }
  }
}
{
  "ConnectionStrings": {
    "Default": "Server=VNHQ1GPCL031;Database=InspolDatabase;Trusted_Connection=True;TrustServerCertificate=true"
  },
  "OpenIddict": {
    "Applications": {
      "Inspol_App": {
        "ClientId": "Inspol_App",
        "RootUrl": "http://localhost:4200"
      },

      "Inspol_Swagger": {
        "ClientId": "Inspol_Swagger",
        "RootUrl": "https://localhost:44340/"
      },

      "React_Spa": {
        "ClientId": "React_Spa",
        "RootUrl": "http://localhost:3000"
      }
    }
  }
}

```

2. Run project Inspol.DbMigrator để cập nhật DB

3. Run Inspol.HttpApi.Host để chạy project

