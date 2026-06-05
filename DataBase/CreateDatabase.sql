CREATE TABLE Roles
(
    RoleId   INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Users
(
    UserId   INT IDENTITY(1,1) PRIMARY KEY,
    Login    NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(150) NOT NULL,
    RoleId   INT NOT NULL,
    CONSTRAINT FK_Users_Roles FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
GO

CREATE TABLE Categories
(
    CategoryId   INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Manufacturers
(
    ManufacturerId   INT IDENTITY(1,1) PRIMARY KEY,
    ManufacturerName NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Suppliers
(
    SupplierId   INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Units
(
    UnitId   INT IDENTITY(1,1) PRIMARY KEY,
    UnitName NVARCHAR(30) NOT NULL UNIQUE
);
GO

CREATE TABLE Products
(
    ProductId      INT IDENTITY(1,1) PRIMARY KEY,
    ProductName    NVARCHAR(200) NOT NULL,
    Description    NVARCHAR(1000) NULL,
    CategoryId     INT NOT NULL,
    ManufacturerId INT NOT NULL,
    SupplierId     INT NOT NULL,
    UnitId         INT NOT NULL,
    Price          DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    Quantity       INT NOT NULL CHECK (Quantity >= 0),
    Discount       INT NOT NULL DEFAULT 0 CHECK (Discount BETWEEN 0 AND 100),
    ImagePath      NVARCHAR(300) NULL,
    Article        NVARCHAR(50) NULL,
    CONSTRAINT FK_Products_Categories    FOREIGN KEY (CategoryId)     REFERENCES Categories(CategoryId),
    CONSTRAINT FK_Products_Manufacturers FOREIGN KEY (ManufacturerId) REFERENCES Manufacturers(ManufacturerId),
    CONSTRAINT FK_Products_Suppliers     FOREIGN KEY (SupplierId)     REFERENCES Suppliers(SupplierId),
    CONSTRAINT FK_Products_Units         FOREIGN KEY (UnitId)         REFERENCES Units(UnitId)
);
GO

CREATE TABLE OrderStatuses
(
    StatusId   INT IDENTITY(1,1) PRIMARY KEY,
    StatusName NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE PickupPoints
(
    PickupPointId INT IDENTITY(1,1) PRIMARY KEY,
    Address       NVARCHAR(300) NOT NULL UNIQUE
);
GO

CREATE TABLE Orders
(
    OrderId       INT IDENTITY(1,1) PRIMARY KEY,
    OrderCode     NVARCHAR(20) NOT NULL UNIQUE,
    StatusId      INT NOT NULL,
    PickupPointId INT NOT NULL,
    OrderDate     DATE NOT NULL,
    DeliveryDate  DATE NULL,
    UserId        INT NULL,
    PickupCode    NVARCHAR(10) NULL,
    CONSTRAINT FK_Orders_Statuses     FOREIGN KEY (StatusId)      REFERENCES OrderStatuses(StatusId),
    CONSTRAINT FK_Orders_PickupPoints FOREIGN KEY (PickupPointId) REFERENCES PickupPoints(PickupPointId),
    CONSTRAINT FK_Orders_Users        FOREIGN KEY (UserId)        REFERENCES Users(UserId)
);
GO

CREATE TABLE OrderItems
(
    OrderItemId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId     INT NOT NULL,
    ProductId   INT NOT NULL,
    Quantity    INT NOT NULL CHECK (Quantity > 0),
    CONSTRAINT FK_OrderItems_Orders   FOREIGN KEY (OrderId)   REFERENCES Orders(OrderId)   ON DELETE CASCADE,
    CONSTRAINT FK_OrderItems_Products FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);
GO

INSERT INTO Roles (RoleName) VALUES 
(N'Клиент'),
(N'Менеджер'),
(N'Администратор');
GO

INSERT INTO Users (Login, Password, FullName, RoleId) VALUES
(N'94d5ous@gmail.com', N'uzWC67', N'Никифорова Анна Семеновна', 3),
(N'uth4iz@mail.com', N'2L6KZG', N'Стелина Евгения Петровна', 3),
(N'5d4zbu@tutanota.com', N'rwVDh9', N'Михайлюк Анна Вячеславовна', 3),
(N'ptec8ym@yahoo.com', N'LdNyos', N'Ситдикова Елена Анатольевна', 2),
(N'1qz4kw@mail.com', N'gynQMT', N'Ворсин Петр Евгеньевич', 2),
(N'4np6se@mail.com', N'AtnDjr', N'Старикова Елена Павловна', 2),
(N'yzls62@outlook.com', N'JlFRCZ', N'Никифорова Весения Николаевна', 1),
(N'1diph5e@tutanota.com', N'8ntwUp', N'Сазонов Руслан Германович', 1),
(N'tjde7c@yahoo.com', N'YOyhfR', N'Одинцов Серафим Артёмович', 1),
(N'wpmrc3do@tutanota.com', N'RSbvHv', N'Степанов Михаил Артёмович', 1);
GO

INSERT INTO Categories (CategoryName) VALUES
(N'Художественная литература'),
(N'Учебник для вузов'),
(N'Хрестоматия'),
(N'Учебное пособие');
GO

INSERT INTO Manufacturers (ManufacturerName) VALUES
(N'Яуза'), (N'Т8 Издательские технологии'), (N'Прогресс книга'),
(N'Время'), (N'Лениздат'), (N'Неолит'), (N'Амрита-Русь'),
(N'Златоуст'), (N'Аспект Пресс'), (N'ВКН');
GO

INSERT INTO Suppliers (SupplierName) VALUES
(N'Виктор Астафьев'), (N'Гилберт Кит Честертон'), (N'Кирилл Каланджи'),
(N'Людмила Улицкая'), (N'Аркадий Гайдар'), (N'Юрий Родичев'),
(N'Дэниел Джей Барретт'), (N'Шон Кэрролл'), (N'Яков Гордин'),
(N'Иосиф Бродский'), (N'Янь Чуннянь'), (N'Дмитрий Мережковский'),
(N'Дмитрий Щербаков'), (N'Роджер Осборн, Дэн Стерджис'),
(N'Любовь Беликова, Инна Ерофеева, Татьяна Шутова'), (N'Сергей Моргачев'),
(N'Екатерина Габарта, Ирина Игнатьева'), (N'Татьяна Лопаткина, Софья Маннапова');
GO

INSERT INTO Units (UnitName) VALUES (N'шт');
GO

INSERT INTO Products (ProductName, Description, CategoryId, ManufacturerId, SupplierId, UnitId, Price, Quantity, Discount, ImagePath, Article) VALUES
(N'Прокляты и убиты', N'Роман-эпопея Виктора Астафьева', 1, 1, 1, 1, 585, 6, 25, N'1.jpg', N'А112Т4'),
(N'Тайны и загадки отца Брауна', N'Классические детективы', 1, 1, 2, 1, 193, 9, 30, N'2.jpg', N'G843H5'),
(N'Девайс', N'Фантастический роман', 1, 2, 3, 1, 1599, 12, 5, N'3.jpg', N'D325D4'),
(N'Необыкновенное обыкновенное чудо', N'Школьные истории', 1, 2, 4, 1, 549, 15, 15, N'4.jpg', N'S432T5'),
(N'Чук и Гек', N'Повести и рассказы', 1, 2, 5, 1, 209, 3, 18, N'5.jpg', N'F325D4'),
(N'Информационная безопасность', N'Национальные стандарты РФ', 2, 3, 6, 1, 3899, 3, 22, N'6.jpg', N'G432G6'),
(N'Linux. Командная строка', N'Лучшие практики', 2, 3, 7, 1, 1799, 5, 4, N'7.jpg', N'H542F5'),
(N'Квантовые миры', N'Возникновение пространства-времени', 2, 3, 8, 1, 1349, 4, 5, N'8.jpg', N'C346F5'),
(N'Вселенная', N'Происхождение жизни и космос', 2, 3, 8, 1, 1799, 2, 6, NULL, N'F256G6'),
(N'Пушкин. Бродский. Империя и судьба', N'Комплект из 2 томов', 3, 4, 9, 1, 529, 6, 8, N'10.jpg', N'J532V5'),
(N'Иосиф Бродский. Избранные эссе', N'Комплект из 6 книг', 3, 5, 10, 1, 4925, 24, 2, N'11.jpg', N'G643F4'),
(N'Тысячелетие императорской керамики', N'История китайского фарфора', 3, 5, 11, 1, 2599, 4, 5, N'12.jpg', N'J326V5'),
(N'Вечные спутники', N'Портреты из всемирной литературы', 3, 5, 12, 1, 1599, 6, 0, N'13.jpg', N'J632F6'),
(N'Формирование литературной репутации Н.Г.Чернышевского', N'Монография', 3, 6, 13, 1, 1349, 8, 2, N'14.jpg', N'G632H6'),
(N'Теория искусства. Краткий путеводитель', N'', 3, 6, 14, 1, 879, 2, 3, N'15.jpg', N'M642E5'),
(N'Религиозные верования', N'С древнейших времен до наших дней', 3, 7, 13, 1, 879, 6, 4, N'16.jpg', N'G543F5'),
(N'Русский язык: Первые шаги. Часть 3', N'Учебное пособие', 4, 8, 15, 1, 2699, 9, 8, N'17.jpg', N'B653G6'),
(N'Синтетический образ индивидуального психического мира', N'', 3, 8, 16, 1, 1099, 4, 9, N'18.jpg', N'J735J7'),
(N'Английский язык в спорте', N'Учебное пособие', 4, 9, 17, 1, 1999, 0, 2, N'19.jpg', N'H436H7'),
(N'Лексика и грамматика современного китайского языка', N'', 4, 10, 18, 1, 608, 12, 25, N'20.jpg', N'H475R5');
GO

INSERT INTO OrderStatuses (StatusName) VALUES
(N'Новый'), (N'В обработке'), (N'Готов к выдаче'), (N'Завершён'), (N'Отменён');
GO

INSERT INTO PickupPoints (Address) VALUES
(N'420151, г. Лесной, ул. Вишневая, 32'),
(N'125061, г. Лесной, ул. Подгорная, 8'),
(N'630370, г. Лесной, ул. Шоссейная, 24'),
(N'400562, г. Лесной, ул. Зеленая, 32'),
(N'614510, г. Лесной, ул. Маяковского, 47'),
(N'410542, г. Лесной, ул. Светлая, 46'),
(N'620839, г. Лесной, ул. Цветочная, 8'),
(N'443890, г. Лесной, ул. Коммунистическая, 1');
GO

INSERT INTO Orders (OrderCode, StatusId, PickupPointId, OrderDate, DeliveryDate, UserId, PickupCode) VALUES
(N'ORD-001', 4, 1, '2024-02-27', '2024-04-20', 10, N'901'),
(N'ORD-002', 4, 2, '2023-09-28', '2024-04-21', 7, N'902'),
(N'ORD-003', 4, 1, '2024-03-21', '2024-04-22', 8, N'903');
GO

INSERT INTO OrderItems (OrderId, ProductId, Quantity) VALUES
(1, 1, 2), (1, 2, 2), (2, 2, 1), (2, 1, 1), (3, 3, 10), (3, 4, 10);
GO

PRINT N'База данных BookStoreDB успешно создана!';
GO