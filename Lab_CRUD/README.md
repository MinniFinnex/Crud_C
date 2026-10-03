# Lab CRUD - Login en C# Windows Forms (.NET)

Aplicación de Login con **Windows Forms** en C# conectada a la base de datos MariaDB / MySQL en `localhost`.

---

## Requisito que se usó

- **DBEAVER MARIADB/MYSQL**  activo en `localhost:3306`.
- **.NET SDK** y **Mono** (para compilar y ejecutar en Linux).

---

## SQL

```sql
CREATE DATABASE IF NOT EXISTS login;
USE login;

CREATE TABLE IF NOT EXISTS username (
  Nombre VARCHAR(50) NOT NULL,
  password VARCHAR(30) NOT NULL
);

-- USER
INSERT INTO username (Nombre, password) VALUES ('admin', 'admin123');
```

---
