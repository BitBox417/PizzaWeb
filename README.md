🍕 PizzaKing — ASP.NET Core MVC 網站專案
PizzaKing 是一個使用 ASP.NET Core MVC 開發的披薩訂購網站，結合 Entity Framework Core 和 SQLite 資料庫，並整合 Identity 架構提供完整的會員登入註冊功能。

📌 專案特色
✔️ MVC 架構實作：Models、Views、Controllers 分工清晰

✔️ 使用 Entity Framework Core 進行資料庫操作

✔️ 整合 SQLite，並透過 Migration 管理資料結構

✔️ 身份驗證系統：使用 ASP.NET Identity 實作註冊/登入

✔️ ViewModels 與 Razor View 協作展示資料


🔧 技術架構
.NET 6 / .NET 7

ASP.NET Core MVC

Entity Framework Core

SQLite

ASP.NET Core Identity

Razor Pages


🚀 快速啟動
# 1. 克隆專案
git clone https://github.com/yourname/PizzaKing.git
cd PizzaKing/PizzaKing

# 2. 建立資料庫
dotnet ef database update

# 3. 執行網站
dotnet run
