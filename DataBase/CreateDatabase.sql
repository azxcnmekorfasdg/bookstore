create table Roles
(
    roleid   int identity(1,1) primary key,
    rolename nvarchar(50) not null unique
);
go

create table Users
(
    userid   int identity(1,1) primary key,
    login    nvarchar(100) not null unique,
    password nvarchar(100) not null,
    fullname nvarchar(150) not null,
    roleid   int not null,
    constraint fk_users_roles foreign key (roleid) references roles(roleid)
);
go

create table Categories
(
    categoryid   int identity(1,1) primary key,
    categoryname nvarchar(100) not null unique
);
go
)
create table Manufacturers
(
    manufacturerid   int identity(1,1) primary key,
    manufacturername nvarchar(100) not null unique
);
go

create table Suppliers
(
    supplierid   int identity(1,1) primary key,
    supplyname nvarchar(100) not null unique
);
go

create table Units
(
    unitid   int identity(1,1) primary key,
    unitname nvarchar(30) not null unique
);
go

create table Products
(
    productid      int identity(1,1) primary key,
    productname    nvarchar(200) not null,
    description    nvarchar(1000) null,
    categoryid     int not null,
    manufacturerid int not null,
    supplierid     int not null,
    unitid         int not null,
    price          decimal(10,2) not null check (price >= 0),
    quantity       int not null check (quantity >= 0),
    discount       int not null default 0 check (discount between 0 and 100),
    imagepath      nvarchar(300) null,
    article        nvarchar(50) null,
    constraint fk_products_categories    foreign key (categoryid)     references categories(categoryid),
    constraint fk_products_manufacturers foreign key (manufacturerid) references manufacturers(manufacturerid),
    constraint fk_products_suppliers     foreign key (supplierid)     references suppliers(supplierid),
    constraint fk_products_units         foreign key (unitid)         references units(unitid)
);
go

create table OrderStatuses
(
    statusid   int identity(1,1) primary key,
    statusname nvarchar(50) not null unique
);
go

create table PickupPoints
(
    pickuppointid int identity(1,1) primary key,
    address       nvarchar(300) not null unique
);
go

create table Orders
(
    orderid       int identity(1,1) primary key,
    ordercode     nvarchar(20) not null unique,
    statusid      int not null,
    pickuppointid int not null,
    orderdate     date not null,
    deliverydate  date null,
    userid        int null,
    pickupcode    nvarchar(10) null,
    constraint fk_orders_statuses     foreign key (statusid)      references orderstatuses(statusid),
    constraint fk_orders_pickuppoints foreign key (pickuppointid) references pickuppoints(pickuppointid),
    constraint fk_orders_users        foreign key (userid)        references users(userid)
);
go

create table OrderItems
(
    orderitemid int identity(1,1) primary key,
    orderid     int not null,
    productid   int not null,
    quantity    int not null check (quantity > 0),
    constraint fk_orderitems_orders   foreign key (orderid)   references orders(orderid)   on delete cascade,
    constraint fk_orderitems_products foreign key (productid) references products(productid)
);
go

insert into roles (rolename) values 
(N'клиент'),
(N'менеджер'),
(N'администратор');
go

insert into users (login, password, fullname, roleid) values
(N'94d5ous@gmail.com', N'uzWC67', N'никифорова анна семеновна', 3),
(N'uth4iz@mail.com', N'2L6KZG', N'стелина евгения петровна', 3),
(N'5d4zbu@tutanota.com', N'rwVDh9', N'михайлюк анна вячеславовна', 3),
(N'ptec8ym@yahoo.com', N'LdNyos', N'ситдикова елена анатольевна', 2),
(N'1qz4kw@mail.com', N'gynQMT', N'ворсин петр евгеньевич', 2),
(N'4np6se@mail.com', N'AtnDjr', N'старикова елена павловна', 2),
(N'yzls62@outlook.com', N'JlFRCZ', N'никифорова весения николаевна', 1),
(N'1diph5e@tutanota.com', N'8ntwUp', N'сазонов руслан германович', 1),
(N'tjde7c@yahoo.com', N'YOyhfR', N'одинцов серафим артёмович', 1),
(N'wpmrc3do@tutanota.com', N'RSbvHv', N'степанов михаил артёмович', 1);
go

insert into categories (categoryname) values
(N'художественная литература'),
(N'учебник для вузов'),
(N'хрестоматия'),
(N'учебное пособие');
go

insert into manufacturers (manufacturername) values
(N'яуза'), (N'т8 издательские технологии'), (N'прогресс книга'),
(N'время'), (N'лениздат'), (N'неолит'), (N'амрита-русь'),
(N'златоуст'), (N'аспект пресс'), (N'вкн');
go

