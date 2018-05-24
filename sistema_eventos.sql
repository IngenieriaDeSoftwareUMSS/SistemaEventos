/*==============================================================*/
/* Table: CATEGORIA                                             */
/*==============================================================*/
create table CATEGORIA (
   ID_CATEGORIA         int                  not null,
   NOMBRE_CATEGORIA     varchar(50)          not null,
   COLOR_CATEGORIA      varchar(20)          not null,
   DESCRIPCION_CATEGORIA varchar(100)         not null,
   constraint PK_CATEGORIA primary key (ID_CATEGORIA)
)
go

/*==============================================================*/
/* Table: EVENTO                                                */
/*==============================================================*/
create table EVENTO (
   ID_EVENTO            int                  not null,
   NOMBRE_EVENTO        varchar(50)          not null,
   DESCRIPCION_EVENTO   varchar(200)         not null,
   FECHA_INICIO         datetime             not null,
   FECHA_FIN            datetime             not null,
   DIRECCION_EVENTO     varchar(100)         not null,
   MAPA_LONGITUD        double precision     not null,
   MAPA_LATITUD         double precision     not null,
   COSTO_EVENTO         money                not null,
   constraint PK_EVENTO primary key (ID_EVENTO)
)
go

/*==============================================================*/
/* Table: GALERIA                                               */
/*==============================================================*/
create table GALERIA (
   ID_GALERIA           int                  not null,
   ID_EVENTO            int                  not null,
   IMAGEN_EVENTO        image                not null,
   constraint PK_GALERIA primary key (ID_GALERIA)
)
go


/*==============================================================*/
/* Table: LISTA_AMIGOS                                          */
/*==============================================================*/
create table LISTA_AMIGOS (
   ID_AMIGO       	int                  not null,
   ID_USUARIO           int                  not null,
   constraint PK_LISTA_AMIGOS primary key (ID_AMIGO, ID_USUARIO)
)
go


/*==============================================================*/
/* Table: Lista_categorias                                       */
/*==============================================================*/
create table LISTA_CATEGORIAS (
   ID_EVENTO            int                  not null,
   ID_CATEGORIA         int                  not null,
   constraint PK_LISTA_CATEGORIAS primary key (ID_EVENTO, ID_CATEGORIA)
)
go



/*==============================================================*/
/* Table: USUARIO_EVENTO                                        */
/*==============================================================*/
create table USUARIO_EVENTO (
   ID_USUARIO           int                  not null,
   ID_EVENTO            int                  not null,
   CREADOR              bit	             not null,
constraint PK_USUARIO_EVENTO primary key (ID_USUARIO, ID_EVENTO)
)
go


/*==============================================================*/
/* Table: USUARIO_REGISTRADO                                    */
/*==============================================================*/
create table USUARIO_REGISTRADO (
   ID_USUARIO           int                  not null,
   MAIL_USUARIO         varchar(50)          not null,
   PASSWORD             varchar(50)          not null,
   NOMBRE_USUARIO       varchar(50)          not null,
   APELLIDO_USUARIO     varchar(50)          not null,
   FECHA_NACIMIENTO     datetime             not null,
   constraint PK_USUARIO_REGISTRADO primary key (ID_USUARIO)
)
go

alter table GALERIA
   add constraint FK_GALERIA_EVENTO foreign key (ID_EVENTO)
      references EVENTO (ID_EVENTO)
go

alter table LISTA_AMIGOS
   add constraint FK_LISTA_USUARIO_AMIGOS foreign key (ID_AMIGO)
      references USUARIO_REGISTRADO (ID_USUARIO)
go

alter table LISTA_AMIGOS
   add constraint FK_LISTA_AMIGOS foreign key (ID_USUARIO)
      references USUARIO_REGISTRADO (ID_USUARIO)
go

alter table LISTA_CATEGORIAS
   add constraint FK_CATEGORIA_EVENTO foreign key (ID_EVENTO)
      references EVENTO (ID_EVENTO)
go

alter table LISTA_CATEGORIAS
   add constraint FK_EVENTO_CATEGORIA foreign key (ID_CATEGORIA)
      references CATEGORIA (ID_CATEGORIA)
go

alter table USUARIO_EVENTO
   add constraint FK_EVENTO_USUARIO foreign key (ID_USUARIO)
      references USUARIO_REGISTRADO (ID_USUARIO)
go

alter table USUARIO_EVENTO
   add constraint FK_USUARIO_EVENTO foreign key (ID_EVENTO)
      references EVENTO (ID_EVENTO)
go

