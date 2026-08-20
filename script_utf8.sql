USE [master]
GO
/****** Object:  Database [DB_RMD_Sambu]    Script Date: 20/08/2026 11:31:06 ******/
CREATE DATABASE [DB_RMD_Sambu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_RMD_Sambu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_RMD_Sambu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_RMD_Sambu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_RMD_Sambu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_RMD_Sambu] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_RMD_Sambu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_RMD_Sambu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_RMD_Sambu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_RMD_Sambu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_RMD_Sambu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_RMD_Sambu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_RMD_Sambu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_RMD_Sambu] SET  MULTI_USER 
GO
ALTER DATABASE [DB_RMD_Sambu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_RMD_Sambu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_RMD_Sambu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_RMD_Sambu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_RMD_Sambu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_RMD_Sambu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_RMD_Sambu] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_RMD_Sambu] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_RMD_Sambu]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 20/08/2026 11:31:06 ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[InboundQC]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InboundQC](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticket_id] [int] NULL,
	[grade_id] [int] NULL,
	[qty] [decimal](10, 2) NOT NULL,
	[notes] [varchar](255) NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InboundTickets]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InboundTickets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticket_no] [varchar](50) NOT NULL,
	[supplier_id] [int] NULL,
	[truck_plate] [varchar](20) NULL,
	[weight_bruto] [decimal](10, 2) NULL,
	[weight_tara] [decimal](10, 2) NULL,
	[weight_netto] [decimal](10, 2) NULL,
	[status] [varchar](20) NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ticket_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[grade_id] [int] NOT NULL,
	[current_stock] [decimal](10, 2) NULL,
	[last_updated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[grade_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialGrades]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialGrades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[material_id] [int] NULL,
	[grade_name] [varchar](50) NOT NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[material_code] [varchar](20) NOT NULL,
	[material_name] [varchar](100) NOT NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[material_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[migrations]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[migrations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[migration] [nvarchar](255) NOT NULL,
	[batch] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OutboundIssueDetails]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutboundIssueDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[issue_id] [int] NULL,
	[grade_id] [int] NULL,
	[qty] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OutboundIssues]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutboundIssues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[issue_no] [varchar](50) NOT NULL,
	[shift] [varchar](10) NULL,
	[destination] [varchar](100) NULL,
	[total_qty] [decimal](10, 2) NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[issue_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [varchar](50) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockLedger]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockLedger](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transaction_date] [datetime] NULL,
	[grade_id] [int] NULL,
	[transaction_type] [varchar](10) NULL,
	[qty] [decimal](10, 2) NOT NULL,
	[reference_no] [varchar](50) NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supplier_code] [varchar](20) NOT NULL,
	[supplier_name] [varchar](100) NOT NULL,
	[phone] [varchar](20) NULL,
	[address] [text] NULL,
	[is_active] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[supplier_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NULL,
	[username] [varchar](50) NOT NULL,
	[password_hash] [varchar](255) NOT NULL,
	[full_name] [varchar](100) NOT NULL,
	[is_active] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InboundQC] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[InboundTickets] ADD  DEFAULT ((0)) FOR [weight_bruto]
