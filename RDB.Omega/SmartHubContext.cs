using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RDB.Omega.SmartHub;

namespace RDB.Omega;

public partial class SmartHubContext : DbContext
{
    private readonly string _connectionString = "";
    private readonly bool _viewQuery = false;

    public SmartHubContext()
    {
    }

    public SmartHubContext(string conn)
    {
        this._connectionString = conn;
    }

    public SmartHubContext(string conn, bool viewQuery)
    {
        this._connectionString = conn;
        this._viewQuery = viewQuery;
    }

    public SmartHubContext(DbContextOptions<SmartHubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuditoriaOv> AuditoriaOvs { get; set; }

    public virtual DbSet<AuditoriaSbc> AuditoriaSbcs { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Continente> Continentes { get; set; }

    public virtual DbSet<Correo> Correos { get; set; }

    public virtual DbSet<RDB.Omega.SmartHub.Enum> Enums { get; set; }

    public virtual DbSet<EnumTrad> EnumTrads { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Insignia> Insignias { get; set; }

    public virtual DbSet<Interaccione> Interacciones { get; set; }

    public virtual DbSet<IntervalosRendimiento> IntervalosRendimientos { get; set; }

    public virtual DbSet<Membresia> Membresias { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<PagosTransaccione> PagosTransacciones { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<PaqueteProducto> PaqueteProductos { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Premio> Premios { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosTemp> ProductosTemps { get; set; }

    public virtual DbSet<ProductosTrad> ProductosTrads { get; set; }

    public virtual DbSet<PromoMembresia> PromoMembresias { get; set; }

    public virtual DbSet<PromoProducto> PromoProductos { get; set; }

    public virtual DbSet<PromoVenta> PromoVentas { get; set; }

    public virtual DbSet<Promocione> Promociones { get; set; }

    public virtual DbSet<Prospecto> Prospectos { get; set; }

    public virtual DbSet<ProspectoDocumentacion> ProspectoDocumentacions { get; set; }

    public virtual DbSet<ProspectoInfo> ProspectoInfos { get; set; }

    public virtual DbSet<ProspectoMedium> ProspectoMedia { get; set; }

    public virtual DbSet<ProspectoValidacion> ProspectoValidacions { get; set; }

    public virtual DbSet<PubCateg> PubCategs { get; set; }

    public virtual DbSet<Publicacione> Publicaciones { get; set; }

    public virtual DbSet<Rango> Rangos { get; set; }

    public virtual DbSet<RangoExcepcione> RangoExcepciones { get; set; }

    public virtual DbSet<RangoReqLinea> RangoReqLineas { get; set; }

    public virtual DbSet<Recurso> Recursos { get; set; }

    public virtual DbSet<Socio> Socios { get; set; }

    public virtual DbSet<SocioAcumuladoNivel> SocioAcumuladoNivels { get; set; }

    public virtual DbSet<SocioAcumuladoNivelHist> SocioAcumuladoNivelHists { get; set; }

    public virtual DbSet<SocioAsignado> SocioAsignados { get; set; }

    public virtual DbSet<SocioBeneficiario> SocioBeneficiarios { get; set; }

    public virtual DbSet<SocioDocumentacion> SocioDocumentacions { get; set; }

    public virtual DbSet<SocioEstatusExt> SocioEstatusExts { get; set; }

    public virtual DbSet<SocioEstrella> SocioEstrellas { get; set; }

    public virtual DbSet<SocioEvaluacionRango> SocioEvaluacionRangos { get; set; }

    public virtual DbSet<SocioInfo> SocioInfos { get; set; }

    public virtual DbSet<SocioKpi> SocioKpis { get; set; }

    public virtual DbSet<SocioKpiHist> SocioKpiHists { get; set; }

    public virtual DbSet<SocioKpiHistBorrar> SocioKpiHistBorrars { get; set; }

    public virtual DbSet<SocioKpiLineaHist> SocioKpiLineaHists { get; set; }

    public virtual DbSet<SocioKpiTest> SocioKpiTests { get; set; }

    public virtual DbSet<SocioListaAsig> SocioListaAsigs { get; set; }

    public virtual DbSet<SocioProducto> SocioProductos { get; set; }

    public virtual DbSet<SocioRenovacione> SocioRenovaciones { get; set; }

    public virtual DbSet<SocioValidacion> SocioValidacions { get; set; }

    public virtual DbSet<SocioWallet> SocioWallets { get; set; }

    public virtual DbSet<SolicitudesRetiro> SolicitudesRetiros { get; set; }

    public virtual DbSet<TipoInteraccione> TipoInteracciones { get; set; }

    public virtual DbSet<VDirecto> VDirectos { get; set; }

    public virtual DbSet<VEstatusMembresium> VEstatusMembresia { get; set; }

    public virtual DbSet<VPlanReserva> VPlanReservas { get; set; }

    public virtual DbSet<VPrimerPlanOmega> VPrimerPlanOmegas { get; set; }

    public virtual DbSet<VRendimientoPi> VRendimientoPis { get; set; }

    public virtual DbSet<VRequisitosFaltante> VRequisitosFaltantes { get; set; }

    public virtual DbSet<VSaldoAcumulado> VSaldoAcumulados { get; set; }

    public virtual DbSet<XMasterBonusLegacy> XMasterBonusLegacies { get; set; }

    public virtual DbSet<XMasterBonusLegacy2> XMasterBonusLegacy2s { get; set; }

    public virtual DbSet<XPagosBlockchain> XPagosBlockchains { get; set; }

    public virtual DbSet<XPagosLegacy> XPagosLegacies { get; set; }

    public virtual DbSet<YSocioAcumuladoNivel> YSocioAcumuladoNivels { get; set; }

    public virtual DbSet<ZComprasPerdida> ZComprasPerdidas { get; set; }

    public virtual DbSet<ZConciliacionTdc> ZConciliacionTdcs { get; set; }

    public virtual DbSet<ZContra> ZContras { get; set; }

    public virtual DbSet<ZInterRecurso> ZInterRecursos { get; set; }

    public virtual DbSet<ZInteraccione> ZInteracciones { get; set; }

    public virtual DbSet<ZListaCompra> ZListaCompras { get; set; }

    public virtual DbSet<ZNivel> ZNivels { get; set; }

    public virtual DbSet<ZPagosAtrasado> ZPagosAtrasados { get; set; }

    public virtual DbSet<ZPubCateg> ZPubCategs { get; set; }

    public virtual DbSet<ZPubPaise> ZPubPaises { get; set; }

    public virtual DbSet<ZPubRecurso> ZPubRecursos { get; set; }

    public virtual DbSet<ZPublicacione> ZPublicaciones { get; set; }

    public virtual DbSet<ZRango> ZRangos { get; set; }

    public virtual DbSet<ZRangoReqLinea> ZRangoReqLineas { get; set; }

    public virtual DbSet<ZRecurso> ZRecursos { get; set; }

    public virtual DbSet<ZRetiroscomisionmala> ZRetiroscomisionmalas { get; set; }

    public virtual DbSet<ZSocioAcumuladoNivel> ZSocioAcumuladoNivels { get; set; }

    public virtual DbSet<ZSocioKpi> ZSocioKpis { get; set; }

    public virtual DbSet<ZTipoInteraccione> ZTipoInteracciones { get; set; }

    public virtual DbSet<ZWalletsMala> ZWalletsMalas { get; set; }

    public virtual DbSet<ZonasHoraria> ZonasHorarias { get; set; }

    /*

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=prod-pos-sql-ome.cnr1vz2jxtct.us-east-1.rds.amazonaws.com;Database=smartov2;Username=smartov2;Password=Sm4r7_0f1c1n4*V1r7u4L!;");

    */

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // optionsBuilder.UseNpgsql(this._connectionString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.12-mariadb"));
            if (this._viewQuery) optionsBuilder.UseNpgsql(this._connectionString).LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            if (!this._viewQuery) optionsBuilder.UseNpgsql(this._connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("aws_commons")
            .HasPostgresExtension("aws_s3")
            .HasPostgresExtension("pgcrypto")
            .HasPostgresExtension("tablefunc");

        modelBuilder.Entity<AuditoriaOv>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_auditoria_ov");

            entity.ToTable("auditoria_ov", tb => tb.HasComment("Tabla con el log de auditoría de las acciones que se realizan en la oficina virtual"));

            entity.Property(e => e.Folio)
                .HasComment("Folio autonumérico del registro")
                .HasColumnName("folio");
            entity.Property(e => e.Accion)
                .HasComment("Acción que realiza el usuario (Enum A2_Acciones)")
                .HasColumnName("accion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(600)
                .HasComment("Descripción de la acción que realiza el usuario")
                .HasColumnName("descripcion");
            entity.Property(e => e.Detalle)
                .HasComment("Detalle de la acción que realiza el usuario (Ver Notas)")
                .HasColumnName("detalle");
            entity.Property(e => e.Elemento)
                .HasMaxLength(200)
                .HasComment("Identificación alterna del objeto (en caso de que el ID sea texto)")
                .HasColumnName("elemento");
            entity.Property(e => e.EsSocio)
                .HasComment("Indica si el usuario es un socio (true) o un prospecto (false)")
                .HasColumnName("es_socio");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("now()")
                .HasComment("fecha y hora ")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.Modulo)
                .HasComment("Módulo desde el que realiza la acción (Enum A2_Modulos)")
                .HasColumnName("modulo");
            entity.Property(e => e.Objeto)
                .HasComment("Id del registro del objeto en cuestión")
                .HasColumnName("objeto");
            entity.Property(e => e.TipoObjeto)
                .HasComment("Tipo de objeto creado o modificado (Enum Au_TipoObjeto)")
                .HasColumnName("tipo_objeto");
            entity.Property(e => e.Usuario)
                .HasComment("Id del Socio o del prospecto")
                .HasColumnName("usuario");
            entity.Property(e => e.Valor)
                .HasMaxLength(200)
                .HasComment("Valor nuevo que toma el elemento o propiedad")
                .HasColumnName("valor");
            entity.Property(e => e.ValorAnterior)
                .HasMaxLength(200)
                .HasColumnName("valor_anterior");
        });

        modelBuilder.Entity<AuditoriaSbc>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_auditoria_sbc");

            entity.ToTable("auditoria_sbc", tb => tb.HasComment("Tabla con el log de auditoría de las acciones que se realiza en el sitio de administración"));

            entity.Property(e => e.Folio)
                .HasComment("Folio autonumérico del registro")
                .HasColumnName("folio");
            entity.Property(e => e.Accion)
                .HasComment("Acción que realiza el usuario (Enum A1_Acciones)")
                .HasColumnName("accion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(600)
                .HasComment("Descripción de la acción que realiza el usuario")
                .HasColumnName("descripcion");
            entity.Property(e => e.Detalle)
                .HasComment("Detalle de la acción que realiza el usuario (Ver Notas)")
                .HasColumnName("detalle");
            entity.Property(e => e.Elemento)
                .HasMaxLength(200)
                .HasComment("Identificación alterna del objeto (en caso de que el ID sea texto)")
                .HasColumnName("elemento");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("now()")
                .HasComment("fecha y hora ")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.Modulo)
                .HasComment("Módulo desde el que realiza la acción (Enum A1_Modulos)")
                .HasColumnName("modulo");
            entity.Property(e => e.Objeto)
                .HasComment("Id del registro del objeto en cuestión")
                .HasColumnName("objeto");
            entity.Property(e => e.TipoObjeto)
                .HasComment("Tipo de objeto creado o modificado (Enum Au_TipoObjeto)")
                .HasColumnName("tipo_objeto");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasComment("Usuario de SBC que realiza la acción")
                .HasColumnName("usuario");
            entity.Property(e => e.Valor)
                .HasMaxLength(200)
                .HasComment("Valor nuevo que toma el elemento o propiedad")
                .HasColumnName("valor");
            entity.Property(e => e.ValorAnterior)
                .HasMaxLength(200)
                .HasColumnName("valor_anterior");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Compra1).HasName("pk_compras");

            entity.ToTable("compras", tb => tb.HasComment("Esta tabla almacena solicitudes de compra de los socios\r\npueden quedarse solo como intensión o concretarse en compra efectiva"));

            entity.HasIndex(e => e.ComplementoDe, "complementodefk");

            entity.HasIndex(e => e.IdLegacy, "idx_id_legacy_compras");

            entity.HasIndex(e => e.Prospecto, "relationship28fk");

            entity.HasIndex(e => e.Socio, "relationship51fk");

            entity.HasIndex(e => e.Promocion, "relationship54fk");

            entity.Property(e => e.Compra1)
                .HasComment("Folio autonumérico de la compra o intención de compra")
                .HasColumnName("compra");
            entity.Property(e => e.AvancePago)
                .HasComment("avance del pago (del 0 al 4)")
                .HasColumnName("avance_pago");
            entity.Property(e => e.ComplementoDe)
                .HasComment("Folio autonumérico de la compra o intención de compra")
                .HasColumnName("complemento_de");
            entity.Property(e => e.CotizaBtc)
                .HasPrecision(17, 8)
                .HasComment("cotización del bitcoin en fiat (cuantos bitcoins por dolar)")
                .HasColumnName("cotiza_btc");
            entity.Property(e => e.CotizaBtc2)
                .HasPrecision(17, 8)
                .HasComment("cotización del bitcoin en fiat (Cuando el tiempo se excedió a los 5 minutos se actualizó)")
                .HasColumnName("cotiza_btc2");
            entity.Property(e => e.EsComplementario)
                .HasComment("indica si este registro es un pago complementario de uno anterior (indicado en \"complemento_de\")")
                .HasColumnName("es_complementario");
            entity.Property(e => e.EsExcedido)
                .HasComment("Indica si el pago se realizó en exceso")
                .HasColumnName("es_excedido");
            entity.Property(e => e.Estatus)
                .HasComment("1=Compra solicitada, 2=Confirmando pago, 3=Pago Insuficiente, 4=Pagado (Ver Notas de la tabla)")
                .HasColumnName("estatus");
            entity.Property(e => e.Etl)
                .HasDefaultValueSql("false")
                .HasComment("Indica si el registro proviene de la migración con ETL")
                .HasColumnName("etl");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPago)
                .HasComment("Fecha y hora de la recepción del pago (debe quedar dentro de los 5 minutos)")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FormaPago)
                .HasComment("Forma de pago (enum FormaPago) 1=Bitcoins, 2=Tarjeta, 3=Transferencia")
                .HasColumnName("forma_pago");
            entity.Property(e => e.FueInsuficiente)
                .HasComment("Indica si el pago fué insuficiente (aunque después se haya subsanado y el estatus haya pasado a Pagado)")
                .HasColumnName("fue_insuficiente");
            entity.Property(e => e.Hash)
                .HasMaxLength(500)
                .HasComment("Hash de la transferencia en bitcoins")
                .HasColumnName("hash");
            entity.Property(e => e.IdLegacy)
                .HasComment("ID del registro original en la db legacy (MySql)")
                .HasColumnName("id_legacy");
            entity.Property(e => e.Item)
                .HasComment("Clave del item (membresía, plan adicional o smart pack) (Ver Notas)")
                .HasColumnName("item");
            entity.Property(e => e.Item2)
                .HasComment("Clave del plan adicional (sólo cuando tipo_item=3:smart_pack) (Ver Notas del campo Item)")
                .HasColumnName("item2");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .HasComment("Moneda")
                .HasColumnName("moneda");
            entity.Property(e => e.MontoPagado)
                .HasComment("Monto en fiat (USD) que pagó el cliente")
                .HasColumnType("money")
                .HasColumnName("monto_pagado");
            entity.Property(e => e.MontoPagadoBtc)
                .HasPrecision(12, 8)
                .HasComment("Monto en BTC que pagó el cliente")
                .HasColumnName("monto_pagado_btc");
            entity.Property(e => e.Precio)
                .HasComment("Precio en moneda fiat (USD normalmente)")
                .HasColumnType("money")
                .HasColumnName("precio");
            entity.Property(e => e.PrecioBtc)
                .HasPrecision(12, 8)
                .HasComment("Precio en bitcoins")
                .HasColumnName("precio_btc");
            entity.Property(e => e.Promocion)
                .HasComment("Id de la promoción")
                .HasColumnName("promocion");
            entity.Property(e => e.Prospecto)
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.TipoItem)
                .HasComment("Tipo de Item que se compra: 1=Membresía, 2=Plan Adicional, 3=SmartPack, (Si fue en promoción, el dato viene en el campo promoción)")
                .HasColumnName("tipo_item");
            entity.Property(e => e.WalletDestino)
                .HasMaxLength(300)
                .HasComment("clave de la wallet de destino a la que el usuario debe pagar (es única por transacción)")
                .HasColumnName("wallet_destino");

            entity.HasOne(d => d.ComplementoDeNavigation).WithMany(p => p.InverseComplementoDeNavigation)
                .HasForeignKey(d => d.ComplementoDe)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_compras_complemen_compras");

            entity.HasOne(d => d.PromocionNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.Promocion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_compras_relations_promocio");

            entity.HasOne(d => d.ProspectoNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.Prospecto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_compras_relations_prospect");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_compras_relations_socios");
        });

        modelBuilder.Entity<Continente>(entity =>
        {
            entity.HasKey(e => e.Continente1).HasName("pk_continentes");

            entity.ToTable("continentes", tb => tb.HasComment("catálogo de continentes o regiones para agrupar países"));

            entity.Property(e => e.Continente1)
                .ValueGeneratedNever()
                .HasComment("Id del continente")
                .HasColumnName("continente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasComment("Nombre del continente")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Correo>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_correos");

            entity.ToTable("correos", tb => tb.HasComment("Lista de correos por enviar/enviados"));

            entity.Property(e => e.Folio)
                .HasComment("Id autonumérico")
                .HasColumnName("folio");
            entity.Property(e => e.Asunto)
                .HasMaxLength(200)
                .HasColumnName("asunto");
            entity.Property(e => e.Auxiliar)
                .HasMaxLength(200)
                .HasComment("otro dato")
                .HasColumnName("auxiliar");
            entity.Property(e => e.Cuerpo).HasColumnName("cuerpo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .HasColumnName("direccion");
            entity.Property(e => e.Estatus)
                .HasComment("0=Sin enviar, 1=enviado, 2=cancelado (por muchos intentos)")
                .HasColumnName("estatus");
            entity.Property(e => e.FechaEnviado)
                .HasComment("fecha de envío")
                .HasColumnName("fecha_enviado");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Intento).HasColumnName("intento");
            entity.Property(e => e.Referencia)
                .HasComment("id del retiro, compra, bono, prospecto,  o elemento en cuestión")
                .HasColumnName("referencia");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Tipo)
                .HasComment("tipo de evento que desencadena el correo")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<RDB.Omega.SmartHub.Enum>(entity =>
        {
            entity.HasKey(e => new { e.Categoria, e.Codigo }).HasName("pk_enum");

            entity.ToTable("enum", tb => tb.HasComment("Esta tabla guarda listas de valores con sus descripciones. (O sea Enumeraciones)\r\n\r\nAdemás también almacena microcatálogos (Funciona como Tabla de Tablas)\r\npara casos en los que los ID son numéricos."));

            entity.Property(e => e.Categoria)
                .HasMaxLength(150)
                .HasComment("Categoría del Enum (o nombre del microcatálogo)")
                .HasColumnName("categoria");
            entity.Property(e => e.Codigo)
                .HasComment("Valor numérico del elemento")
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasComment("Descripción del elemento")
                .HasColumnName("descripcion");
            entity.Property(e => e.Dvalor)
                .HasComment("valor auxiliar datetime")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dvalor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .HasComment("Nombre del elemento")
                .HasColumnName("nombre");
            entity.Property(e => e.Nvalor)
                .HasComment("valor auxiliar numérico")
                .HasColumnName("nvalor");
            entity.Property(e => e.Svalor)
                .HasMaxLength(150)
                .HasComment("valor auxiliar string")
                .HasColumnName("svalor");
        });

        modelBuilder.Entity<EnumTrad>(entity =>
        {
            entity.HasKey(e => new { e.Categoria, e.Codigo, e.Idioma }).HasName("pk_enum_trad");

            entity.ToTable("enum_trad", tb => tb.HasComment("traducciones de los enums"));

            entity.HasIndex(e => new { e.Categoria, e.Codigo }, "relationship37fk");

            entity.Property(e => e.Categoria)
                .HasMaxLength(150)
                .HasComment("Categoría del Enum (o nombre del microcatálogo)")
                .HasColumnName("categoria");
            entity.Property(e => e.Codigo)
                .HasComment("Valor numérico del elemento")
                .HasColumnName("codigo");
            entity.Property(e => e.Idioma)
                .HasMaxLength(5)
                .HasComment("clave del idioma (es=español, en=inglés, pt=portugues, jp=japonés)")
                .HasColumnName("idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .HasColumnName("nombre");
            entity.Property(e => e.Svalor)
                .HasMaxLength(150)
                .HasColumnName("svalor");

            entity.HasOne(d => d.C).WithMany(p => p.EnumTrads)
                .HasForeignKey(d => new { d.Categoria, d.Codigo })
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_enum_tra_relations_enum");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => new { e.Pais, e.Estado1 }).HasName("pk_estados");

            entity.ToTable("estados", tb => tb.HasComment("catálogo de estados de cada país"));

            entity.HasIndex(e => e.Pais, "relationship9fk");

            entity.Property(e => e.Pais)
                .HasComment("Id del país")
                .HasColumnName("pais");
            entity.Property(e => e.Estado1)
                .HasComment("id del estado")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasComment("nombre del estado")
                .HasColumnName("nombre");

            entity.HasOne(d => d.PaisNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.Pais)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_estados_relations_paises");
        });

        modelBuilder.Entity<Insignia>(entity =>
        {
            entity.HasKey(e => e.Insignia1).HasName("pk_insignias");

            entity.ToTable("insignias", tb => tb.HasComment("Catálogo de insignias. (Ver Notas)\r\n\r\n"));

            entity.Property(e => e.Insignia1)
                .ValueGeneratedNever()
                .HasComment("Id de la insignia")
                .HasColumnName("insignia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasComment("Descripción de la insignia")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Icono)
                .HasMaxLength(80)
                .HasComment("Nombre del archivo del icono de la insignia")
                .HasColumnName("icono");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasComment("Nombre de la insignia")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Interaccione>(entity =>
        {
            entity.HasKey(e => e.Interaccion).HasName("pk_interacciones");

            entity.ToTable("interacciones");

            entity.HasIndex(e => e.Prospecto, "relationship83fk2");

            entity.HasIndex(e => e.Tipo, "relationship84fk2");

            entity.Property(e => e.Interaccion).HasColumnName("interaccion");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(500)
                .HasColumnName("comentarios");
            entity.Property(e => e.Cuerpo).HasColumnName("cuerpo");
            entity.Property(e => e.Enviado).HasColumnName("enviado");
            entity.Property(e => e.Fechaentrega).HasColumnName("fechaentrega");
            entity.Property(e => e.Fechaenvio).HasColumnName("fechaenvio");
            entity.Property(e => e.Fechainsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fechainsert");
            entity.Property(e => e.Fechalectura).HasColumnName("fechalectura");
            entity.Property(e => e.Fechaupdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fechaupdate");
            entity.Property(e => e.Leido).HasColumnName("leido");
            entity.Property(e => e.Prospecto)
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .HasColumnName("titulo");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .HasColumnName("url");

            entity.HasOne(d => d.ProspectoNavigation).WithMany(p => p.Interacciones)
                .HasForeignKey(d => d.Prospecto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_interacc_relations_prospect");

            entity.HasOne(d => d.TipoNavigation).WithMany(p => p.Interacciones)
                .HasForeignKey(d => d.Tipo)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_interacc_relations_tipo_int");
        });

        modelBuilder.Entity<IntervalosRendimiento>(entity =>
        {
            entity.HasKey(e => e.Intervalo).HasName("pk_intervalos_rendimiento");

            entity.ToTable("intervalos_rendimiento", tb => tb.HasComment("Esta tabla almacena intervalos de rendimiento (tabulador) en donde se ajusta el rendimiento a la baja en caso en el que se hagan retiros que disminuyan el capital inicial de inversión\r\nlos limites de cada intervalo están expresados como fracción (ej. 25% -> 0.25)\r\nal igual que la fracción del rendimiento aplicable al intevalo (ej. 75% -> 0.75)\r\n(Ver Notas)"));

            entity.HasIndex(e => e.Producto, "relationship40fk");

            entity.Property(e => e.Intervalo)
                .HasComment("id del registro")
                .HasColumnName("intervalo");
            entity.Property(e => e.FraccionRendimiento)
                .HasComment("Fracción del porcentaje de rendimiento que queda al estar en éste intervalo")
                .HasColumnName("fraccion_rendimiento");
            entity.Property(e => e.LimiteInf)
                .HasComment("Limite inferior del intervalo (expresado como fraccion (de 0 a 1))")
                .HasColumnName("limite_inf");
            entity.Property(e => e.LimiteSup)
                .HasComment("Limite superior del intervalo (expresado como fraccion (de 0 a 1))")
                .HasColumnName("limite_sup");
            entity.Property(e => e.Producto)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.IntervalosRendimientos)
                .HasForeignKey(d => d.Producto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_interval_relations_producto");
        });

        modelBuilder.Entity<Membresia>(entity =>
        {
            entity.HasKey(e => e.Membresia1).HasName("pk_membresias");

            entity.ToTable("membresias");

            entity.HasIndex(e => e.Producto, "planinicial2fk");

            entity.Property(e => e.Membresia1)
                .HasComment("Id autonumérico de la membresía")
                .HasColumnName("membresia");
            entity.Property(e => e.Activo)
                .HasComment("indica si la membresía está activa (se puede vender)")
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasComment("descripción libre de la membresía")
                .HasColumnName("descripcion");
            entity.Property(e => e.EsBorrador)
                .HasComment("Indica si es un borrador (se puede editar libremente)")
                .HasColumnName("es_borrador");
            entity.Property(e => e.FechaFin)
                .HasComment("fecha determinación de vigencia (cuando se dejó de vender)")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasComment("fecha de inicio de vigencia (a partir de cuando se puede comprar)")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .HasComment("moneda de la membresía")
                .HasColumnName("moneda");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .HasComment("nombre de la membresía")
                .HasColumnName("nombre");
            entity.Property(e => e.PagoBtc)
                .HasComment("se puede pagar en bitcoins")
                .HasColumnName("pago_btc");
            entity.Property(e => e.PagoTdc)
                .HasComment("se puede pagar con tarjeta de crédito o débito")
                .HasColumnName("pago_tdc");
            entity.Property(e => e.Precio)
                .HasComment("precio de la membresía")
                .HasColumnType("money")
                .HasColumnName("precio");
            entity.Property(e => e.Producto)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");
            entity.Property(e => e.Tipo)
                .HasComment("Tipo de Membresía (1=Básica, 2=Premium) (Enum TipoMembresia)")
                .HasColumnName("tipo");
            entity.Property(e => e.Vigencia)
                .HasComment("vigencia en años de la memebresía (0=Vitalicia) (Viene de microcatálogo VigenciaMembresia)")
                .HasColumnName("vigencia");

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.Membresia)
                .HasForeignKey(d => d.Producto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_membresi_plan_inic_producto");
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_movimientos");

            entity.ToTable("movimientos", tb => tb.HasComment("\r\n\r\ntabla de movimientos diarios"));

            entity.HasIndex(e => e.IdAux2, "idx_id_aux_movimientos");

            entity.HasIndex(e => e.Plan, "relationship3fk");

            entity.HasIndex(e => e.Pago, "relationship5fk");

            entity.Property(e => e.Folio)
                .HasComment("folio autonumérico")
                .HasColumnName("folio");
            entity.Property(e => e.Abono)
                .HasComment("cantidad de rendimientos generada en el día")
                .HasColumnType("money")
                .HasColumnName("abono");
            entity.Property(e => e.Capital)
                .HasComment("Capital resultante después del movimiento de cargo o abono (Ver notas)")
                .HasColumnType("money")
                .HasColumnName("capital");
            entity.Property(e => e.CapitalPrevio)
                .HasColumnType("money")
                .HasColumnName("capital_previo");
            entity.Property(e => e.Cargo)
                .HasComment("monto retirado (ver notas)")
                .HasColumnType("money")
                .HasColumnName("cargo");
            entity.Property(e => e.Comision)
                .HasComment("comisión descontada por el retiro")
                .HasColumnType("money")
                .HasColumnName("comision");
            entity.Property(e => e.Dia)
                .HasMaxLength(3)
                .HasComment("día de la semana (LU, MA, MI...)")
                .HasColumnName("dia");
            entity.Property(e => e.Fecha)
                .HasComment("fecha y hora del movimiento")
                .HasColumnName("fecha");
            entity.Property(e => e.IdAux)
                .HasComment("id de la DB legacy")
                .HasColumnName("id_aux");
            entity.Property(e => e.IdAux2)
                .HasComment("otro id de legacy")
                .HasColumnName("id_aux2");
            entity.Property(e => e.Mes)
                .HasComment("número de mes consecutivo, desde que se inició el plan")
                .HasColumnName("mes");
            entity.Property(e => e.Pago)
                .HasComment("pago con el que se saldó el retiro")
                .HasColumnName("pago");
            entity.Property(e => e.Plan)
                .HasComment("id del plan")
                .HasColumnName("plan");
            entity.Property(e => e.PorcentajeDiario)
                .HasPrecision(10, 6)
                .HasComment("porcentaje diario de rendimiento (como fracción) (para rendimiento)")
                .HasColumnName("porcentaje_diario");
            entity.Property(e => e.Tipo)
                .HasComment("tipo de movimiento (1=Rendimiento, 2=Retiro)")
                .HasColumnName("tipo");

            entity.HasOne(d => d.PagoNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.Pago)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_movimien_referenci_pagos");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_movimien_mov_plan_socio_pr");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Pago1).HasName("pk_pagos");

            entity.ToTable("pagos", tb => tb.HasComment("tabla que almacena los pagos realizados o por realizar al socio, ya sea por retiros o bonos"));

            entity.HasIndex(e => e.IdAux, "idx_id_aux_pagos");

            entity.HasIndex(e => e.PagoTx, "pagosdelatransaccionfk");

            entity.HasIndex(e => e.RefPlan, "refdeplanadicfk");

            entity.HasIndex(e => e.RefSocio, "referenciadesociofk");

            entity.HasIndex(e => e.RefMasterbonus, "refrangobonusfk");

            entity.HasIndex(e => e.RefRetiro, "relationship5fk2");

            entity.HasIndex(e => e.Socio, "socioapagarfk");

            entity.Property(e => e.Pago1)
                .HasComment("folio autonumérico del pago")
                .HasColumnName("pago");
            entity.Property(e => e.CorreoEnviado)
                .HasComment("Indica si ya se envió el correo de confirmación de pago")
                .HasColumnName("correo_enviado");
            entity.Property(e => e.CotizaBtc)
                .HasPrecision(17, 8)
                .HasComment("cotización del btc de la operación")
                .HasColumnName("cotiza_btc");
            entity.Property(e => e.Estatus)
                .HasComment("Estatus del pago (0=Sin pagar, 1=Pagado)")
                .HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasComment("fecha en que se creó la solicitud de pago")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPagado)
                .HasComment("fecha y hora en que se realizó el pago")
                .HasColumnName("fecha_pagado");
            entity.Property(e => e.FechaPago)
                .HasComment("fecha en que se debe realizar el pago")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Hash)
                .HasMaxLength(500)
                .HasComment("Referencia de la operación (hash o numero de transferencia)")
                .HasColumnName("hash");
            entity.Property(e => e.IdAux)
                .HasComment("id del depósito en la DB legacy")
                .HasColumnName("id_aux");
            entity.Property(e => e.IdAux2)
                .HasComment("id del evento o plan en legacy que generó el bono")
                .HasColumnName("id_aux2");
            entity.Property(e => e.Monto)
                .HasComment("Monto a pagar en USD")
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.MontoPagadoBtc)
                .HasPrecision(12, 8)
                .HasComment("Monto pagado en btc")
                .HasColumnName("monto_pagado_btc");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .HasColumnName("observaciones");
            entity.Property(e => e.PagoTx).HasColumnName("pago_tx");
            entity.Property(e => e.RefMasterbonus)
                .HasComment("referencia al rango del socio que generó el bono (socio_kpi_hist.folio)")
                .HasColumnName("ref_masterbonus");
            entity.Property(e => e.RefPadrino).HasColumnName("ref_padrino");
            entity.Property(e => e.RefPlan)
                .HasComment("referencia al plan adicional que generó el bono 5-3-2")
                .HasColumnName("ref_plan");
            entity.Property(e => e.RefRetiro)
                .HasComment("referencia al retiro (movimientos.folio)")
                .HasColumnName("ref_retiro");
            entity.Property(e => e.RefSocio)
                .HasComment("socio que generó el bono (afiliado directo, 3er afiliado,...)")
                .HasColumnName("ref_socio");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.Tipo)
                .HasComment("Tipo de pago (Ver notas)")
                .HasColumnName("tipo");
            entity.Property(e => e.Wallet)
                .HasMaxLength(300)
                .HasComment("clave de wallet a la que se debe hacer el pago")
                .HasColumnName("wallet");

            entity.HasOne(d => d.PagoTxNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.PagoTx)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_pagos_pagos_de__pagos_tr");

            entity.HasOne(d => d.RefPlanNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.RefPlan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_pagos_ref_de_pl_socio_pr");

            entity.HasOne(d => d.RefRetiroNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.RefRetiro)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_pagos_referenci_movimien");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pagos_referenci_socios");
        });

        modelBuilder.Entity<PagosTransaccione>(entity =>
        {
            entity.HasKey(e => e.PagoTx).HasName("pk_pagos_transacciones");

            entity.ToTable("pagos_transacciones");

            entity.HasIndex(e => e.Socio, "sociopagostxfk");

            entity.Property(e => e.PagoTx)
                .HasComment("folio autonumérico del pago-transacción")
                .HasColumnName("pago_tx");
            entity.Property(e => e.CotizaBtc)
                .HasPrecision(17, 8)
                .HasComment("cotización del btc de la operación")
                .HasColumnName("cotiza_btc");
            entity.Property(e => e.Estatus)
                .HasComment("Estatus del pago (0=Sin pagar, 1=Pagado)")
                .HasColumnName("estatus");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPagado)
                .HasComment("fecha y hora en que se realizó el pago")
                .HasColumnName("fecha_pagado");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Hash)
                .HasMaxLength(500)
                .HasComment("Referencia de la operación (hash o numero de transferencia)")
                .HasColumnName("hash");
            entity.Property(e => e.Monto)
                .HasComment("Monto a pagar en USD (Suma de los pagos individuales)")
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.MontoPagadoBtc)
                .HasPrecision(12, 8)
                .HasComment("Monto pagado en btc")
                .HasColumnName("monto_pagado_btc");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.Wallet)
                .HasMaxLength(300)
                .HasComment("clave de wallet a la que se debe hacer el pago")
                .HasColumnName("wallet");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.PagosTransacciones)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_pagos_tr_socio_pag_socios");
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.Pais).HasName("pk_paises");

            entity.ToTable("paises");

            entity.HasIndex(e => e.Continente, "relationship8fk");

            entity.Property(e => e.Pais)
                .ValueGeneratedNever()
                .HasComment("Id del país")
                .HasColumnName("pais");
            entity.Property(e => e.Continente)
                .HasComment("Id del continente")
                .HasColumnName("continente");
            entity.Property(e => e.Countrycode)
                .HasMaxLength(3)
                .HasComment("clave de dos letras del país")
                .HasColumnName("countrycode");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasComment("nombre del país")
                .HasColumnName("nombre");
            entity.Property(e => e.PhoneDigits)
                .HasDefaultValueSql("10")
                .HasColumnName("phone_digits");
            entity.Property(e => e.Phonecode)
                .HasComment("código telefónico del país")
                .HasColumnName("phonecode");

            entity.HasOne(d => d.ContinenteNavigation).WithMany(p => p.Paises)
                .HasForeignKey(d => d.Continente)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_paises_relations_continen");

            entity.HasMany(d => d.Membresia).WithMany(p => p.Pais)
                .UsingEntity<Dictionary<string, object>>(
                    "MembresiaPaise",
                    r => r.HasOne<Membresia>().WithMany()
                        .HasForeignKey("Membresia")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_membresi_membresia_membresi"),
                    l => l.HasOne<Paise>().WithMany()
                        .HasForeignKey("Pais")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_membresi_membresia_paises"),
                    j =>
                    {
                        j.HasKey("Pais", "Membresia").HasName("pk_membresia_paises");
                        j.ToTable("membresia_paises");
                        j.HasIndex(new[] { "Membresia" }, "membresiapaises2fk");
                        j.HasIndex(new[] { "Pais" }, "membresiapaisesfk");
                        j.IndexerProperty<int>("Pais")
                            .HasComment("Id del país")
                            .HasColumnName("pais");
                        j.IndexerProperty<int>("Membresia")
                            .HasComment("Id autonumérico de la membresía")
                            .HasColumnName("membresia");
                    });

            entity.HasMany(d => d.Productos).WithMany(p => p.Pais)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoPaise",
                    r => r.HasOne<Producto>().WithMany()
                        .HasForeignKey("Producto")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_producto_producto__producto"),
                    l => l.HasOne<Paise>().WithMany()
                        .HasForeignKey("Pais")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_producto_producto__paises"),
                    j =>
                    {
                        j.HasKey("Pais", "Producto").HasName("pk_producto_paises");
                        j.ToTable("producto_paises", tb => tb.HasComment("paises en los que está disponible el producto"));
                        j.HasIndex(new[] { "Producto" }, "productopaises2fk");
                        j.HasIndex(new[] { "Pais" }, "productopaisesfk");
                        j.IndexerProperty<int>("Pais")
                            .HasComment("Id del país")
                            .HasColumnName("pais");
                        j.IndexerProperty<int>("Producto")
                            .HasComment("id autonumérico del producto ")
                            .HasColumnName("producto");
                    });

            entity.HasMany(d => d.Promocions).WithMany(p => p.Pais)
                .UsingEntity<Dictionary<string, object>>(
                    "PromocionPaise",
                    r => r.HasOne<Promocione>().WithMany()
                        .HasForeignKey("Promocion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_promocio_promocion_promocio"),
                    l => l.HasOne<Paise>().WithMany()
                        .HasForeignKey("Pais")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_promocio_promocion_paises"),
                    j =>
                    {
                        j.HasKey("Pais", "Promocion").HasName("pk_promocion_paises");
                        j.ToTable("promocion_paises");
                        j.HasIndex(new[] { "Promocion" }, "promocionpaises2fk");
                        j.HasIndex(new[] { "Pais" }, "promocionpaisesfk");
                        j.IndexerProperty<int>("Pais")
                            .HasComment("Id del país")
                            .HasColumnName("pais");
                        j.IndexerProperty<int>("Promocion")
                            .HasComment("Id de la promoción")
                            .HasColumnName("promocion");
                    });
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity.HasKey(e => e.SmartPack).HasName("pk_paquetes");

            entity.ToTable("paquetes", tb => tb.HasComment("Catálogo de smart packs"));

            entity.HasIndex(e => e.Membresia, "membsmartpackfk");

            entity.HasIndex(e => e.PlanInicial, "smartpackpifk");

            entity.Property(e => e.SmartPack)
                .HasComment("id del paquete")
                .HasColumnName("smart_pack");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasComment("Descripción del producto")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaFin)
                .HasComment("fecha determinación de vigencia (cuando se dejó de vender)")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasDefaultValueSql("now()")
                .HasComment("fecha de inicio de vigencia (a partir de cuando se puede comprar)")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Membresia)
                .HasComment("Id autonumérico de la membresía")
                .HasColumnName("membresia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasComment("Nombre del producto")
                .HasColumnName("nombre");
            entity.Property(e => e.PlanInicial)
                .HasComment("plan inicial al que está asociado éste smart pack")
                .HasColumnName("plan_inicial");
            entity.Property(e => e.Rendimiento)
                .HasPrecision(10, 3)
                .HasComment("Nuevo rendimiento del plan inicial si se convierte en smart pack (porcentaje expresado como fracción)")
                .HasColumnName("rendimiento");

            entity.HasOne(d => d.MembresiaNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.Membresia)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_paquetes_memb_smar_membresi");

            entity.HasOne(d => d.PlanInicialNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.PlanInicial)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_paquetes_smart_pac_producto");
        });

        modelBuilder.Entity<PaqueteProducto>(entity =>
        {
            entity.HasKey(e => new { e.SmartPack, e.Producto }).HasName("pk_paquete_productos");

            entity.ToTable("paquete_productos", tb => tb.HasComment("Esta tabla contiene los productos que componen a cada paquete"));

            entity.HasIndex(e => e.Producto, "paquetesproductos2fk");

            entity.HasIndex(e => e.SmartPack, "paquetesproductosfk");

            entity.Property(e => e.SmartPack)
                .HasComment("id del paquete")
                .HasColumnName("smart_pack");
            entity.Property(e => e.Producto)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");
            entity.Property(e => e.Rendimiento)
                .HasPrecision(10, 3)
                .HasComment("rendimiento del producto al convertirse en un smart pack")
                .HasColumnName("rendimiento");

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.PaqueteProductos)
                .HasForeignKey(d => d.Producto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_paquete__relations_producto");

            entity.HasOne(d => d.SmartPackNavigation).WithMany(p => p.PaqueteProductos)
                .HasForeignKey(d => d.SmartPack)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_paquete__relations_paquetes");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => new { e.Categoria, e.Parametro1 }).HasName("pk_parametros");

            entity.ToTable("parametros", tb => tb.HasComment("Tabla de parámetros de configuración del sistema\r\n\r\nAlmacena diversos parámetros de funcionamiento del sistema.\r\n"));

            entity.Property(e => e.Categoria)
                .HasMaxLength(150)
                .HasComment("Categoría del parámetro")
                .HasColumnName("categoria");
            entity.Property(e => e.Parametro1)
                .HasMaxLength(150)
                .HasComment("Nombre del parámetro")
                .HasColumnName("parametro");
            entity.Property(e => e.Descripcion)
                .HasComment("Descripción del Parámetro")
                .HasColumnName("descripcion");
            entity.Property(e => e.Dvalor)
                .HasComment("valor datetime del parámetro")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dvalor");
            entity.Property(e => e.Eseditable)
                .HasComment("Indica si es un parámetro configurable por el usuario")
                .HasColumnName("eseditable");
            entity.Property(e => e.Nvalor)
                .HasComment("Valor numérico del parámetro")
                .HasColumnName("nvalor");
            entity.Property(e => e.Rango)
                .HasMaxLength(60)
                .HasComment("intervalo de valores válidos en formato a-b (puede ser a-  o -b)")
                .HasColumnName("rango");
            entity.Property(e => e.Svalor)
                .HasMaxLength(300)
                .HasComment("Valor string del parámetro")
                .HasColumnName("svalor");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasComment("n=Numérico, s=String, d=Date")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Premio>(entity =>
        {
            entity.HasKey(e => e.Premio1).HasName("pk_premios");

            entity.ToTable("premios", tb => tb.HasComment("catálogo de premios en especie\r\n(un iPhone, un peluche, una taza, una TV, un viaje)"));

            entity.Property(e => e.Premio1)
                .HasComment("Id autonumérico del premio")
                .HasColumnName("premio");
            entity.Property(e => e.Anexo)
                .HasMaxLength(120)
                .HasComment("Nombre del archivo anexo con la descripción del premio\r\n(Folleto en PDF o similar)")
                .HasColumnName("anexo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasComment("Descripción del premio")
                .HasColumnName("descripcion");
            entity.Property(e => e.Foto)
                .HasMaxLength(120)
                .HasComment("Nombre del archivo con la foto del producto")
                .HasColumnName("foto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .HasComment("nombre del premio")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Producto1).HasName("pk_productos");

            entity.ToTable("productos", tb => tb.HasComment("Catálogo de productos\r\n\r\nGuarda la lista de productos (planes iniciales y adicionales)\r\n\r\nNo guarda productos resultantes de una promo, son los productos básicos, si acaso, llegan a ser diferentes por región."));

            entity.HasIndex(e => e.SmartPack, "smartpackpi2fk");

            entity.Property(e => e.Producto1)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");
            entity.Property(e => e.Activo)
                .HasComment("indica si el producto está activo (es susceptible a ser comprado)")
                .HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasComment("Nombre clave del producto (llave alterna)")
                .HasColumnName("codigo");
            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .HasComment("color del encabezado del producto como se muestra en la web")
                .HasColumnName("color");
            entity.Property(e => e.Comision)
                .HasPrecision(10, 3)
                .HasComment("porcentaje de comision cuando se hace un retiro antes del plazo mínimo (expresado como fracción)")
                .HasColumnName("comision");
            entity.Property(e => e.Duracion)
                .HasDefaultValueSql("24")
                .HasComment("duración nominal del producto en meses (normalmente 24 meses) 0=Eterno")
                .HasColumnName("duracion");
            entity.Property(e => e.EsBorrador)
                .HasComment("indica que el registro es un borrador (no está capturado correctamente o autorizado)")
                .HasColumnName("es_borrador");
            entity.Property(e => e.EsLegacy)
                .HasDefaultValueSql("false")
                .HasComment("Indica si el producto es heredado del sistema anterior y no debe ser vendido más")
                .HasColumnName("es_legacy");
            entity.Property(e => e.EsMontoAbierto)
                .HasComment("Indica que se trata de un monto abierto (en ese caso el campo monto trae el mínimo por ejemplo 10,000 USD)")
                .HasColumnName("es_monto_abierto");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaFin)
                .HasComment("fecha determinación de vigencia (cuando se dejó de vender)")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasDefaultValueSql("now()")
                .HasComment("fecha de inicio de vigencia (a partir de cuando se puede comprar)")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.IdLegacy)
                .HasComment("Id del elemento en la tabla legacy")
                .HasColumnName("id_legacy");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .HasComment("Moneda (Enum Monedas [sValor])")
                .HasColumnName("moneda");
            entity.Property(e => e.Monto)
                .HasComment("Monto o precio de la inversión o producto")
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasComment("Nombre del producto")
                .HasColumnName("nombre");
            entity.Property(e => e.PagoBtc)
                .HasComment("se puede pagar con bitcoins")
                .HasColumnName("pago_btc");
            entity.Property(e => e.PagoTdc)
                .HasComment("se puede pagar con tarjeta de crédito o débito")
                .HasColumnName("pago_tdc");
            entity.Property(e => e.PlazoComision)
                .HasComment("duración en meses del plazo mínimo para no causar comisiones al retirar ")
                .HasColumnName("plazo_comision");
            entity.Property(e => e.PlazoForzoso)
                .HasComment("plazo mínimo forzoso en meses donde No se puede retirar (normalmente 24 en membresías y 0 en planes adicionales)")
                .HasColumnName("plazo_forzoso");
            entity.Property(e => e.ReglaCapitalizacion)
                .HasDefaultValueSql("1")
                .HasComment("Viene de microcatálogo (ReglasCapitalizacion) 1=Mensual, 2=Quincenal")
                .HasColumnName("regla_capitalizacion");
            entity.Property(e => e.Rendimiento)
                .HasPrecision(10, 3)
                .HasComment("Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2)")
                .HasColumnName("rendimiento");
            entity.Property(e => e.SmartPack)
                .HasComment("Si tipo=1 (plan inicial) este campo apunta al smart pack al que se puede convertir este plan")
                .HasColumnName("smart_pack");
            entity.Property(e => e.Tipo)
                .HasComment("1=Plan Inicial, 2=Plan Adicional (Enum TipoProducto)")
                .HasColumnName("tipo");

            entity.HasOne(d => d.SmartPackNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.SmartPack)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_producto_smart_pac_paquetes");
        });

        modelBuilder.Entity<ProductosTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("productos_temp");

            entity.HasIndex(e => e.IdLegacy, "idx_id_legacy_productos_temp");

            entity.Property(e => e.IdLegacy).HasColumnName("id_legacy");
            entity.Property(e => e.IdProd).HasColumnName("id_prod");
        });

        modelBuilder.Entity<ProductosTrad>(entity =>
        {
            entity.HasKey(e => new { e.Producto, e.Idioma }).HasName("pk_productos_trad");

            entity.ToTable("productos_trad", tb => tb.HasComment("traducción de los productos"));

            entity.HasIndex(e => e.Producto, "relationship38fk");

            entity.Property(e => e.Producto)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");
            entity.Property(e => e.Idioma)
                .HasMaxLength(5)
                .HasComment("id del idioma (es,en,pt,jp)")
                .HasColumnName("idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasComment("Descripción del producto")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasComment("Nombre del producto")
                .HasColumnName("nombre");

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.ProductosTrads)
                .HasForeignKey(d => d.Producto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_producto_relations_producto");
        });

        modelBuilder.Entity<PromoMembresia>(entity =>
        {
            entity.HasKey(e => new { e.Membresia, e.Promocion }).HasName("pk_promo_membresias");

            entity.ToTable("promo_membresias");

            entity.HasIndex(e => e.Membresia, "relationship49fk");

            entity.HasIndex(e => e.Promocion, "relationship50fk");

            entity.Property(e => e.Membresia)
                .HasComment("Id autonumérico de la membresía")
                .HasColumnName("membresia");
            entity.Property(e => e.Promocion)
                .HasComment("Id de la promoción")
                .HasColumnName("promocion");
            entity.Property(e => e.Precio)
                .HasComment("precio promoción de la membresía")
                .HasColumnType("money")
                .HasColumnName("precio");

            entity.HasOne(d => d.MembresiaNavigation).WithMany(p => p.PromoMembresia)
                .HasForeignKey(d => d.Membresia)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promo_me_relations_membresi");

            entity.HasOne(d => d.PromocionNavigation).WithMany(p => p.PromoMembresia)
                .HasForeignKey(d => d.Promocion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promo_me_relations_promocio");
        });

        modelBuilder.Entity<PromoProducto>(entity =>
        {
            entity.HasKey(e => new { e.Producto, e.Promocion }).HasName("pk_promo_productos");

            entity.ToTable("promo_productos", tb => tb.HasComment("Almacena los productos participantes en la promo. \r\nLa promo aplica para cualquiera de los productos que están en esta lista\r\n(Ver Notas)\r\n"));

            entity.HasIndex(e => e.Promocion, "promoproductos2fk");

            entity.HasIndex(e => e.Producto, "promoproductosfk");

            entity.Property(e => e.Producto)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");
            entity.Property(e => e.Promocion)
                .HasComment("Id de la promoción")
                .HasColumnName("promocion");
            entity.Property(e => e.Comision)
                .HasPrecision(10, 3)
                .HasComment("porcentaje de comision cuando se hace un retiro antes del plazo mínimo (expresado como fracción)")
                .HasColumnName("comision");
            entity.Property(e => e.Monto)
                .HasComment("Monto o precio de la inversión o producto")
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.PlazoComision)
                .HasComment("duración en meses del plazo mínimo para no causar comisiones al retirar ")
                .HasColumnName("plazo_comision");
            entity.Property(e => e.Rendimiento)
                .HasPrecision(10, 3)
                .HasComment("Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2)")
                .HasColumnName("rendimiento");

            entity.HasOne(d => d.ProductoNavigation).WithMany(p => p.PromoProductos)
                .HasForeignKey(d => d.Producto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promo_pr_relations_producto");

            entity.HasOne(d => d.PromocionNavigation).WithMany(p => p.PromoProductos)
                .HasForeignKey(d => d.Promocion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promo_pr_relations_promocio");
        });

        modelBuilder.Entity<PromoVenta>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_promo_ventas");

            entity.ToTable("promo_ventas", tb => tb.HasComment("Registro de las ventas de una promoción\r\n(un registro representa una promo vendida a un socio)"));

            entity.HasIndex(e => e.Promocion, "relationship21fk");

            entity.HasIndex(e => e.Socio, "relationship22fk");

            entity.Property(e => e.Folio)
                .HasComment("folio autonumérico del registro")
                .HasColumnName("folio");
            entity.Property(e => e.Fecha)
                .HasComment("Fecha-hora en la que el socio compró la promoción")
                .HasColumnName("fecha");
            entity.Property(e => e.Promocion)
                .HasComment("Id de la promoción")
                .HasColumnName("promocion");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");

            entity.HasOne(d => d.PromocionNavigation).WithMany(p => p.PromoVenta)
                .HasForeignKey(d => d.Promocion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promo_ve_relations_promocio");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.PromoVenta)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promo_ve_relations_socios");
        });

        modelBuilder.Entity<Promocione>(entity =>
        {
            entity.HasKey(e => e.Promocion).HasName("pk_promociones");

            entity.ToTable("promociones", tb => tb.HasComment("Catálogo de promociones (Ver Notas)\r\n\r\n"));

            entity.HasIndex(e => e.Insignia, "promoinsigniafk");

            entity.HasIndex(e => e.Premio, "relationship25fk");

            entity.Property(e => e.Promocion)
                .HasComment("Id de la promoción")
                .HasColumnName("promocion");
            entity.Property(e => e.Activo)
                .HasComment("indica si la promoción está activa (se puede comprar)")
                .HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasComment("Código (nombre corto) de la promoción")
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasComment("descripción de la promo")
                .HasColumnName("descripcion");
            entity.Property(e => e.DescuentoMonto)
                .HasComment("Descuento en monto fijo para la compra de un producto ")
                .HasColumnType("money")
                .HasColumnName("descuento_monto");
            entity.Property(e => e.DescuentoPorcentaje)
                .HasPrecision(10, 3)
                .HasComment("Porcentaje de descuento para la compra de un producto")
                .HasColumnName("descuento_porcentaje");
            entity.Property(e => e.EsBorrador)
                .HasComment("indica si el registro es un borrador (se puede editar libremente)")
                .HasColumnName("es_borrador");
            entity.Property(e => e.ExclusivoRangos)
                .HasComment("Indica si solo puede ser comprado por socios de cierto rango (especificados en promo_rangos)")
                .HasColumnName("exclusivo_rangos");
            entity.Property(e => e.FechaFin)
                .HasComment("fechaHora final de la promoción (Hasta cuando se puede comprar)")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIni)
                .HasComment("fecha-hora de inicio de la promoción (Desde cuando se puede comprar)")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Insignia)
                .HasComment("Id de la insignia")
                .HasColumnName("insignia");
            entity.Property(e => e.InsigniasAnd)
                .HasComment("Condición de Insignias (ver notas)")
                .HasColumnName("insignias_and");
            entity.Property(e => e.MontoLimitado)
                .HasDefaultValueSql("0")
                .HasComment("sólo se puede vender hasta alcanzar esta cantidad en ventas (dinero) 0=sin límite")
                .HasColumnType("money")
                .HasColumnName("monto_limitado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .HasComment("Nombre de la promoción")
                .HasColumnName("nombre");
            entity.Property(e => e.Observaciones)
                .HasComment("campo libre")
                .HasColumnName("observaciones");
            entity.Property(e => e.Premio)
                .HasComment("Id autonumérico del premio")
                .HasColumnName("premio");
            entity.Property(e => e.RendimientoExtra)
                .HasPrecision(10, 3)
                .HasComment("porcentaje de rendimiento adicional al normal (expresado como fracción)")
                .HasColumnName("rendimiento_extra");
            entity.Property(e => e.TirajeLimitado)
                .HasComment("solo se puede vender N veces esta promo (0=sin límite)")
                .HasColumnName("tiraje_limitado");
            entity.Property(e => e.VentasConteo)
                .HasComment("Indica cuantas veces se ha vendido la promo")
                .HasColumnName("ventas_conteo");
            entity.Property(e => e.VentasMonto)
                .HasComment("Suma en dólares de las ventas de la promo")
                .HasColumnType("money")
                .HasColumnName("ventas_monto");

            entity.HasOne(d => d.Insignia1).WithMany(p => p.Promociones)
                .HasForeignKey(d => d.Insignia)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promocio_promo_ins_insignia");

            entity.HasOne(d => d.PremioNavigation).WithMany(p => p.Promociones)
                .HasForeignKey(d => d.Premio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_promocio_relations_premios");

            entity.HasMany(d => d.InsigniaNavigation).WithMany(p => p.Promocions)
                .UsingEntity<Dictionary<string, object>>(
                    "PromoInsigniasReq",
                    r => r.HasOne<Insignia>().WithMany()
                        .HasForeignKey("Insignia")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_promo_in_promo_ins_insignia"),
                    l => l.HasOne<Promocione>().WithMany()
                        .HasForeignKey("Promocion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_promo_in_promo_ins_promocio"),
                    j =>
                    {
                        j.HasKey("Promocion", "Insignia").HasName("pk_promo_insignias_req");
                        j.ToTable("promo_insignias_req", tb => tb.HasComment("esta tabla almacena las insignias que debe tener el socio para poder comprar la promo\r\n"));
                        j.HasIndex(new[] { "Insignia" }, "promoinsigniasreq2fk");
                        j.HasIndex(new[] { "Promocion" }, "promoinsigniasreqfk");
                        j.IndexerProperty<int>("Promocion")
                            .HasComment("Id de la promoción")
                            .HasColumnName("promocion");
                        j.IndexerProperty<int>("Insignia")
                            .HasComment("Id de la insignia")
                            .HasColumnName("insignia");
                    });

            entity.HasMany(d => d.Rangos).WithMany(p => p.Promocions)
                .UsingEntity<Dictionary<string, object>>(
                    "PromoRango",
                    r => r.HasOne<Rango>().WithMany()
                        .HasForeignKey("Rango")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_promo_ra_promo_ran_rangos"),
                    l => l.HasOne<Promocione>().WithMany()
                        .HasForeignKey("Promocion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_promo_ra_promo_ran_promocio"),
                    j =>
                    {
                        j.HasKey("Promocion", "Rango").HasName("pk_promo_rangos");
                        j.ToTable("promo_rangos", tb => tb.HasComment("Tabla para anotar los rangos para los que aplica cierta promoción"));
                        j.HasIndex(new[] { "Rango" }, "promorangos2fk");
                        j.HasIndex(new[] { "Promocion" }, "promorangosfk");
                        j.IndexerProperty<int>("Promocion")
                            .HasComment("Id de la promoción")
                            .HasColumnName("promocion");
                        j.IndexerProperty<int>("Rango")
                            .HasComment("ID del rango")
                            .HasColumnName("rango");
                    });
        });

        modelBuilder.Entity<Prospecto>(entity =>
        {
            entity.HasKey(e => e.Prospecto1).HasName("pk_prospectos");

            entity.ToTable("prospectos", tb => tb.HasComment("Tabla de prospectos, que están en proceso de convertirse en socios"));

            entity.HasIndex(e => e.Email, "idxprospectosemail");

            entity.HasIndex(e => e.NuevoSocio, "socionuevofk");

            entity.HasIndex(e => e.Padre, "socioprospectofk");

            entity.HasIndex(e => e.Validacion, "validacionactualprospectofk");

            entity.Property(e => e.Prospecto1)
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.ApellidoMat)
                .HasMaxLength(120)
                .HasComment("apellido materno")
                .HasColumnName("apellido_mat");
            entity.Property(e => e.ApellidoPat)
                .HasMaxLength(120)
                .HasComment("apellido paterno")
                .HasColumnName("apellido_pat");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(250)
                .HasComment("contraseña encriptada")
                .HasColumnName("contrasena");
            entity.Property(e => e.Cultura)
                .HasComment("Cultura (Idioma) del socio (es-MX, en-US, ...) viene de microcatálogo")
                .HasColumnName("cultura");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasComment("email del prospecto")
                .HasColumnName("email");
            entity.Property(e => e.Email2)
                .HasMaxLength(120)
                .HasComment("email alterno del socio")
                .HasColumnName("email2");
            entity.Property(e => e.EmailVerified)
                .HasComment("indica si la dirección de correo ya fué verificada (con link en correo)")
                .HasColumnName("email_verified");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.LastLogin)
                .HasDefaultValueSql("now()")
                .HasColumnName("last_login");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .HasComment("Nombre propio")
                .HasColumnName("nombre");
            entity.Property(e => e.NuevoSocio)
                .HasComment("Id del socio en el que se convierte este prospecto")
                .HasColumnName("nuevo_socio");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.Padre)
                .HasComment("Id del socio padre")
                .HasColumnName("padre");
            entity.Property(e => e.PhoneVerified)
                .HasComment("indica si el número telefónico ya fué verificado (con link en SMS)")
                .HasColumnName("phone_verified");
            entity.Property(e => e.Tipo)
                .HasComment("1=Prospecto, 2=Interesado")
                .HasColumnName("tipo");
            entity.Property(e => e.Validacion)
                .HasComment("Id de la validación")
                .HasColumnName("validacion");
            entity.Property(e => e.ZonaHoraria)
                .HasMaxLength(120)
                .HasComment("nombre canónico de la zona horaria del socio")
                .HasColumnName("zona_horaria");

            entity.HasOne(d => d.NuevoSocioNavigation).WithMany(p => p.ProspectoNuevoSocioNavigations)
                .HasForeignKey(d => d.NuevoSocio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_socio_nue_socios");

            entity.HasOne(d => d.PadreNavigation).WithMany(p => p.ProspectoPadreNavigations)
                .HasForeignKey(d => d.Padre)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_socio_pro_socios");

            entity.HasOne(d => d.ValidacionNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.Validacion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_validacio_prospect");
        });

        modelBuilder.Entity<ProspectoDocumentacion>(entity =>
        {
            entity.HasKey(e => e.Anexo).HasName("pk_prospecto_documentacion");

            entity.ToTable("prospecto_documentacion", tb => tb.HasComment("Esta tabla almacena la documentación oficial del prospecto, como INE, CURP Comprobante de domicilio, etc\r\nson puros anexos (Ver Notas)\r\n\r\n"));

            entity.HasIndex(e => e.Prospecto, "relationship34fk");

            entity.HasIndex(e => e.Validacion, "relationship52fk");

            entity.Property(e => e.Anexo)
                .HasComment("id autonumérico del registro")
                .HasColumnName("anexo");
            entity.Property(e => e.Descargado)
                .HasComment("bandera que indica si el anexo ya fué descargado de metamap y alojado en un bucket")
                .HasColumnName("descargado");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Filename)
                .HasMaxLength(500)
                .HasComment("nombre original del archivo (Ver Notas)")
                .HasColumnName("filename");
            entity.Property(e => e.Prospecto)
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.Tipo)
                .HasComment("tipo de documento (microcatálogo)")
                .HasColumnName("tipo");
            entity.Property(e => e.Validacion)
                .HasComment("Id de la validación")
                .HasColumnName("validacion");

            entity.HasOne(d => d.ProspectoNavigation).WithMany(p => p.ProspectoDocumentacions)
                .HasForeignKey(d => d.Prospecto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_relations_prospect2");

            entity.HasOne(d => d.ValidacionNavigation).WithMany(p => p.ProspectoDocumentacions)
                .HasForeignKey(d => d.Validacion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_relations_prospect");
        });

        modelBuilder.Entity<ProspectoInfo>(entity =>
        {
            entity.HasKey(e => e.Prospecto).HasName("pk_prospecto_info");

            entity.ToTable("prospecto_info", tb => tb.HasComment("Información adicional sobre el prospecto"));

            entity.HasIndex(e => new { e.Pais, e.Estado }, "relationship32fk");

            entity.Property(e => e.Prospecto)
                .ValueGeneratedNever()
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.Calle)
                .HasMaxLength(120)
                .HasComment("calle del domicilio del socio")
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(120)
                .HasComment("ciudad")
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoMfa)
                .HasComment("código de validación de celular (se envia como SMS cada que se valida el celular) (No se usa para autentificación)")
                .HasColumnName("codigo_mfa");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(20)
                .HasComment("código postal")
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(120)
                .HasComment("colonia o barrio")
                .HasColumnName("colonia");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1000)
                .HasComment("campo libre para comentarios")
                .HasColumnName("comentarios");
            entity.Property(e => e.CveFiscal)
                .HasMaxLength(120)
                .HasComment("Clave fiscal de la persona (en méxico RFC)")
                .HasColumnName("cve_fiscal");
            entity.Property(e => e.CveIdentidad)
                .HasMaxLength(120)
                .HasComment("clave oficial de identificación oficial (En méxico INE, en españa DNI)")
                .HasColumnName("cve_identidad");
            entity.Property(e => e.Direccion)
                .HasComment("Dirección completa")
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasComment("id del estado")
                .HasColumnName("estado");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaNacimiento)
                .HasComment("fecha de nacimiento del socio")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Foto)
                .HasMaxLength(500)
                .HasComment("Nombre del archivo foto (ver notas)")
                .HasColumnName("foto");
            entity.Property(e => e.FotoDescargada)
                .HasComment("bandera que indica si la foto ya fue descargada de metamap y puesta en un bucket")
                .HasColumnName("foto_descargada");
            entity.Property(e => e.Genero)
                .HasComment("1=Hombre, 2=Mujer, 3=Otro, ... (Microcatálogo)")
                .HasColumnName("genero");
            entity.Property(e => e.IntAhorro)
                .HasComment("tiene interés en ahorro (inversiones)")
                .HasColumnName("int_ahorro");
            entity.Property(e => e.IntEmprendimiento)
                .HasComment("tiene interés en emprendimiento")
                .HasColumnName("int_emprendimiento");
            entity.Property(e => e.IntFormacion)
                .HasComment("tiene interés en formación (educación financiera)")
                .HasColumnName("int_formacion");
            entity.Property(e => e.IntNetworking)
                .HasComment("tiene interés en networking (red multinivel)")
                .HasColumnName("int_networking");
            entity.Property(e => e.MedioContacto)
                .HasComment("Medio de contacto preferido. (1=email, 2=WhatsApp, 3=sms, 4=Otro) microcatálogo")
                .HasColumnName("medio_contacto");
            entity.Property(e => e.MedioContactoOtro)
                .HasMaxLength(120)
                .HasComment("Otro medio de contacto (cuando el preferido es 4=Otro)")
                .HasColumnName("medio_contacto_otro");
            entity.Property(e => e.Municipio)
                .HasMaxLength(120)
                .HasComment("municipio")
                .HasColumnName("municipio");
            entity.Property(e => e.NumExt)
                .HasMaxLength(50)
                .HasComment("número exterior")
                .HasColumnName("num_ext");
            entity.Property(e => e.NumInt)
                .HasMaxLength(50)
                .HasComment("número interior")
                .HasColumnName("num_int");
            entity.Property(e => e.Pais)
                .HasComment("Id del país")
                .HasColumnName("pais");
            entity.Property(e => e.TelCasa)
                .HasMaxLength(30)
                .HasComment("teléfono fijo de casa")
                .HasColumnName("tel_casa");
            entity.Property(e => e.TelCelular)
                .HasMaxLength(30)
                .HasComment("teléfono celular")
                .HasColumnName("tel_celular");
            entity.Property(e => e.TelOficina)
                .HasMaxLength(30)
                .HasComment("teléfono fijo del trabajo")
                .HasColumnName("tel_oficina");

            entity.HasOne(d => d.ProspectoNavigation).WithOne(p => p.ProspectoInfo)
                .HasForeignKey<ProspectoInfo>(d => d.Prospecto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_relations_prospect");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.ProspectoInfos)
                .HasForeignKey(d => new { d.Pais, d.Estado })
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_relations_estados");
        });

        modelBuilder.Entity<ProspectoMedium>(entity =>
        {
            entity.HasKey(e => e.Prospecto).HasName("pk_prospecto_media");

            entity.ToTable("prospecto_media", tb => tb.HasComment("registra los archivos que ha descargado y videos que ha visto el prospecto"));

            entity.Property(e => e.Prospecto)
                .ValueGeneratedNever()
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.ManualPreguntas)
                .HasComment("descargó el manual de preguntas frecuentes")
                .HasColumnName("manual_preguntas");
            entity.Property(e => e.PdfInformativo)
                .HasComment("descargó el pdf informativo")
                .HasColumnName("pdf_informativo");
            entity.Property(e => e.Video1Visto)
                .HasComment("porcentaje visto del video 1 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)")
                .HasColumnName("video1_visto");
            entity.Property(e => e.Video2Visto)
                .HasComment("porcentaje visto del video 2 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)")
                .HasColumnName("video2_visto");
            entity.Property(e => e.Video3Visto)
                .HasComment("porcentaje visto del video 3 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)")
                .HasColumnName("video3_visto");
            entity.Property(e => e.Video4Visto)
                .HasComment("porcentaje visto del video 4 (0=0%, 1=25%, 2=50%, 3=75%, 4=100%)")
                .HasColumnName("video4_visto");

            entity.HasOne(d => d.ProspectoNavigation).WithOne(p => p.ProspectoMedium)
                .HasForeignKey<ProspectoMedium>(d => d.Prospecto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_relations_prospect");
        });

        modelBuilder.Entity<ProspectoValidacion>(entity =>
        {
            entity.HasKey(e => e.Validacion).HasName("pk_prospecto_validacion");

            entity.ToTable("prospecto_validacion", tb => tb.HasComment("Guarda el estado de la validación del prospecto (Ver notas)"));

            entity.Property(e => e.Validacion)
                .HasComment("Id de la validación")
                .HasColumnName("validacion");
            entity.Property(e => e.AutorizadoPor)
                .HasMaxLength(120)
                .HasComment("usuario de SBC que autorizó al socio (en caso de tener warning o fail)")
                .HasColumnName("autorizado_por");
            entity.Property(e => e.Estatus)
                .HasComment("Estatus general (Ver Notas) 0=PENDING, 1=OK, 2=WARNING, 3=FAIL ")
                .HasColumnName("estatus");
            entity.Property(e => e.EstatusKyc)
                .HasComment("Estatus que le da el servicio KYC.  0=PENDING, 1=OK, 2=WARNING, 3=FAIL")
                .HasColumnName("estatus_kyc");
            entity.Property(e => e.FechaEmpresa)
                .HasComment("Fecha en que se realizó la verificación por la empresa")
                .HasColumnName("fecha_empresa");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaKyc)
                .HasComment("fecha en que se verificó por el servicio KYC")
                .HasColumnName("fecha_kyc");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FechaValidacion)
                .HasComment("Fecha de validación interna")
                .HasColumnName("fecha_validacion");
            entity.Property(e => e.IdRelated)
                .HasMaxLength(120)
                .HasColumnName("id_related");
            entity.Property(e => e.IdValidation)
                .HasMaxLength(120)
                .HasColumnName("id_validation");
            entity.Property(e => e.Observaciones)
                .HasComment("Observaciones (campo libre)")
                .HasColumnName("observaciones");
            entity.Property(e => e.Payload)
                .HasColumnType("jsonb")
                .HasColumnName("payload");
            entity.Property(e => e.Prospecto)
                .HasComment("Id del prospecto")
                .HasColumnName("prospecto");
            entity.Property(e => e.ResultadoKyc)
                .HasMaxLength(120)
                .HasComment("Resultado en texto tal como lo devuelve el servicio KYC")
                .HasColumnName("resultado_kyc");
            entity.Property(e => e.ValidadoPor)
                .HasMaxLength(120)
                .HasComment("usuario de SBC que realizó la validación")
                .HasColumnName("validado_por");

            entity.HasOne(d => d.ProspectoNavigation).WithMany(p => p.ProspectoValidacions)
                .HasForeignKey(d => d.Prospecto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_prospect_relations_prospect");
        });

        modelBuilder.Entity<PubCateg>(entity =>
        {
            entity.HasKey(e => new { e.Publicacion, e.Categoria }).HasName("pk_pub_categ");

            entity.ToTable("pub_categ", tb => tb.HasComment("Categorías de la publicación"));

            entity.HasIndex(e => e.Publicacion, "relationship84fk");

            entity.Property(e => e.Publicacion)
                .HasComment("Id autonumérico de la publicación")
                .HasColumnName("publicacion");
            entity.Property(e => e.Categoria)
                .HasComment("Id de la categoría (Enum: CategPublicacion)")
                .HasColumnName("categoria");

            entity.HasOne(d => d.PublicacionNavigation).WithMany(p => p.PubCategs)
                .HasForeignKey(d => d.Publicacion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_pub_cate_relations_publicac");
        });

        modelBuilder.Entity<Publicacione>(entity =>
        {
            entity.HasKey(e => e.Publicacion).HasName("pk_publicaciones");

            entity.ToTable("publicaciones");

            entity.HasIndex(e => e.RangoDesde, "relationship81fk");

            entity.Property(e => e.Publicacion)
                .HasComment("Id autonumérico de la publicación")
                .HasColumnName("publicacion");
            entity.Property(e => e.Activo)
                .HasComment("publicación activa (se muestra)")
                .HasColumnName("activo");
            entity.Property(e => e.Contenido)
                .HasComment("Texto de la publicación con formato básico en html")
                .HasColumnName("contenido");
            entity.Property(e => e.Descarga).HasColumnName("descarga");
            entity.Property(e => e.EsBorrador)
                .HasComment("Indica si se trata de un borrador (no se muestra)")
                .HasColumnName("es_borrador");
            entity.Property(e => e.Extracto)
                .HasMaxLength(500)
                .HasComment("sinopsis de la publicación")
                .HasColumnName("extracto");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Idcultura).HasColumnName("idcultura");
            entity.Property(e => e.Imagen)
                .HasMaxLength(200)
                .HasColumnName("imagen");
            entity.Property(e => e.LigaBoton)
                .HasMaxLength(500)
                .HasComment("liga del botón URL")
                .HasColumnName("liga_boton");
            entity.Property(e => e.Rango)
                .HasComment("¿uso?")
                .HasColumnName("rango");
            entity.Property(e => e.RangoDesde)
                .HasComment("ID del rango")
                .HasColumnName("rango_desde");
            entity.Property(e => e.TextoBoton)
                .HasMaxLength(60)
                .HasComment("texto del boton (Abrir, Ir, ver más, inscribirse, etc)")
                .HasColumnName("texto_boton");
            entity.Property(e => e.Tipo)
                .HasComment("Tipo de publicación 1=Publicacion de Home, 2=Hack")
                .HasColumnName("tipo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .HasComment("Título de la publicación")
                .HasColumnName("titulo");

            entity.HasOne(d => d.RangoDesdeNavigation).WithMany(p => p.Publicaciones)
                .HasForeignKey(d => d.RangoDesde)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_publicac_relations_rangos");

            entity.HasMany(d => d.Pais).WithMany(p => p.Publicacions)
                .UsingEntity<Dictionary<string, object>>(
                    "PubPaise",
                    r => r.HasOne<Paise>().WithMany()
                        .HasForeignKey("Pais")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_pub_pais_pub_paise_paises"),
                    l => l.HasOne<Publicacione>().WithMany()
                        .HasForeignKey("Publicacion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_pub_pais_pub_paise_publicac"),
                    j =>
                    {
                        j.HasKey("Publicacion", "Pais").HasName("pk_pub_paises");
                        j.ToTable("pub_paises");
                        j.HasIndex(new[] { "Publicacion" }, "relationship79fk");
                        j.HasIndex(new[] { "Pais" }, "relationship80fk");
                        j.IndexerProperty<int>("Publicacion")
                            .HasComment("Id autonumérico de la publicación")
                            .HasColumnName("publicacion");
                        j.IndexerProperty<int>("Pais")
                            .HasComment("Id del país")
                            .HasColumnName("pais");
                    });

            entity.HasMany(d => d.Recursos).WithMany(p => p.Publicacions)
                .UsingEntity<Dictionary<string, object>>(
                    "PubRecurso",
                    r => r.HasOne<Recurso>().WithMany()
                        .HasForeignKey("Recurso")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_pub_recu_pub_recur_recursos"),
                    l => l.HasOne<Publicacione>().WithMany()
                        .HasForeignKey("Publicacion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_pub_recu_pub_recur_publicac"),
                    j =>
                    {
                        j.HasKey("Publicacion", "Recurso").HasName("pk_pub_recursos");
                        j.ToTable("pub_recursos");
                        j.HasIndex(new[] { "Publicacion" }, "relationship82fk");
                        j.HasIndex(new[] { "Recurso" }, "relationship83fk");
                        j.IndexerProperty<int>("Publicacion")
                            .HasComment("Id autonumérico de la publicación")
                            .HasColumnName("publicacion");
                        j.IndexerProperty<int>("Recurso")
                            .HasComment("id autonumérico del recurso")
                            .HasColumnName("recurso");
                    });
        });

        modelBuilder.Entity<Rango>(entity =>
        {
            entity.HasKey(e => e.Rango1).HasName("pk_rangos");

            entity.ToTable("rangos", tb => tb.HasComment("catalogo de rangos "));

            entity.Property(e => e.Rango1)
                .ValueGeneratedNever()
                .HasComment("ID del rango")
                .HasColumnName("rango");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasComment("Alias del rango")
                .HasColumnName("alias");
            entity.Property(e => e.BonoMensual)
                .HasComment("bono mensual que gana el socio por estar en este rango")
                .HasColumnName("bono_mensual");
            entity.Property(e => e.DirectosAdicionalReq)
                .HasComment("Cantidad de socios directos con plan adicional requeridos para el rango")
                .HasColumnName("directos_adicional_req");
            entity.Property(e => e.DirectosReq)
                .HasComment("Cantidad de socios directos (hijos) requeridos para el rango")
                .HasColumnName("directos_req");
            entity.Property(e => e.LineasReq)
                .HasComment("Lineas requeridas con socios con algún rango (antes estructura_rango)")
                .HasColumnName("lineas_req");
            entity.Property(e => e.NivelesAcumulado)
                .HasComment("Cuantos niveles de profundidad se consideran para el acumulado de la organización")
                .HasColumnName("niveles_acumulado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasComment("nombre del rango")
                .HasColumnName("nombre");
            entity.Property(e => e.RangoNext)
                .HasComment("Id del rango siguiente")
                .HasColumnName("rango_next");
            entity.Property(e => e.RangoPrev)
                .HasComment("Id del rango previo ")
                .HasColumnName("rango_prev");
            entity.Property(e => e.SaldoAcumuladoReq)
                .HasComment("Saldo acumulado de organización requerido para el rango")
                .HasColumnType("money")
                .HasColumnName("saldo_acumulado_req");
            entity.Property(e => e.SaldoPersonalReq)
                .HasComment("Saldo personal de planes adicionales requerido para el rango")
                .HasColumnType("money")
                .HasColumnName("saldo_personal_req");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<RangoExcepcione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rango_excepciones");

            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<RangoReqLinea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_rango_req_linea");

            entity.ToTable("rango_req_linea", tb => tb.HasComment("catalogo de rangos requeridos por cada línea para alcanzar un rango específico"));

            entity.HasIndex(e => e.Rango, "rangorangolineareqfk");

            entity.HasIndex(e => e.RangoReq, "rangosrangolineafk");

            entity.Property(e => e.Id)
                .HasComment("Id autonumérico de la línea")
                .HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("1")
                .HasComment("cuantos socios de este rango_requerido se necesitan en esta línea (default=1)")
                .HasColumnName("cantidad");
            entity.Property(e => e.NumLinea)
                .HasComment("Número de línea (1,2,3,...)")
                .HasColumnName("num_linea");
            entity.Property(e => e.Rango)
                .HasComment("Rango en cuestión (de quien se están poniendo los requisitos)")
                .HasColumnName("rango");
            entity.Property(e => e.RangoReq)
                .HasComment("Rango requerido en la línea")
                .HasColumnName("rango_req");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.RangoNavigation).WithMany(p => p.RangoReqLineaRangoNavigations)
                .HasForeignKey(d => d.Rango)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_rango_re_rango_ran_rangos");

            entity.HasOne(d => d.RangoReqNavigation).WithMany(p => p.RangoReqLineaRangoReqNavigations)
                .HasForeignKey(d => d.RangoReq)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_rango_re_rangos_ra_rangos");
        });

        modelBuilder.Entity<Recurso>(entity =>
        {
            entity.HasKey(e => e.Recurso1).HasName("pk_recursos");

            entity.ToTable("recursos", tb => tb.HasComment("contiene la biblioteca de recursos (videos, imágenes, documentos, etc)"));

            entity.Property(e => e.Recurso1)
                .HasComment("id autonumérico del recurso")
                .HasColumnName("recurso");
            entity.Property(e => e.Descarga).HasColumnName("descarga");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasComment("descripción del recurso")
                .HasColumnName("descripcion");
            entity.Property(e => e.Extension)
                .HasMaxLength(8)
                .HasComment("extensión del archivo (mp4, pdf, jpg, etcétera)")
                .HasColumnName("extension");
            entity.Property(e => e.FechaInsert).HasColumnName("fecha_insert");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasComment("nombre original del archivo")
                .HasColumnName("filename");
            entity.Property(e => e.FilenameMini)
                .HasMaxLength(100)
                .HasComment("nombre del archivo de miniatura (siempre jpg)")
                .HasColumnName("filename_mini");
            entity.Property(e => e.Filesize)
                .HasComment("tamaño del archivo en bytes")
                .HasColumnName("filesize");
            entity.Property(e => e.Habilitar).HasColumnName("habilitar");
            entity.Property(e => e.Idcultura).HasColumnName("idcultura");
            entity.Property(e => e.Link)
                .HasMaxLength(500)
                .HasComment("url del recurso (en caso de liga externa)")
                .HasColumnName("link");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasComment("nombre del recurso")
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo)
                .HasComment("tipo del recurso (en enum \"TipoRecurso\")")
                .HasColumnName("tipo");

            entity.HasMany(d => d.Interaccions).WithMany(p => p.Recursos)
                .UsingEntity<Dictionary<string, object>>(
                    "InterRecurso",
                    r => r.HasOne<Interaccione>().WithMany()
                        .HasForeignKey("Interaccion")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_inter_re_inter_rec_interacc"),
                    l => l.HasOne<Recurso>().WithMany()
                        .HasForeignKey("Recurso")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_inter_re_inter_rec_recursos"),
                    j =>
                    {
                        j.HasKey("Recurso", "Interaccion").HasName("pk_inter_recursos");
                        j.ToTable("inter_recursos");
                        j.HasIndex(new[] { "Interaccion" }, "interrecursos2fk");
                        j.HasIndex(new[] { "Recurso" }, "interrecursosfk");
                        j.IndexerProperty<int>("Recurso")
                            .HasComment("id autonumérico del recurso")
                            .HasColumnName("recurso");
                        j.IndexerProperty<int>("Interaccion").HasColumnName("interaccion");
                    });
        });

        modelBuilder.Entity<Socio>(entity =>
        {
            entity.HasKey(e => e.Socio1).HasName("pk_socios");

            entity.ToTable("socios", tb => tb.HasComment("Tabla de socios, almacena sólo socios que ya tienen al menos la membresía"));

            entity.HasIndex(e => e.AsignadoA, "asignadosregla51fk");

            entity.HasIndex(e => e.Padre, "genealogiafk");

            entity.HasIndex(e => e.Email, "idxsociosemail");

            entity.HasIndex(e => e.Membresia, "membresiasociofk");

            entity.HasIndex(e => e.Validacion, "validacionactualfk");

            entity.Property(e => e.Socio1)
                .ValueGeneratedNever()
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.ApellidoMat)
                .HasMaxLength(120)
                .HasComment("apellido materno")
                .HasColumnName("apellido_mat");
            entity.Property(e => e.ApellidoPat)
                .HasMaxLength(120)
                .HasComment("apellido paterno")
                .HasColumnName("apellido_pat");
            entity.Property(e => e.AsignadoA)
                .HasComment("Id del socio antecesor a quien este socio está asignado (regla 5-1)")
                .HasColumnName("asignado_a");
            entity.Property(e => e.BonoUnico)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("bono_unico");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(250)
                .HasComment("contraseña encriptada")
                .HasColumnName("contrasena");
            entity.Property(e => e.Cultura)
                .HasComment("Cultura (Idioma) del socio (es-MX, en-US, ...) viene de microcatálogo")
                .HasColumnName("cultura");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasComment("email del socio")
                .HasColumnName("email");
            entity.Property(e => e.Email2)
                .HasMaxLength(120)
                .HasComment("email alterno del socio")
                .HasColumnName("email2");
            entity.Property(e => e.EmailVerified)
                .HasComment("indica si la dirección de correo ya fué verificada (con link en correo)")
                .HasColumnName("email_verified");
            entity.Property(e => e.EsEmpleado)
                .HasComment("indica si el usuario es empleado de SBC")
                .HasColumnName("es_empleado");
            entity.Property(e => e.Estatus)
                .HasComment("Estatus del socio (1=Activo, 2=Bloqueado, 3=Borrado)")
                .HasColumnName("estatus");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("now()")
                .HasComment("Fecha en la que ingresó el socio a la organización")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaLimiteBeneficios).HasColumnName("fecha_limite_beneficios");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FechaVigenciaMembresia).HasColumnName("fecha_vigencia_membresia");
            entity.Property(e => e.FechaVigenciaSmartpack).HasColumnName("fecha_vigencia_smartpack");
            entity.Property(e => e.LastLogin)
                .HasDefaultValueSql("now()")
                .HasComment("fecha y hora del ultimo login")
                .HasColumnName("last_login");
            entity.Property(e => e.Membresia)
                .HasComment("Id autonumérico de la membresía")
                .HasColumnName("membresia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .HasComment("Nombre propio")
                .HasColumnName("nombre");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.Padre)
                .HasComment("Id del socio padre (upline)")
                .HasColumnName("padre");
            entity.Property(e => e.PhoneVerified)
                .HasComment("indica si el número telefónico ya fué verificado (con link en SMS)")
                .HasColumnName("phone_verified");
            entity.Property(e => e.Validacion)
                .HasComment("Folio de la validación más reciente")
                .HasColumnName("validacion");
            entity.Property(e => e.ZonaHoraria)
                .HasMaxLength(120)
                .HasComment("nombre canónico de la zona horaria del socio")
                .HasColumnName("zona_horaria");

            entity.HasOne(d => d.AsignadoANavigation).WithMany(p => p.InverseAsignadoANavigation)
                .HasForeignKey(d => d.AsignadoA)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socios_asignados_socios");

            entity.HasOne(d => d.MembresiaNavigation).WithMany(p => p.Socios)
                .HasForeignKey(d => d.Membresia)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socios_membresia_membresi");

            entity.HasOne(d => d.ValidacionNavigation).WithMany(p => p.Socios)
                .HasForeignKey(d => d.Validacion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socios_validacio_socio_va");

            entity.HasMany(d => d.Insignia).WithMany(p => p.Socios)
                .UsingEntity<Dictionary<string, object>>(
                    "SocioInsignia",
                    r => r.HasOne<Insignia>().WithMany()
                        .HasForeignKey("Insignia")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_socio_in_socio_ins_insignia"),
                    l => l.HasOne<Socio>().WithMany()
                        .HasForeignKey("Socio")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_socio_in_socio_ins_socios"),
                    j =>
                    {
                        j.HasKey("Socio", "Insignia").HasName("pk_socio_insignias");
                        j.ToTable("socio_insignias", tb => tb.HasComment("Almacena las insignias que ha ganado el socio"));
                        j.HasIndex(new[] { "Insignia" }, "socioinsignias2fk");
                        j.HasIndex(new[] { "Socio" }, "socioinsigniasfk");
                        j.IndexerProperty<int>("Socio")
                            .HasComment("Id del socio")
                            .HasColumnName("socio");
                        j.IndexerProperty<int>("Insignia")
                            .HasComment("Id de la insignia")
                            .HasColumnName("insignia");
                    });
        });

        modelBuilder.Entity<SocioAcumuladoNivel>(entity =>
        {
            entity.HasKey(e => new { e.Socio, e.Nivel }).HasName("pk_socio_acumulado_nivel");

            entity.ToTable("socio_acumulado_nivel", tb => tb.HasComment("Almacena los acumulados de la red de un socio, desglosado por nivel"));

            entity.HasIndex(e => e.Socio, "relationship63fk");

            entity.HasIndex(e => e.Plan, "relationship64fk");

            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.Nivel)
                .HasComment("Nivel de acumulado (1,2,3,...)")
                .HasColumnName("nivel");
            entity.Property(e => e.Estatus)
                .HasComment("Estatus del nivel 0=Abierto, 1=Cerrado, 2=Reabierto")
                .HasColumnName("estatus");
            entity.Property(e => e.FechaCierre)
                .HasComment("Fecha en que se cierra el nivel (igual a fecha de cierre del plan)")
                .HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaInicio)
                .HasComment("Fecha de inicio del acumulado (aprox un mes antes de la fecha de apertura del plan que abre el nivel)")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaLimite)
                .HasComment("Fecha limite para reabrir manteniendo la fecha_inicio sin cambio")
                .HasColumnName("fecha_limite");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.IdAux)
                .HasComment("id de legacy")
                .HasColumnName("id_aux");
            entity.Property(e => e.Plan)
                .HasComment("id del plan")
                .HasColumnName("plan");
            entity.Property(e => e.SaldoAcumulado)
                .HasComment("saldo acumulado en el nivel (Suma de planes del nivel")
                .HasColumnType("money")
                .HasColumnName("saldo_acumulado");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.SocioAcumuladoNivels)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_ac_plan_abre_socio_pr");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioAcumuladoNivels)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_ac_niveles_a_socios");
        });

        modelBuilder.Entity<SocioAcumuladoNivelHist>(entity =>
        {
            entity.HasKey(e => new { e.Folio, e.Socio }).HasName("pk_socio_acumulado_nivel_hist");

            entity.ToTable("socio_acumulado_nivel_hist");

            entity.HasIndex(e => e.Socio, "idx_socio_acumulado_nivel_hist_socio");

            entity.Property(e => e.Folio)
                .ValueGeneratedOnAdd()
                .HasColumnName("folio");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaCierre).HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaLimite).HasColumnName("fecha_limite");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.IdAux).HasColumnName("id_aux");
            entity.Property(e => e.Metodo).HasColumnName("metodo");
            entity.Property(e => e.Nivel).HasColumnName("nivel");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.SaldoAcumulado)
                .HasColumnType("money")
                .HasColumnName("saldo_acumulado");
        });

        modelBuilder.Entity<SocioAsignado>(entity =>
        {
            entity.HasKey(e => e.Socio).HasName("socio_asignado_pkey");

            entity.ToTable("socio_asignado");

            entity.Property(e => e.Socio)
                .ValueGeneratedNever()
                .HasColumnName("socio");
            entity.Property(e => e.AsignadoA).HasColumnName("asignado_a");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Padre).HasColumnName("padre");
        });

        modelBuilder.Entity<SocioBeneficiario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_socio_beneficiario");

            entity.ToTable("socio_beneficiario", tb => tb.HasComment("Datos del (los) beneficiario(s) del socio"));

            entity.HasIndex(e => e.Socio, "relationship11fk");

            entity.HasIndex(e => new { e.Pais, e.Estado }, "relationship15fk");

            entity.Property(e => e.Id)
                .HasComment("Id autonumérico del beneficiario")
                .HasColumnName("id");
            entity.Property(e => e.ApellidoMat)
                .HasMaxLength(120)
                .HasComment("apellido materno")
                .HasColumnName("apellido_mat");
            entity.Property(e => e.ApellidoPat)
                .HasMaxLength(120)
                .HasComment("apellido paterno")
                .HasColumnName("apellido_pat");
            entity.Property(e => e.Calle)
                .HasMaxLength(120)
                .HasComment("calle del domicilio del socio")
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(120)
                .HasComment("ciudad")
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(20)
                .HasComment("código postal")
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(120)
                .HasComment("colonia o barrio")
                .HasColumnName("colonia");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasComment("email primario")
                .HasColumnName("email");
            entity.Property(e => e.Email2)
                .HasMaxLength(120)
                .HasComment("email secundario")
                .HasColumnName("email2");
            entity.Property(e => e.Estado)
                .HasComment("id del estado")
                .HasColumnName("estado");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Municipio)
                .HasMaxLength(120)
                .HasComment("municipio")
                .HasColumnName("municipio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .HasComment("Nombre propio")
                .HasColumnName("nombre");
            entity.Property(e => e.NumExt)
                .HasMaxLength(50)
                .HasComment("número exterior")
                .HasColumnName("num_ext");
            entity.Property(e => e.NumInt)
                .HasMaxLength(50)
                .HasComment("número interior")
                .HasColumnName("num_int");
            entity.Property(e => e.Pais)
                .HasComment("Id del país")
                .HasColumnName("pais");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.TelCasa)
                .HasMaxLength(30)
                .HasComment("teléfono fijo de casa")
                .HasColumnName("tel_casa");
            entity.Property(e => e.TelCelular)
                .HasMaxLength(30)
                .HasComment("teléfono celular")
                .HasColumnName("tel_celular");
            entity.Property(e => e.TelOficina)
                .HasMaxLength(30)
                .HasComment("teléfono fijo del trabajo")
                .HasColumnName("tel_oficina");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioBeneficiarios)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_be_relations_socios");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SocioBeneficiarios)
                .HasForeignKey(d => new { d.Pais, d.Estado })
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_be_relations_estados");
        });

        modelBuilder.Entity<SocioDocumentacion>(entity =>
        {
            entity.HasKey(e => e.Anexo).HasName("pk_socio_documentacion");

            entity.ToTable("socio_documentacion", tb => tb.HasComment("Esta tabla almacena la documentación oficial del socio, como INE, CURP Comprobante de domicilio, etc\r\nson puros anexos (Ver Notas)\r\n\r\n"));

            entity.HasIndex(e => e.Socio, "relationship12fk");

            entity.HasIndex(e => e.Validacion, "relationship53fk");

            entity.Property(e => e.Anexo)
                .HasComment("id autonumérico del registro")
                .HasColumnName("anexo");
            entity.Property(e => e.Descargado)
                .HasComment("bandera que indica si el anexo ya fué descargado de metamap y alojado en un bucket")
                .HasColumnName("descargado");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Filename)
                .HasMaxLength(500)
                .HasComment("nombre original del archivo (Ver Notas)")
                .HasColumnName("filename");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.Tipo)
                .HasComment("tipo de documento (microcatálogo)")
                .HasColumnName("tipo");
            entity.Property(e => e.Validacion)
                .HasComment("Folio autonumérico ID del registro")
                .HasColumnName("validacion");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioDocumentacions)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_do_relations_socios");

            entity.HasOne(d => d.ValidacionNavigation).WithMany(p => p.SocioDocumentacions)
                .HasForeignKey(d => d.Validacion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_do_relations_socio_va");
        });

        modelBuilder.Entity<SocioEstatusExt>(entity =>
        {
            entity.HasKey(e => e.Socio).HasName("socio_estatus_ext_pkey");

            entity.ToTable("socio_estatus_ext", tb => tb.HasComment("Guarda el estado de validación del socio hacia sistemas externos"));

            entity.Property(e => e.Socio)
                .ValueGeneratedNever()
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.EstatusZendesk)
                .HasComment("Estatus que le da el servicio Zendesk.  0=PENDING, 1=OK, 2=WARNING, 3=FAIL")
                .HasColumnName("estatus_zendesk");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("'2023-03-26 11:39:31.108633-06'::timestamp with time zone")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("'2023-03-26 11:39:31.108633-06'::timestamp with time zone")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FechaZendesk)
                .HasComment("fecha en que se verificó por el servicio KYC")
                .HasColumnName("fecha_zendesk");
            entity.Property(e => e.Observaciones)
                .HasComment("Observaciones (campo libre)")
                .HasColumnName("observaciones");
            entity.Property(e => e.ResultadoZendesk)
                .HasMaxLength(120)
                .HasDefaultValueSql("NULL::character varying")
                .HasComment("Resultado en texto tal como lo devuelve el servicio KYC")
                .HasColumnName("resultado_zendesk");

            entity.HasOne(d => d.SocioNavigation).WithOne(p => p.SocioEstatusExt)
                .HasForeignKey<SocioEstatusExt>(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_socios_socio_estatus_ext_socio_socio");
        });

        modelBuilder.Entity<SocioEstrella>(entity =>
        {
            entity.HasKey(e => new { e.Socio, e.Estrellas }).HasName("pkey_socio_estrellas");

            entity.ToTable("socio_estrellas");

            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Estrellas).HasColumnName("estrellas");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FechaApertura).HasColumnName("fecha_apertura");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FolioHistorico).HasColumnName("folio_historico");
            entity.Property(e => e.SocioApertura).HasColumnName("socio_apertura");
        });

        modelBuilder.Entity<SocioEvaluacionRango>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socio_evaluacion_rangos", tb => tb.HasComment("Tabla para almacenar los nodos pendientes por procesar su rango"));

            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Fechainsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fechainsert");
            entity.Property(e => e.Fechaproceso).HasColumnName("fechaproceso");
            entity.Property(e => e.Fechaupdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fechaupdate");
            entity.Property(e => e.Folio)
                .ValueGeneratedOnAdd()
                .HasColumnName("folio");
            entity.Property(e => e.Origen).HasColumnName("origen");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.Procesado).HasColumnName("procesado");
            entity.Property(e => e.Resultado).HasColumnName("resultado");
            entity.Property(e => e.Socio).HasColumnName("socio");
        });

        modelBuilder.Entity<SocioInfo>(entity =>
        {
            entity.HasKey(e => e.Socio).HasName("pk_socio_info");

            entity.ToTable("socio_info", tb => tb.HasComment("Información adicional sobre el socio"));

            entity.HasIndex(e => e.ExternalId, "idxexternalid");

            entity.HasIndex(e => new { e.Pais, e.Estado }, "relationship10fk");

            entity.Property(e => e.Socio)
                .ValueGeneratedNever()
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.Calle)
                .HasMaxLength(120)
                .HasComment("calle del domicilio del socio")
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(120)
                .HasComment("ciudad")
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoMfa)
                .HasComment("código de validación de celular (se envia como SMS cada que se valida el celular) (No se usa para autentificación)")
                .HasColumnName("codigo_mfa");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(20)
                .HasComment("código postal")
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(120)
                .HasComment("colonia o barrio")
                .HasColumnName("colonia");
            entity.Property(e => e.CveFiscal)
                .HasMaxLength(120)
                .HasComment("Clave fiscal de la persona (en méxico RFC)")
                .HasColumnName("cve_fiscal");
            entity.Property(e => e.CveIdentidad)
                .HasMaxLength(120)
                .HasComment("clave oficial de identificación oficial (En méxico INE, en españa DNI)")
                .HasColumnName("cve_identidad");
            entity.Property(e => e.Direccion)
                .HasComment("Dirección completa como la devuelve Metamap")
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasComment("id del estado")
                .HasColumnName("estado");
            entity.Property(e => e.ExternalId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasComment("Id alterno para ligas de invitación")
                .HasColumnName("external_id");
            entity.Property(e => e.FechaAceptaAcademy).HasColumnName("fecha_acepta_academy");
            entity.Property(e => e.FechaAceptaContrato)
                .HasComment("Fecha en que aceptó y descargó contrato de membresía")
                .HasColumnName("fecha_acepta_contrato");
            entity.Property(e => e.FechaAceptaContratoPa)
                .HasComment("Fecha en que aceptó y descargó contrato de plan adicional")
                .HasColumnName("fecha_acepta_contrato_pa");
            entity.Property(e => e.FechaAceptaHacks).HasColumnName("fecha_acepta_hacks");
            entity.Property(e => e.FechaAceptaKey).HasColumnName("fecha_acepta_key");
            entity.Property(e => e.FechaAceptaQentrepreneur).HasColumnName("fecha_acepta_qentrepreneur");
            entity.Property(e => e.FechaAceptaQinvestor).HasColumnName("fecha_acepta_qinvestor");
            entity.Property(e => e.FechaAceptaQvalue).HasColumnName("fecha_acepta_qvalue");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaNacimiento)
                .HasComment("fecha de nacimiento del socio")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Foto)
                .HasMaxLength(500)
                .HasComment("Nombre del archivo foto (ver notas)")
                .HasColumnName("foto");
            entity.Property(e => e.FotoDescargada)
                .HasComment("bandera que indica si la foto ya fue descargada de metamap y puesta en un bucket")
                .HasColumnName("foto_descargada");
            entity.Property(e => e.Genero)
                .HasComment("1=Hombre, 2=Mujer, 3=Otro, ... (Microcatálogo)")
                .HasColumnName("genero");
            entity.Property(e => e.IntAhorro)
                .HasComment("tiene interés en ahorro (inversiones)")
                .HasColumnName("int_ahorro");
            entity.Property(e => e.IntEmprendimiento)
                .HasComment("tiene interés en emprendimiento")
                .HasColumnName("int_emprendimiento");
            entity.Property(e => e.IntFormacion)
                .HasComment("tiene interés en formación (educación financiera)")
                .HasColumnName("int_formacion");
            entity.Property(e => e.IntNetworking)
                .HasComment("tiene interés en networking (red multinivel)")
                .HasColumnName("int_networking");
            entity.Property(e => e.MedioContacto)
                .HasComment("Medio de contacto preferido. (1=email, 2=WhatsApp, 3=sms, 4=Otro) microcatálogo")
                .HasColumnName("medio_contacto");
            entity.Property(e => e.MedioContactoOtro)
                .HasMaxLength(120)
                .HasComment("Otro medio de contacto (cuando el preferido es 4=Otro)")
                .HasColumnName("medio_contacto_otro");
            entity.Property(e => e.Municipio)
                .HasMaxLength(120)
                .HasComment("municipio")
                .HasColumnName("municipio");
            entity.Property(e => e.NumExt)
                .HasMaxLength(50)
                .HasComment("número exterior")
                .HasColumnName("num_ext");
            entity.Property(e => e.NumInt)
                .HasMaxLength(50)
                .HasComment("número interior")
                .HasColumnName("num_int");
            entity.Property(e => e.Pais)
                .HasComment("Id del país")
                .HasColumnName("pais");
            entity.Property(e => e.TelCasa)
                .HasMaxLength(30)
                .HasComment("teléfono fijo de casa")
                .HasColumnName("tel_casa");
            entity.Property(e => e.TelCelular)
                .HasMaxLength(30)
                .HasComment("teléfono celular")
                .HasColumnName("tel_celular");
            entity.Property(e => e.TelOficina)
                .HasMaxLength(30)
                .HasComment("teléfono fijo del trabajo")
                .HasColumnName("tel_oficina");

            entity.HasOne(d => d.SocioNavigation).WithOne(p => p.SocioInfo)
                .HasForeignKey<SocioInfo>(d => d.Socio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_socio_in_relations_socios");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.SocioInfos)
                .HasForeignKey(d => new { d.Pais, d.Estado })
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_in_relations_estados");
        });

        modelBuilder.Entity<SocioKpi>(entity =>
        {
            entity.HasKey(e => e.Socio).HasName("pk_socio_kpi");

            entity.ToTable("socio_kpi", tb => tb.HasComment("Tabla concentradora de las metricas de los socios\r\n\r\nEsta tabla se actualizará en línea cada que:\r\n1) se integra un nuevo socio\r\n2) se efectua la compra de un plan adicional\r\n3) se hace algún retiro\r\n\r\n"));

            entity.HasIndex(e => e.UltimoCambio, "kpiultimocambiorangofk");

            entity.HasIndex(e => e.RangoPago, "rangopagosociofk");

            entity.HasIndex(e => e.Rango, "rangosociofk");

            entity.Property(e => e.Socio)
                .ValueGeneratedNever()
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.AlgoritmoRangos)
                .HasDefaultValueSql("1")
                .HasColumnName("algoritmo_rangos");
            entity.Property(e => e.CambioRango)
                .HasDefaultValueSql("0")
                .HasComment("Indica si cambió de rango 0=Sin Cambio, 1=Subió, 2=Bajó")
                .HasColumnName("cambio_rango");
            entity.Property(e => e.ConBeneficios)
                .HasDefaultValueSql("0")
                .HasComment("bandera para identificar si el socio tiene beneficios (ver notas)")
                .HasColumnName("con_beneficios");
            entity.Property(e => e.CorreoEnviado).HasColumnName("correo_enviado");
            entity.Property(e => e.Descendientes)
                .HasDefaultValueSql("0")
                .HasComment("Total de descendientes (contando todos sus hijos, nietos, bisnietos, etc)")
                .HasColumnName("descendientes");
            entity.Property(e => e.Directos)
                .HasDefaultValueSql("0")
                .HasComment("Total de Frontales ó afiliados directos (cantidad de socios directos del socio)")
                .HasColumnName("directos");
            entity.Property(e => e.DirectosPlan)
                .HasDefaultValueSql("0")
                .HasComment("Total de Frontales ó afiliados directos con planes  adicionales (cantidad de socios directos con plan adicional)")
                .HasColumnName("directos_plan");
            entity.Property(e => e.Ejecutivo).HasColumnName("ejecutivo");
            entity.Property(e => e.Estrellas).HasColumnName("estrellas");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaIniBeneficios)
                .HasComment("Fecha en la que inicia el goce de beneficios")
                .HasColumnName("fecha_ini_beneficios");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPago)
                .HasComment("próxima fecha de pago de bono mensual")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango)
                .HasComment("Fecha en que cambió de rango")
                .HasColumnName("fecha_rango");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FolioHist)
                .HasComment("ref folio  tabla socio_kpi_hist")
                .HasColumnName("folio_hist");
            entity.Property(e => e.Periodo)
                .HasComment("Periodo de cálculo de bonos 1=primera quincena, 2=segunda quincena")
                .HasColumnName("periodo");
            entity.Property(e => e.Procesado)
                .HasDefaultValueSql("0")
                .HasColumnName("procesado");
            entity.Property(e => e.Rango)
                .HasComment("ID del rango")
                .HasColumnName("rango");
            entity.Property(e => e.RangoPago)
                .HasComment("ID del rango del pago que se realizará")
                .HasColumnName("rango_pago");
            entity.Property(e => e.RangoV2).HasColumnName("rango_v2");
            entity.Property(e => e.SaldoEstrellas)
                .HasColumnType("money")
                .HasColumnName("saldo_estrellas");
            entity.Property(e => e.SaldoOrganizacion)
                .HasDefaultValueSql("0")
                .HasComment("Total de saldo acumulado por planes de su red (Cantidad de Saldo de la organización del socio)")
                .HasColumnType("money")
                .HasColumnName("saldo_organizacion");
            entity.Property(e => e.SaldoOrganizacionV2)
                .HasDefaultValueSql("0")
                .HasColumnType("money")
                .HasColumnName("saldo_organizacion_v2");
            entity.Property(e => e.SaldoPersonal)
                .HasDefaultValueSql("0")
                .HasComment("Total de saldo personal por planes adicionales (Cantidad de Saldo personal de planes adicionales por socio)\r\n")
                .HasColumnType("money")
                .HasColumnName("saldo_personal");
            entity.Property(e => e.UltimoCambio)
                .HasComment("folio del cambio de rango más reciente (socio_kpi_hist.folio)")
                .HasColumnName("ultimo_cambio");

            entity.HasOne(d => d.RangoNavigation).WithMany(p => p.SocioKpiRangoNavigations)
                .HasForeignKey(d => d.Rango)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_kp_rango_soc_rangos");

            entity.HasOne(d => d.RangoPagoNavigation).WithMany(p => p.SocioKpiRangoPagoNavigations)
                .HasForeignKey(d => d.RangoPago)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_kp_rangopago_rangos");
        });

        modelBuilder.Entity<SocioKpiHist>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_socio_kpi_hist_temp");

            entity.ToTable("socio_kpi_hist", tb => tb.HasComment("Histórico de cambios de rango de los socios\n\nCada que ocurre un cambio de rango en un socio se guarda un registro en esta tabla, de tal modo que, el registro más reciente contiene los kpi actuales vigentes del socio (una copia de socio_kpi)\n"));

            entity.HasIndex(e => e.Socio, "idx_socio_kpi_hist_socio");

            entity.Property(e => e.Folio)
                .HasDefaultValueSql("nextval('socio_kpi_hist_temp_folio_seq'::regclass)")
                .HasComment("folio autonumérico del registro")
                .HasColumnName("folio");
            entity.Property(e => e.CambioRango)
                .HasDefaultValueSql("0")
                .HasComment("Indica si cambió de rango 0=Sin Cambio, 1=Subió, 2=Bajó")
                .HasColumnName("cambio_rango");
            entity.Property(e => e.ConBeneficios)
                .HasDefaultValueSql("0")
                .HasComment("bandera para identificar si el socio tiene beneficios")
                .HasColumnName("con_beneficios");
            entity.Property(e => e.CorreoEnviado).HasColumnName("correo_enviado");
            entity.Property(e => e.Descendientes)
                .HasDefaultValueSql("0")
                .HasComment("Total de descendientes (contando todos sus hijos, nietos, bisnietos, etc)")
                .HasColumnName("descendientes");
            entity.Property(e => e.Directos)
                .HasDefaultValueSql("0")
                .HasComment("Total de Frontales ó afiliados directos (cantidad de socios directos del socio)")
                .HasColumnName("directos");
            entity.Property(e => e.DirectosPlan)
                .HasDefaultValueSql("0")
                .HasComment("Total de Frontales ó afiliados directos con planes  adicionales (cantidad de socios directos con plan adicional)")
                .HasColumnName("directos_plan");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPago)
                .HasComment("próxima fecha de pago de bono mensual")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango)
                .HasComment("Fecha en que ocurrió el cambio de rango")
                .HasColumnName("fecha_rango");
            entity.Property(e => e.Periodo)
                .HasComment("Periodo de cálculo de bonos 1=primera quincena, 2=segunda quincena")
                .HasColumnName("periodo");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoPago).HasColumnName("rango_pago");
            entity.Property(e => e.SaldoOrganizacion)
                .HasDefaultValueSql("0")
                .HasComment("Total de saldo acumulado por planes de su red (Cantidad de Saldo de la organización del socio)")
                .HasColumnType("money")
                .HasColumnName("saldo_organizacion");
            entity.Property(e => e.SaldoPersonal)
                .HasDefaultValueSql("0")
                .HasComment("Total de saldo personal por planes adicionales (Cantidad de Saldo personal de planes adicionales por socio)\n")
                .HasColumnType("money")
                .HasColumnName("saldo_personal");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioKpiHists)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_kpi_hist_temp_socio_soc");
        });

        modelBuilder.Entity<SocioKpiHistBorrar>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_socio_kpi_hist");

            entity.ToTable("socio_kpi_hist_borrar", tb => tb.HasComment("Histórico de cambios de rango de los socios\r\n\r\nCada que ocurre un cambio de rango en un socio se guarda un registro en esta tabla, de tal modo que, el registro más reciente contiene los kpi actuales vigentes del socio (una copia de socio_kpi)\r\n"));

            entity.HasIndex(e => e.Socio, "kpikpihistfk");

            entity.Property(e => e.Folio)
                .HasDefaultValueSql("nextval('socio_kpi_hist_folio_seq'::regclass)")
                .HasComment("folio autonumérico del registro")
                .HasColumnName("folio");
            entity.Property(e => e.CambioRango)
                .HasDefaultValueSql("0")
                .HasComment("Indica si cambió de rango 0=Sin Cambio, 1=Subió, 2=Bajó")
                .HasColumnName("cambio_rango");
            entity.Property(e => e.ConBeneficios)
                .HasDefaultValueSql("0")
                .HasComment("bandera para identificar si el socio tiene beneficios")
                .HasColumnName("con_beneficios");
            entity.Property(e => e.CorreoEnviado).HasColumnName("correo_enviado");
            entity.Property(e => e.Descendientes)
                .HasDefaultValueSql("0")
                .HasComment("Total de descendientes (contando todos sus hijos, nietos, bisnietos, etc)")
                .HasColumnName("descendientes");
            entity.Property(e => e.Directos)
                .HasDefaultValueSql("0")
                .HasComment("Total de Frontales ó afiliados directos (cantidad de socios directos del socio)")
                .HasColumnName("directos");
            entity.Property(e => e.DirectosPlan)
                .HasDefaultValueSql("0")
                .HasComment("Total de Frontales ó afiliados directos con planes  adicionales (cantidad de socios directos con plan adicional)")
                .HasColumnName("directos_plan");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPago)
                .HasComment("próxima fecha de pago de bono mensual")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango)
                .HasComment("Fecha en que ocurrió el cambio de rango")
                .HasColumnName("fecha_rango");
            entity.Property(e => e.Periodo)
                .HasComment("Periodo de cálculo de bonos 1=primera quincena, 2=segunda quincena")
                .HasColumnName("periodo");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoPago).HasColumnName("rango_pago");
            entity.Property(e => e.SaldoOrganizacion)
                .HasDefaultValueSql("0")
                .HasComment("Total de saldo acumulado por planes de su red (Cantidad de Saldo de la organización del socio)")
                .HasColumnType("money")
                .HasColumnName("saldo_organizacion");
            entity.Property(e => e.SaldoPersonal)
                .HasDefaultValueSql("0")
                .HasComment("Total de saldo personal por planes adicionales (Cantidad de Saldo personal de planes adicionales por socio)\r\n")
                .HasColumnType("money")
                .HasColumnName("saldo_personal");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioKpiHistBorrars)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_kp_kpi_kpihi_socio_kp");
        });

        modelBuilder.Entity<SocioKpiLineaHist>(entity =>
        {
            entity.HasKey(e => new { e.Folio, e.NumLinea }).HasName("pk_folio_linea");

            entity.ToTable("socio_kpi_linea_hist");

            entity.HasIndex(e => e.Folio, "relationship73fk");

            entity.Property(e => e.Folio)
                .HasComment("folio autonumérico del registro")
                .HasColumnName("folio");
            entity.Property(e => e.NumLinea).HasColumnName("num_linea");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FechaRango).HasColumnName("fecha_rango");
            entity.Property(e => e.IdSocio).HasColumnName("id_socio");
            entity.Property(e => e.Linea).HasColumnName("linea");
            entity.Property(e => e.Nivel).HasColumnName("nivel");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoReq).HasColumnName("rango_req");
            entity.Property(e => e.RangoReqText).HasColumnName("rango_req_text");
            entity.Property(e => e.RangoText).HasColumnName("rango_text");
            entity.Property(e => e.Socio).HasColumnName("socio");
        });

        modelBuilder.Entity<SocioKpiTest>(entity =>
        {
            entity.HasKey(e => e.Socio).HasName("pk_socio_kpi_test");

            entity.ToTable("socio_kpi_test");

            entity.Property(e => e.Socio)
                .ValueGeneratedNever()
                .HasColumnName("socio");
            entity.Property(e => e.CambioRango)
                .HasDefaultValueSql("0")
                .HasColumnName("cambio_rango");
            entity.Property(e => e.CambioRangoTest).HasColumnName("cambio_rango_test");
            entity.Property(e => e.ConBeneficios)
                .HasDefaultValueSql("0")
                .HasColumnName("con_beneficios");
            entity.Property(e => e.ConBeneficiosTest).HasColumnName("con_beneficios_test");
            entity.Property(e => e.CorreoEnviado).HasColumnName("correo_enviado");
            entity.Property(e => e.Descendientes)
                .HasDefaultValueSql("0")
                .HasColumnName("descendientes");
            entity.Property(e => e.Directos)
                .HasDefaultValueSql("0")
                .HasColumnName("directos");
            entity.Property(e => e.DirectosPlan)
                .HasDefaultValueSql("0")
                .HasColumnName("directos_plan");
            entity.Property(e => e.Ejecutivo).HasColumnName("ejecutivo");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaIniBeneficios).HasColumnName("fecha_ini_beneficios");
            entity.Property(e => e.FechaIniBeneficiosTest).HasColumnName("fecha_ini_beneficios_test");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango).HasColumnName("fecha_rango");
            entity.Property(e => e.FechaRangoTest).HasColumnName("fecha_rango_test");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.PeriodoTest).HasColumnName("periodo_test");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoPago).HasColumnName("rango_pago");
            entity.Property(e => e.RangoTest).HasColumnName("rango_test");
            entity.Property(e => e.SaldoOrganizacion)
                .HasDefaultValueSql("0")
                .HasColumnType("money")
                .HasColumnName("saldo_organizacion");
            entity.Property(e => e.SaldoPersonal)
                .HasDefaultValueSql("0")
                .HasColumnType("money")
                .HasColumnName("saldo_personal");
            entity.Property(e => e.UltimoCambio).HasColumnName("ultimo_cambio");
        });

        modelBuilder.Entity<SocioListaAsig>(entity =>
        {
            entity.HasKey(e => new { e.Socio, e.Posicion }).HasName("pk_socio_lista_asig");

            entity.ToTable("socio_lista_asig", tb => tb.HasComment("Almacena la lista de asignaciones del socio.\r\n\r\nAsignaciones de la regla de bonos 5-1"));

            entity.HasIndex(e => e.Valor, "idxlistavalor");

            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.Posicion).HasColumnName("posicion");
            entity.Property(e => e.Valor).HasColumnName("valor");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioListaAsigs)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_li_relations_socios");
        });

        modelBuilder.Entity<SocioProducto>(entity =>
        {
            entity.HasKey(e => e.Plan).HasName("pk_socio_productos");

            entity.ToTable("socio_productos", tb => tb.HasComment("\r\n\r\n(depositos_inversion)"));

            entity.HasIndex(e => e.Compra, "comprasocioprodfk");

            entity.HasIndex(e => e.IdLegacy, "idx_id_legacy_socio_productos");

            entity.HasIndex(e => e.Socio, "relationship1fk");

            entity.HasIndex(e => e.Producto, "relationship2fk");

            entity.HasIndex(e => e.Promocion, "relationship41fk");

            entity.Property(e => e.Plan)
                .HasComment("id del plan")
                .HasColumnName("plan");
            entity.Property(e => e.Activo)
                .HasComment("Indica si el plan puede tener retiros y rendimientos ")
                .HasColumnName("activo");
            entity.Property(e => e.Capital)
                .HasComment("Capital inicial de la inversión (puede ser afectado por un retiro)")
                .HasColumnType("money")
                .HasColumnName("capital");
            entity.Property(e => e.CapitalInicial)
                .HasComment("Capital inicial de la inversión")
                .HasColumnType("money")
                .HasColumnName("capital_inicial");
            entity.Property(e => e.Cerrado)
                .HasComment("Indica si el producto está cerrado (se retiró todo o casi todo el dinero)")
                .HasColumnName("cerrado");
            entity.Property(e => e.Comision)
                .HasPrecision(10, 3)
                .HasComment("porcentaje de comision cuando se hace un retiro antes del plazo mínimo (expresado como fracción)")
                .HasColumnName("comision");
            entity.Property(e => e.Compra)
                .HasComment("Folio autonumérico de la compra o intención de compra")
                .HasColumnName("compra");
            entity.Property(e => e.Duracion)
                .HasComment("duración nominal del producto en meses (normalmente 24 meses) 0=Eterno")
                .HasColumnName("duracion");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaCalculo)
                .HasComment("fecha en la que se calculó el capital")
                .HasColumnName("fecha_calculo");
            entity.Property(e => e.FechaCierre)
                .HasComment("fecha de cierre del producto o plan")
                .HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaCompra)
                .HasComment("fecha de la compra (igual a compras.fecha_pago)")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.FechaInicio)
                .HasComment("Fecha de inicio de operaciones del producto")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.IdLegacy).HasColumnName("id_legacy");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .HasComment("Moneda (Enum Monedas [sValor])")
                .HasColumnName("moneda");
            entity.Property(e => e.Observaciones)
                .HasComment("campo de observaciones libre")
                .HasColumnName("observaciones");
            entity.Property(e => e.PlazoComision)
                .HasComment("duración en meses del plazo mínimo para no causar comisiones al retirar ")
                .HasColumnName("plazo_comision");
            entity.Property(e => e.PlazoForzoso)
                .HasComment("plazo mínimo forzoso en meses donde No se puede retirar (normalmente 24 en membresías y 0 en planes adicionales)")
                .HasColumnName("plazo_forzoso");
            entity.Property(e => e.Producto)
                .HasComment("id autonumérico del producto ")
                .HasColumnName("producto");
            entity.Property(e => e.Promocion)
                .HasComment("Id de la promoción")
                .HasColumnName("promocion");
            entity.Property(e => e.ReglaCapitalizacion)
                .HasComment("Viene de microcatálogo (ReglasCapitalizacion) 1=Mensual, 2=Quincenal")
                .HasColumnName("regla_capitalizacion");
            entity.Property(e => e.Rendimiento)
                .HasPrecision(10, 3)
                .HasComment("Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2) PUEDE VARIAR CON LOS RETIROS")
                .HasColumnName("rendimiento");
            entity.Property(e => e.RendimientoInicial)
                .HasPrecision(10, 3)
                .HasComment("Porcentaje de rendimiento mensual (expresado como fracción, o sea 20%= 0.2)")
                .HasColumnName("rendimiento_inicial");
            entity.Property(e => e.Saldo)
                .HasComment("Capital actual de la inversión (va creciendo cada mes)")
                .HasColumnType("money")
                .HasColumnName("saldo");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");

            entity.HasOne(d => d.CompraNavigation).WithMany(p => p.SocioProductos)
                .HasForeignKey(d => d.Compra)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_pr_comprasoc_compras");

            entity.HasOne(d => d.PromocionNavigation).WithMany(p => p.SocioProductos)
                .HasForeignKey(d => d.Promocion)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_pr_relations_promocio");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioProductos)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_socio_pr_relations_producto");
        });

        modelBuilder.Entity<SocioRenovacione>(entity =>
        {
            entity.HasKey(e => e.Folio).HasName("pk_socio_renovaciones");

            entity.ToTable("socio_renovaciones", tb => tb.HasComment("Histórico de renovación de membresías"));

            entity.HasIndex(e => e.Socio, "relationship88fk");

            entity.HasIndex(e => e.Compra, "relationship89fk");

            entity.Property(e => e.Folio)
                .HasComment("folio autonumérico de la renovación de membresía")
                .HasColumnName("folio");
            entity.Property(e => e.Compra)
                .HasComment("Folio autonumérico de la compra o intención de compra")
                .HasColumnName("compra");
            entity.Property(e => e.EstatusMembresia)
                .HasComment("Estatus de la membresía del socio al momento de la renovación (enum.EstatusMembresiaSocio)")
                .HasColumnName("estatus_membresia");
            entity.Property(e => e.FechaVigencia)
                .HasComment("fecha de la nueva vigencia de la membresía")
                .HasColumnName("fecha_vigencia");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");

            entity.HasOne(d => d.CompraNavigation).WithMany(p => p.SocioRenovaciones)
                .HasForeignKey(d => d.Compra)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_re_relations_compras");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioRenovaciones)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_re_relations_socios");
        });

        modelBuilder.Entity<SocioValidacion>(entity =>
        {
            entity.HasKey(e => e.Validacion).HasName("pk_socio_validacion");

            entity.ToTable("socio_validacion", tb => tb.HasComment("Guarda el estado de la validación del socio (Ver notas)"));

            entity.Property(e => e.Validacion)
                .HasComment("Folio autonumérico ID del registro")
                .HasColumnName("validacion");
            entity.Property(e => e.AutorizadoPor)
                .HasMaxLength(120)
                .HasComment("usuario de SBC que autorizó al socio (en caso de tener warning o fail)")
                .HasColumnName("autorizado_por");
            entity.Property(e => e.Estatus)
                .HasComment("Estatus general (Ver Notas) 0=PENDING, 1=OK, 2=WARNING, 3=FAIL ")
                .HasColumnName("estatus");
            entity.Property(e => e.EstatusKyc)
                .HasComment("Estatus que le da el servicio KYC.  0=PENDING, 1=OK, 2=WARNING, 3=FAIL")
                .HasColumnName("estatus_kyc");
            entity.Property(e => e.FechaEmpresa)
                .HasComment("Fecha en que se realizó la verificación por la empresa")
                .HasColumnName("fecha_empresa");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaKyc)
                .HasComment("fecha en que se verificó por el servicio KYC")
                .HasColumnName("fecha_kyc");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FechaValidacion)
                .HasComment("Fecha de validación interna")
                .HasColumnName("fecha_validacion");
            entity.Property(e => e.IdRelated)
                .HasMaxLength(120)
                .HasColumnName("id_related");
            entity.Property(e => e.IdValidation)
                .HasMaxLength(120)
                .HasColumnName("id_validation");
            entity.Property(e => e.Observaciones)
                .HasComment("Observaciones (campo libre)")
                .HasColumnName("observaciones");
            entity.Property(e => e.Payload)
                .HasColumnType("jsonb")
                .HasColumnName("payload");
            entity.Property(e => e.ResultadoKyc)
                .HasMaxLength(120)
                .HasComment("Resultado en texto tal como lo devuelve el servicio KYC")
                .HasColumnName("resultado_kyc");
            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.ValidadoPor)
                .HasMaxLength(120)
                .HasComment("usuario de SBC que realizó la validación")
                .HasColumnName("validado_por");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioValidacions)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_va_relations_socios");
        });

        modelBuilder.Entity<SocioWallet>(entity =>
        {
            entity.HasKey(e => new { e.Socio, e.NumWallet }).HasName("pk_socio_wallet");

            entity.ToTable("socio_wallet", tb => tb.HasComment("tabla de registro de la wallet del socio\r\n(sólo puede tener UNA ACTIVA)"));

            entity.Property(e => e.Socio)
                .HasComment("Id del socio")
                .HasColumnName("socio");
            entity.Property(e => e.NumWallet)
                .HasComment("Número de wallet del socio (solo una puede estar activa)")
                .HasColumnName("num_wallet");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.Criptomoneda)
                .HasComment("clave de tipo de criptomoneda (de microcatálogo)")
                .HasColumnName("criptomoneda");
            entity.Property(e => e.FechaAlta)
                .HasDefaultValueSql("now()")
                .HasComment("Fecha de Registro de la wallet")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaBaja).HasColumnName("fecha_baja");
            entity.Property(e => e.FechaInsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fecha_update");
            entity.Property(e => e.FechaValidacion)
                .HasComment("Fecha de validacion")
                .HasColumnName("fecha_validacion");
            entity.Property(e => e.Validado)
                .HasComment("Bandera para verificar si el wallet ha sido validado")
                .HasColumnName("validado");
            entity.Property(e => e.Wallet)
                .HasMaxLength(300)
                .HasComment("clave de wallet")
                .HasColumnName("wallet");

            entity.HasOne(d => d.SocioNavigation).WithMany(p => p.SocioWallets)
                .HasForeignKey(d => d.Socio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_socio_wa_relations_socios");
        });

        modelBuilder.Entity<SolicitudesRetiro>(entity =>
        {
            entity.HasKey(e => e.SolicitudRetiro).HasName("pk_solicitudes_retiro");

            entity.ToTable("solicitudes_retiro", tb => tb.HasComment("Almacena las solicitudes de retiro y lleva control de su validación\r\n\r\nCuando un socio desea hacer un retiro, primero que nada se registra su solicitud en esta tabla y se manda un correo con la clave de validación.\r\nSi el socio realiza la validación correctamente, entonces se registra el retiro en la tabla movimientos y se solicita su pago en la tabla pagos"));

            entity.HasIndex(e => e.Plan, "plansolretirofk");

            entity.Property(e => e.SolicitudRetiro)
                .HasComment("folio autonumérico del registro")
                .HasColumnName("solicitud_retiro");
            entity.Property(e => e.ClaveValidacion)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasComment("clave UUID (autogenerada) que identifica la solicitud y sirve para la autorización del retiro")
                .HasColumnName("clave_validacion");
            entity.Property(e => e.CorreoEnviado)
                .HasComment("indica si ya se envió el correo al socio para validar la solicitud")
                .HasColumnName("correo_enviado");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("now()")
                .HasComment("Fecha y hora de la solicitud de retiro")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.FechaValidacion)
                .HasComment("Fecha y hora en que el usuario realizó la validación de su solicitud")
                .HasColumnName("fecha_validacion");
            entity.Property(e => e.Monto)
                .HasComment("Monto a retirar")
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.Plan)
                .HasComment("id del plan")
                .HasColumnName("plan");
            entity.Property(e => e.Procesado)
                .HasComment("Indica si el retiro ya fue procesado para el cálculo de rangos")
                .HasColumnName("procesado");
            entity.Property(e => e.Validado)
                .HasComment("indica si el retiro ya fué autorizado por el usuario")
                .HasColumnName("validado");
            entity.Property(e => e.Vigencia)
                .HasComment("Fecha y hora límite en la que se puede realizar la validación de la solicitud")
                .HasColumnName("vigencia");

            entity.HasOne(d => d.PlanNavigation).WithMany(p => p.SolicitudesRetiros)
                .HasForeignKey(d => d.Plan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_solicitu_plan_sol__socio_pr");
        });

        modelBuilder.Entity<TipoInteraccione>(entity =>
        {
            entity.HasKey(e => e.Tipo).HasName("pk_tipo_interacciones");

            entity.ToTable("tipo_interacciones");

            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fechainsert)
                .HasDefaultValueSql("now()")
                .HasColumnName("fechainsert");
            entity.Property(e => e.Fechaupdate)
                .HasDefaultValueSql("now()")
                .HasColumnName("fechaupdate");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<VDirecto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_directos");

            entity.Property(e => e.Count).HasColumnName("count");
        });

        modelBuilder.Entity<VEstatusMembresium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_estatus_membresia");

            entity.Property(e => e.EstatusMembresia).HasColumnName("estatus_membresia");
        });

        modelBuilder.Entity<VPlanReserva>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_plan_reserva");

            entity.Property(e => e.Plan).HasColumnName("plan");
        });

        modelBuilder.Entity<VPrimerPlanOmega>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_primer_plan_omega");

            entity.Property(e => e.Plan).HasColumnName("plan");
        });

        modelBuilder.Entity<VRendimientoPi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_rendimiento_pi");

            entity.Property(e => e.Rendimiento)
                .HasPrecision(10, 3)
                .HasColumnName("rendimiento");
        });

        modelBuilder.Entity<VRequisitosFaltante>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_requisitos_faltantes");

            entity.Property(e => e.Count).HasColumnName("count");
        });

        modelBuilder.Entity<VSaldoAcumulado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("v_saldo_acumulado");

            entity.Property(e => e.Sum)
                .HasColumnType("money")
                .HasColumnName("sum");
        });

        modelBuilder.Entity<XMasterBonusLegacy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("x_master_bonus_legacy");

            entity.Property(e => e.Aaaa).HasColumnName("aaaa");
            entity.Property(e => e.Dd).HasColumnName("dd");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango).HasColumnName("fecha_rango");
            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_reg");
            entity.Property(e => e.IdRef).HasColumnName("id_ref");
            entity.Property(e => e.Mm).HasColumnName("mm");
            entity.Property(e => e.Monto)
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("100")
                .HasColumnName("status");
        });

        modelBuilder.Entity<XMasterBonusLegacy2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("x_master_bonus_legacy_2");

            entity.Property(e => e.Aaaa).HasColumnName("aaaa");
            entity.Property(e => e.Dd).HasColumnName("dd");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango).HasColumnName("fecha_rango");
            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_reg");
            entity.Property(e => e.IdRef).HasColumnName("id_ref");
            entity.Property(e => e.Mm).HasColumnName("mm");
            entity.Property(e => e.Monto)
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("100")
                .HasColumnName("status");
        });

        modelBuilder.Entity<XPagosBlockchain>(entity =>
        {
            entity.HasKey(e => e.IdKian).HasName("pk_pagos_blockchain");

            entity.ToTable("x_pagos_blockchain");

            entity.Property(e => e.IdKian)
                .ValueGeneratedNever()
                .HasColumnName("id_kian");
            entity.Property(e => e.Cotizabtc)
                .HasPrecision(17, 8)
                .HasColumnName("cotizabtc");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Hash)
                .HasMaxLength(300)
                .HasColumnName("hash");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasColumnName("moneda");
            entity.Property(e => e.Monto)
                .HasColumnType("money")
                .HasColumnName("monto");
            entity.Property(e => e.Montobtc)
                .HasPrecision(12, 8)
                .HasColumnName("montobtc");
            entity.Property(e => e.Pago).HasColumnName("pago");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Ticket)
                .HasMaxLength(80)
                .HasColumnName("ticket");
            entity.Property(e => e.Tipopago)
                .HasMaxLength(10)
                .HasColumnName("tipopago");
            entity.Property(e => e.Wallet)
                .HasMaxLength(300)
                .HasColumnName("wallet");
        });

        modelBuilder.Entity<XPagosLegacy>(entity =>
        {
            entity.HasKey(e => e.IdLegacy).HasName("pk_pagos_legacy");

            entity.ToTable("x_pagos_legacy");

            entity.Property(e => e.IdLegacy)
                .ValueGeneratedNever()
                .HasColumnName("id_legacy");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("cantidad");
            entity.Property(e => e.ComisionPagada).HasColumnName("comision_pagada");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.FechaAlta).HasColumnName("fecha_alta");
            entity.Property(e => e.FechaPagada).HasColumnName("fecha_pagada");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.IdPlanRef).HasColumnName("id_plan_ref");
            entity.Property(e => e.IdSocioRef).HasColumnName("id_socio_ref");
            entity.Property(e => e.MandarAPagar).HasColumnName("mandar_a_pagar");
            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreTipo)
                .HasMaxLength(100)
                .HasColumnName("nombre_tipo");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(120)
                .HasColumnName("observaciones");
            entity.Property(e => e.Referencia)
                .HasMaxLength(120)
                .HasColumnName("referencia");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.WalletEmisor)
                .HasMaxLength(120)
                .HasColumnName("wallet_emisor");
            entity.Property(e => e.WalletReceptor)
                .HasMaxLength(120)
                .HasColumnName("wallet_receptor");
        });

        modelBuilder.Entity<YSocioAcumuladoNivel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("y_socio_acumulado_nivel");

            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FechaCierre).HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaLimite).HasColumnName("fecha_limite");
            entity.Property(e => e.IdAux).HasColumnName("id_aux");
            entity.Property(e => e.Nivel).HasColumnName("nivel");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.SaldoAcumulado)
                .HasColumnType("money")
                .HasColumnName("saldo_acumulado");
            entity.Property(e => e.Socio).HasColumnName("socio");
        });

        modelBuilder.Entity<ZComprasPerdida>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_compras_perdidas");

            entity.Property(e => e.Compra).HasColumnName("compra");
        });

        modelBuilder.Entity<ZConciliacionTdc>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("z_conciliacion_tdc_pkey");

            entity.ToTable("z_conciliacion_tdc", tb => tb.HasComment("Para procesar masivamente las compras con tdc de smart"));

            entity.Property(e => e.TransactionId)
                .HasColumnType("character varying")
                .HasColumnName("transaction_id");
            entity.Property(e => e.AmountMxn)
                .HasColumnType("money")
                .HasColumnName("amount_mxn");
            entity.Property(e => e.AmountUsd)
                .HasColumnType("money")
                .HasColumnName("amount_usd");
            entity.Property(e => e.Authorizationv)
                .HasColumnType("character varying")
                .HasColumnName("authorizationv");
            entity.Property(e => e.CardNumber)
                .HasColumnType("character varying")
                .HasColumnName("card_number");
            entity.Property(e => e.Category)
                .HasColumnType("character varying")
                .HasColumnName("category");
            entity.Property(e => e.Compra).HasColumnName("compra");
            entity.Property(e => e.Conciliated)
                .HasColumnType("character varying")
                .HasColumnName("conciliated");
            entity.Property(e => e.CreationDate)
                .HasColumnType("character varying")
                .HasColumnName("creation_date");
            entity.Property(e => e.Currency)
                .HasColumnType("character varying")
                .HasColumnName("currency");
            entity.Property(e => e.CustomerLastname)
                .HasColumnType("character varying")
                .HasColumnName("customer_lastname");
            entity.Property(e => e.CustomerName)
                .HasColumnType("character varying")
                .HasColumnName("customer_name");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Estatus)
                .HasColumnType("character varying")
                .HasColumnName("estatus");
            entity.Property(e => e.ExchangeRate)
                .HasColumnType("money")
                .HasColumnName("exchange_rate");
            entity.Property(e => e.OperationDate)
                .HasColumnType("character varying")
                .HasColumnName("operation_date");
            entity.Property(e => e.OperationType)
                .HasColumnType("character varying")
                .HasColumnName("operation_type");
            entity.Property(e => e.OrderId)
                .HasColumnType("character varying")
                .HasColumnName("order_id");
            entity.Property(e => e.Payload)
                .HasColumnType("jsonb")
                .HasColumnName("payload");
            entity.Property(e => e.Procesado).HasColumnName("procesado");
            entity.Property(e => e.Prospecto).HasColumnName("prospecto");
        });

        modelBuilder.Entity<ZContra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_contras");

            entity.Property(e => e.Contrasena)
                .HasMaxLength(250)
                .HasColumnName("contrasena");
            entity.Property(e => e.Socio).HasColumnName("socio");
        });

        modelBuilder.Entity<ZInterRecurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_inter_recursos");

            entity.Property(e => e.Interaccion).HasColumnName("interaccion");
            entity.Property(e => e.Recurso).HasColumnName("recurso");
        });

        modelBuilder.Entity<ZInteraccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_interacciones");

            entity.Property(e => e.Comentarios)
                .HasMaxLength(500)
                .HasColumnName("comentarios");
            entity.Property(e => e.Cuerpo).HasColumnName("cuerpo");
            entity.Property(e => e.Enviado).HasColumnName("enviado");
            entity.Property(e => e.Fechaentrega).HasColumnName("fechaentrega");
            entity.Property(e => e.Fechaenvio).HasColumnName("fechaenvio");
            entity.Property(e => e.Fechainsert).HasColumnName("fechainsert");
            entity.Property(e => e.Fechalectura).HasColumnName("fechalectura");
            entity.Property(e => e.Fechaupdate).HasColumnName("fechaupdate");
            entity.Property(e => e.Interaccion).HasColumnName("interaccion");
            entity.Property(e => e.Leido).HasColumnName("leido");
            entity.Property(e => e.Prospecto).HasColumnName("prospecto");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .HasColumnName("titulo");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .HasColumnName("url");
        });

        modelBuilder.Entity<ZListaCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_lista_compras");

            entity.Property(e => e.Compra).HasColumnName("compra");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Hash).HasColumnName("hash");
        });

        modelBuilder.Entity<ZNivel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_nivel");

            entity.Property(e => e.AplicaPorcent).HasColumnName("aplica_porcent");
            entity.Property(e => e.Cerrado).HasColumnName("cerrado");
            entity.Property(e => e.ChecarFecha).HasColumnName("checar_fecha");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaCierre).HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaInicioAcumulado).HasColumnName("fecha_inicio_acumulado");
            entity.Property(e => e.FechaLimite).HasColumnName("fecha_limite");
            entity.Property(e => e.FechaPeriodo).HasColumnName("fecha_periodo");
            entity.Property(e => e.FechaPreLimite).HasColumnName("fecha_pre_limite");
            entity.Property(e => e.FechaReg)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_reg");
            entity.Property(e => e.FechaUpd)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_upd");
            entity.Property(e => e.FechaValidoPago).HasColumnName("fecha_valido_pago");
            entity.Property(e => e.IdCalificado).HasColumnName("id_calificado");
            entity.Property(e => e.IdDeposito).HasColumnName("id_deposito");
            entity.Property(e => e.Nivl).HasColumnName("nivl");
            entity.Property(e => e.SaldoAcumulado).HasColumnName("saldo_acumulado");
            entity.Property(e => e.SaldoLimite).HasColumnName("saldo_limite");
            entity.Property(e => e.SaldoPendiente).HasColumnName("saldo_pendiente");
            entity.Property(e => e.SaldoPrelimite).HasColumnName("saldo_prelimite");
            entity.Property(e => e.SubscriberId).HasColumnName("subscriber_id");
        });

        modelBuilder.Entity<ZPagosAtrasado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_pagos_atrasados");

            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.Pago).HasColumnName("pago");
        });

        modelBuilder.Entity<ZPubCateg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_pub_categ");

            entity.Property(e => e.Categoria).HasColumnName("categoria");
            entity.Property(e => e.Publicacion).HasColumnName("publicacion");
        });

        modelBuilder.Entity<ZPubPaise>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_pub_paises");

            entity.Property(e => e.Pais).HasColumnName("pais");
            entity.Property(e => e.Publicacion).HasColumnName("publicacion");
        });

        modelBuilder.Entity<ZPubRecurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_pub_recursos");

            entity.Property(e => e.Publicacion).HasColumnName("publicacion");
            entity.Property(e => e.Recurso).HasColumnName("recurso");
        });

        modelBuilder.Entity<ZPublicacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_publicaciones");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contenido).HasColumnName("contenido");
            entity.Property(e => e.EsBorrador).HasColumnName("es_borrador");
            entity.Property(e => e.Extracto)
                .HasMaxLength(500)
                .HasColumnName("extracto");
            entity.Property(e => e.FechaInsert).HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate).HasColumnName("fecha_update");
            entity.Property(e => e.LigaBoton)
                .HasMaxLength(500)
                .HasColumnName("liga_boton");
            entity.Property(e => e.Publicacion).HasColumnName("publicacion");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoDesde).HasColumnName("rango_desde");
            entity.Property(e => e.TextoBoton)
                .HasMaxLength(60)
                .HasColumnName("texto_boton");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .HasColumnName("titulo");
        });

        modelBuilder.Entity<ZRango>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_rangos");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.BonoMensual).HasColumnName("bono_mensual");
            entity.Property(e => e.DirectosAdicionalReq).HasColumnName("directos_adicional_req");
            entity.Property(e => e.DirectosReq).HasColumnName("directos_req");
            entity.Property(e => e.LineasReq).HasColumnName("lineas_req");
            entity.Property(e => e.NivelesAcumulado).HasColumnName("niveles_acumulado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoNext).HasColumnName("rango_next");
            entity.Property(e => e.RangoPrev).HasColumnName("rango_prev");
            entity.Property(e => e.SaldoAcumuladoReq)
                .HasColumnType("money")
                .HasColumnName("saldo_acumulado_req");
            entity.Property(e => e.SaldoPersonalReq)
                .HasColumnType("money")
                .HasColumnName("saldo_personal_req");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<ZRangoReqLinea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_rango_req_linea");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NumLinea).HasColumnName("num_linea");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoReq).HasColumnName("rango_req");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<ZRecurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_recursos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.Extension)
                .HasMaxLength(8)
                .HasColumnName("extension");
            entity.Property(e => e.FechaInsert).HasColumnName("fecha_insert");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasColumnName("filename");
            entity.Property(e => e.FilenameMini)
                .HasMaxLength(100)
                .HasColumnName("filename_mini");
            entity.Property(e => e.Filesize).HasColumnName("filesize");
            entity.Property(e => e.Link)
                .HasMaxLength(500)
                .HasColumnName("link");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Recurso).HasColumnName("recurso");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<ZRetiroscomisionmala>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_retiroscomisionmala");

            entity.Property(e => e.Abono)
                .HasColumnType("money")
                .HasColumnName("abono");
            entity.Property(e => e.Capital)
                .HasColumnType("money")
                .HasColumnName("capital");
            entity.Property(e => e.Cargo)
                .HasColumnType("money")
                .HasColumnName("cargo");
            entity.Property(e => e.Comision)
                .HasColumnType("money")
                .HasColumnName("comision");
            entity.Property(e => e.Dia)
                .HasMaxLength(3)
                .HasColumnName("dia");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdAux).HasColumnName("id_aux");
            entity.Property(e => e.IdAux2).HasColumnName("id_aux2");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Pago).HasColumnName("pago");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.PorcentajeDiario)
                .HasPrecision(10, 6)
                .HasColumnName("porcentaje_diario");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<ZSocioAcumuladoNivel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_socio_acumulado_nivel");

            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FechaCierre).HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaLimite).HasColumnName("fecha_limite");
            entity.Property(e => e.IdAux).HasColumnName("id_aux");
            entity.Property(e => e.Nivel).HasColumnName("nivel");
            entity.Property(e => e.Plan).HasColumnName("plan");
            entity.Property(e => e.SaldoAcumulado)
                .HasColumnType("money")
                .HasColumnName("saldo_acumulado");
            entity.Property(e => e.Socio).HasColumnName("socio");
        });

        modelBuilder.Entity<ZSocioKpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_socio_kpi");

            entity.Property(e => e.CambioRango).HasColumnName("cambio_rango");
            entity.Property(e => e.ConBeneficios).HasColumnName("con_beneficios");
            entity.Property(e => e.CorreoEnviado).HasColumnName("correo_enviado");
            entity.Property(e => e.Descendientes).HasColumnName("descendientes");
            entity.Property(e => e.Directos).HasColumnName("directos");
            entity.Property(e => e.DirectosPlan).HasColumnName("directos_plan");
            entity.Property(e => e.Etl).HasColumnName("etl");
            entity.Property(e => e.FechaIniBeneficios).HasColumnName("fecha_ini_beneficios");
            entity.Property(e => e.FechaInsert).HasColumnName("fecha_insert");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRango).HasColumnName("fecha_rango");
            entity.Property(e => e.FechaUpdate).HasColumnName("fecha_update");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Rango).HasColumnName("rango");
            entity.Property(e => e.RangoPago).HasColumnName("rango_pago");
            entity.Property(e => e.RangoTest).HasColumnName("rango_test");
            entity.Property(e => e.SaldoOrganizacion)
                .HasColumnType("money")
                .HasColumnName("saldo_organizacion");
            entity.Property(e => e.SaldoPersonal)
                .HasColumnType("money")
                .HasColumnName("saldo_personal");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.UltimoCambio).HasColumnName("ultimo_cambio");
        });

        modelBuilder.Entity<ZTipoInteraccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_tipo_interacciones");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fechainsert).HasColumnName("fechainsert");
            entity.Property(e => e.Fechaupdate).HasColumnName("fechaupdate");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<ZWalletsMala>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("z_wallets_malas");

            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.Criptomoneda).HasColumnName("criptomoneda");
            entity.Property(e => e.FechaAlta).HasColumnName("fecha_alta");
            entity.Property(e => e.FechaBaja).HasColumnName("fecha_baja");
            entity.Property(e => e.FechaInsert).HasColumnName("fecha_insert");
            entity.Property(e => e.FechaUpdate).HasColumnName("fecha_update");
            entity.Property(e => e.FechaValidacion).HasColumnName("fecha_validacion");
            entity.Property(e => e.NumWallet).HasColumnName("num_wallet");
            entity.Property(e => e.Socio).HasColumnName("socio");
            entity.Property(e => e.Validado).HasColumnName("validado");
            entity.Property(e => e.Wallet)
                .HasMaxLength(300)
                .HasColumnName("wallet");
        });

        modelBuilder.Entity<ZonasHoraria>(entity =>
        {
            entity.HasKey(e => e.ZonaHoraria).HasName("pk_zonas_horarias");

            entity.ToTable("zonas_horarias", tb => tb.HasComment("Catálogo de zonas horarias\r\nes un subconjunto de las existentes en la vista de sistema \"pg_timezone_names\"\r\npero está relacionada con países.\r\n\r\nLa columna utc_offset es una copia de la de \"pg_timezones_names\", es sólo para fines de despliegue, no para hacer cálculos... en cuyo caso se debe usar la de la vista."));

            entity.HasIndex(e => e.Pais, "relationship36fk");

            entity.Property(e => e.ZonaHoraria)
                .HasMaxLength(120)
                .HasComment("Nombre canónico de la zona horaria")
                .HasColumnName("zona_horaria");
            entity.Property(e => e.Pais)
                .HasComment("Id del país")
                .HasColumnName("pais");
            entity.Property(e => e.UtcOffset)
                .HasComment("Offset con respecto a UTC")
                .HasColumnName("utc_offset");

            entity.HasOne(d => d.PaisNavigation).WithMany(p => p.ZonasHoraria)
                .HasForeignKey(d => d.Pais)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_zonas_ho_relations_paises");
        });
        modelBuilder.HasSequence<int>("socio_acumulado_nivel_hist_folio_seq");
        modelBuilder.HasSequence<int>("socio_kpi_hist_temp_folio_seq");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