insert into suppliers (supplyname) values
(N'виктор астафьев'), (N'гилберт кит честертон'), (N'кирилл каланджи'),
(N'людмила улицкая'), (N'аркадий гайдар'), (N'юрий родичев'),
(N'дэниел джей барретт'), (N'шон кэрролл'), (N'яков гордин'),
(N'иосиф бродский'), (N'янь чуннянь'), (N'дмитрий мережковский'),
(N'дмитрий щербаков'), (N'роджер осборн, дэн стерджис'),
(N'любовь беликова, инна ерофеева, татьяна шутова'), (N'сергей моргачев'),
(N'екатерина габарта, ирина игнатьева'), (N'татьяна лопаткина, софья маннапова');
go

insert into units (unitname) values (N'шт');
go

insert into products (productname, description, categoryid, manufacturerid, supplierid, unitid, price, quantity, discount, imagepath, article) values
(N'прокляты и убиты', N'роман-эпопея виктора астафьева', 1, 1, 1, 1, 585, 6, 25, N'1.jpg', N'а112т4'),
(N'тайны и загадки отца брауна', N'классические детективы', 1, 1, 2, 1, 193, 9, 30, N'2.jpg', N'g843h5'),
(N'девайс', N'фантастический роман', 1, 2, 3, 1, 1599, 12, 5, N'3.jpg', N'd325d4'),
(N'необыкновенное обыкновенное чудо', N'школьные истории', 1, 2, 4, 1, 549, 15, 15, N'4.jpg', N's432t5'),
(N'чук и гек', N'повести и рассказы', 1, 2, 5, 1, 209, 3, 18, N'5.jpg', N'f325d4'),
(N'информационная безопасность', N'национальные стандарты рф', 2, 3, 6, 1, 3899, 3, 22, N'6.jpg', N'g432g6'),
(N'linux. командная строка', N'лучшие практики', 2, 3, 7, 1, 1799, 5, 4, N'7.jpg', N'h542f5'),
(N'квантовые миры', N'возникновение пространства-времени', 2, 3, 8, 1, 1349, 4, 5, N'8.jpg', N'c346f5'),
(N'вселенная', N'происхождение жизни и космос', 2, 3, 8, 1, 1799, 2, 6, null, N'f256g6'),
(N'пушкин. бродский. империя и судьба', N'комплект из 2 томов', 3, 4, 9, 1, 529, 6, 8, N'10.jpg', N'j532v5'),
(N'иосиф бродский. избранные эссе', N'комплект из 6 книг', 3, 5, 10, 1, 4925, 24, 2, N'11.jpg', N'g643f4'),
(N'тысячелетие императорской керамики', N'история китайского фарфора', 3, 5, 11, 1, 2599, 4, 5, N'12.jpg', N'j326v5'),
(N'вечные спутники', N'портреты из всемирной литературы', 3, 5, 12, 1, 1599, 6, 0, N'13.jpg', N'j632f6'),
(N'формирование литературной репутации н.г.чернышевского', N'монография', 3, 6, 13, 1, 1349, 8, 2, N'14.jpg', N'g632h6'),
(N'теория искусства. краткий путеводитель', N'', 3, 6, 14, 1, 879, 2, 3, N'15.jpg', N'm642e5'),
(N'религиозные верования', N'с древнейших времен до наших дней', 3, 7, 13, 1, 879, 6, 4, N'16.jpg', N'g543f5'),
(N'русский язык: первые шаги. часть 3', N'учебное пособие', 4, 8, 15, 1, 2699, 9, 8, N'17.jpg', N'b653g6'),
(N'синтетический образ индивидуального психического мира', N'', 3, 8, 16, 1, 1099, 4, 9, N'18.jpg', N'j735j7'),
(N'английский язык в спорте', N'учебное пособие', 4, 9, 17, 1, 1999, 0, 2, N'19.jpg', N'h436h7'),
(N'лексика и грамматика современного китайского языка', N'', 4, 10, 18, 1, 608, 12, 25, N'20.jpg', N'h475r5');
go

insert into orderstatuses (statusname) values
(N'новый'), (N'в обработке'), (N'готов к выдаче'), (N'завершён'), (N'отменён');
go

insert into pickuppoints (address) values
(N'420151, г. лесной, ул. вишневая, 32'),
(N'125061, г. лесной, ул. подгорная, 8'),
(N'630370, г. лесной, ул. шоссейная, 24'),
(N'400562, г. лесной, ул. зеленая, 32'),
(N'614510, г. лесной, ул. маяковского, 47'),
(N'410542, г. лесной, ул. светлая, 46'),
(N'620839, г. лесной, ул. цветочная, 8'),
(N'443890, г. лесной, ул. коммунистическая, 1');
go

insert into orders (ordercode, statusid, pickuppointid, orderdate, deliverydate, userid, pickupcode) values
(N'ord-001', 4, 1, '2024-02-27', '2024-04-20', 10, N'901'),
(N'ord-002', 4, 2, '2023-09-28', '2024-04-21', 7, N'902'),
(N'ord-003', 4, 1, '2024-03-21', '2024-04-22', 8, N'903');
go

insert into orderitems (orderid, productid, quantity) values
(1, 1, 2), (1, 2, 2), (2, 2, 1), (2, 1, 1), (3, 3, 10), (3, 4, 10);
go