GO
ALTER TABLE [dbo].[InboundTickets] ADD  DEFAULT ((0)) FOR [weight_tara]
GO
ALTER TABLE [dbo].[InboundTickets] ADD  DEFAULT ((0)) FOR [weight_netto]
GO
ALTER TABLE [dbo].[InboundTickets] ADD  DEFAULT ('PENDING') FOR [status]
GO
ALTER TABLE [dbo].[InboundTickets] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[InboundTickets] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT ((0)) FOR [current_stock]
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT (getdate()) FOR [last_updated]
GO
ALTER TABLE [dbo].[MaterialGrades] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Materials] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[OutboundIssues] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[StockLedger] ADD  DEFAULT (getdate()) FOR [transaction_date]
GO
ALTER TABLE [dbo].[StockLedger] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Suppliers] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[Suppliers] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Suppliers] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[InboundQC]  WITH CHECK ADD FOREIGN KEY([grade_id])
REFERENCES [dbo].[MaterialGrades] ([id])
GO
ALTER TABLE [dbo].[InboundQC]  WITH CHECK ADD FOREIGN KEY([ticket_id])
REFERENCES [dbo].[InboundTickets] ([id])
GO
ALTER TABLE [dbo].[InboundTickets]  WITH CHECK ADD FOREIGN KEY([created_by])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[InboundTickets]  WITH CHECK ADD FOREIGN KEY([supplier_id])
REFERENCES [dbo].[Suppliers] ([id])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([grade_id])
REFERENCES [dbo].[MaterialGrades] ([id])
GO
ALTER TABLE [dbo].[MaterialGrades]  WITH CHECK ADD FOREIGN KEY([material_id])
REFERENCES [dbo].[Materials] ([id])
GO
ALTER TABLE [dbo].[OutboundIssueDetails]  WITH CHECK ADD FOREIGN KEY([grade_id])
REFERENCES [dbo].[MaterialGrades] ([id])
GO
ALTER TABLE [dbo].[OutboundIssueDetails]  WITH CHECK ADD FOREIGN KEY([issue_id])
REFERENCES [dbo].[OutboundIssues] ([id])
GO
ALTER TABLE [dbo].[OutboundIssues]  WITH CHECK ADD FOREIGN KEY([created_by])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[StockLedger]  WITH CHECK ADD FOREIGN KEY([grade_id])
REFERENCES [dbo].[MaterialGrades] ([id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
/****** Object:  StoredProcedure [dbo].[sp_IssueToProduction]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =========================================
-- SP 2: Issue to Production (Kurangi Stok)
-- (Dipanggil saat kelapa diserahkan ke pabrik)
-- =========================================
CREATE PROCEDURE [dbo].[sp_IssueToProduction]
    @issue_no VARCHAR(50),
    @shift VARCHAR(10),
    @destination VARCHAR(100),
    @created_by INT,
    @grade_id INT,
    @qty DECIMAL(10,2)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Cek apakah stok cukup
        DECLARE @CurrentStock DECIMAL(10,2);
        SELECT @CurrentStock = current_stock FROM Inventory WHERE grade_id = @grade_id;

        IF (@CurrentStock IS NULL OR @CurrentStock < @qty)
        BEGIN
            RAISERROR ('Stok tidak mencukupi untuk dikeluarkan!', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 1. Buat Header Transaksi Keluar
        DECLARE @issue_id INT;
        INSERT INTO OutboundIssues (issue_no, shift, destination, total_qty, created_by)
        VALUES (@issue_no, @shift, @destination, @qty, @created_by);
        SET @issue_id = SCOPE_IDENTITY();

        -- 2. Buat Detail Transaksi Keluar
        INSERT INTO OutboundIssueDetails (issue_id, grade_id, qty)
        VALUES (@issue_id, @grade_id, @qty);

        -- 3. Kurangi stok dari Inventory
        UPDATE Inventory SET current_stock = current_stock - @qty, last_updated = GETDATE() WHERE grade_id = @grade_id;

        -- 4. Catat di Buku Besar Stok
        INSERT INTO StockLedger (grade_id, transaction_type, qty, reference_no)
        VALUES (@grade_id, 'OUT', @qty, @issue_no);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportDailyInbound]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReportDailyInbound]
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT 
        t.ticket_no AS TicketNo,
        t.created_at AS DateIn,
        s.supplier_name AS SupplierName,
        t.truck_plate AS TruckPlate,
        t.weight_bruto AS WeightBruto,
        t.weight_tara AS WeightTara,
        t.weight_netto AS WeightNetto,
        t.status AS Status
    FROM InboundTickets t
    JOIN Suppliers s ON t.supplier_id = s.id
    WHERE t.created_at >= @StartDate AND t.created_at <= @EndDate
    ORDER BY t.created_at DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SubmitQC]    Script Date: 20/08/2026 11:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =========================================
-- SP 1: Eksekusi QC Masuk & Tambah Stok
-- (Dipanggil setelah tim sortir selesai mengecek kelapa)
-- =========================================
CREATE PROCEDURE [dbo].[sp_SubmitQC]
    @ticket_id INT,
    @grade_id INT,
    @qty DECIMAL(10,2),
    @notes VARCHAR(255)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Simpan data hasil QC
        INSERT INTO InboundQC (ticket_id, grade_id, qty, notes)
        VALUES (@ticket_id, @grade_id, @qty, @notes);

        -- 2. Update status tiket jadi QC_DONE (opsional, bisa di-trigger dari backend nanti)
        UPDATE InboundTickets SET status = 'QC_DONE', updated_at = GETDATE() WHERE id = @ticket_id;

        -- 3. Tambah atau Update Master Stok di tabel Inventory
        IF EXISTS(SELECT 1 FROM Inventory WHERE grade_id = @grade_id)
            UPDATE Inventory SET current_stock = current_stock + @qty, last_updated = GETDATE() WHERE grade_id = @grade_id;
        ELSE
            INSERT INTO Inventory (grade_id, current_stock) VALUES (@grade_id, @qty);

        -- 4. Catat riwayat pergerakan barang (Buku Besar Stok / Stock Ledger)
        DECLARE @ticket_no VARCHAR(50);
        SELECT @ticket_no = ticket_no FROM InboundTickets WHERE id = @ticket_id;
        
        INSERT INTO StockLedger (grade_id, transaction_type, qty, reference_no)
        VALUES (@grade_id, 'IN', @qty, @ticket_no);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
USE [master]
GO
ALTER DATABASE [DB_RMD_Sambu] SET  READ_WRITE 
GO
