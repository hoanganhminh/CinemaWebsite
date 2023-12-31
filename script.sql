USE [master]
GO
/****** Object:  Database [MovieDB]    Script Date: 9/3/2023 10:55:04 PM ******/
CREATE DATABASE [MovieDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MovieDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovieDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MovieDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MovieDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MovieDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MovieDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieDB] SET  MULTI_USER 
GO
ALTER DATABASE [MovieDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MovieDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MovieDB] SET QUERY_STORE = OFF
GO
USE [MovieDB]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 9/3/2023 10:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 9/3/2023 10:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](200) NULL,
	[Gender] [nchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](100) NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 9/3/2023 10:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Year] [date] NULL,
	[GenreId] [int] NULL,
	[Image] [varchar](max) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rates]    Script Date: 9/3/2023 10:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rates](
	[MovieID] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[Rating] [float] NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC,
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreId], [Description]) VALUES (1, N'Hành động')
INSERT [dbo].[Genres] ([GenreId], [Description]) VALUES (2, N'Kinh dị')
INSERT [dbo].[Genres] ([GenreId], [Description]) VALUES (3, N'Khoa học viễn tưởng')
INSERT [dbo].[Genres] ([GenreId], [Description]) VALUES (4, N'Tình cảm')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([MemberId], [Fullname], [Gender], [Email], [Password], [Type]) VALUES (1, N'Hoàng Anh Minh', N'male      ', N'vipchackute@gmail.com', N'MTIz', 4)
INSERT [dbo].[Members] ([MemberId], [Fullname], [Gender], [Email], [Password], [Type]) VALUES (2, N'test user', N'male      ', N'a@gmail.com', N'MTIz', 0)
INSERT [dbo].[Members] ([MemberId], [Fullname], [Gender], [Email], [Password], [Type]) VALUES (3, N'test user 2', N'female    ', N'b@gmail.com', N'MTIz', 0)
INSERT [dbo].[Members] ([MemberId], [Fullname], [Gender], [Email], [Password], [Type]) VALUES (4, N'admin', N'male      ', N'admin', N'MTIz', 1)
INSERT [dbo].[Members] ([MemberId], [Fullname], [Gender], [Email], [Password], [Type]) VALUES (5, N'test user 3', N'male      ', N'test3', N'MTIz', 2)
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (1, N'PHI CÔNG SIÊU ĐẲNG MAVERICK', CAST(N'2022-05-27' AS Date), 1, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/t/o/top_gun_maverick_-_poster_28.03_1__2.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (2, N'XÁC SỐNG 32s', CAST(N'2022-07-08' AS Date), 2, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/v/i/virus_32_poster_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (3, N'CUỘC CHIẾN ĐA VŨ TRỤ', CAST(N'2022-06-24' AS Date), 3, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/c/u/cu_c_chi_n_a_v_tr_-_payoff_poster_-_k_ch_th_c_fb_-_dkkc_24062022_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (4, N'THẾ GIỚI KHỦNG LONG: LÃNH ĐỊA', CAST(N'2022-06-10' AS Date), 1, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/r/s/rsz_jurassic_world_dominion_-10062022_2.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (5, N'EM VÀ TRỊNH', CAST(N'2022-06-17' AS Date), 4, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/e/v/evt_drawing_poster_70x100cm_200dpi_rgb.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (6, N'SÁT THỦ NHÂN TẠO 2: MẪU VẬT CÒN LẠI', CAST(N'2022-07-01' AS Date), 1, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/s/t/stnt2_social_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (7, N'ĐIỆN THOẠI ĐEN', CAST(N'2022-06-24' AS Date), 2, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/_/i/_i_n_tho_i_en_-_24.06.2022_2.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (8, N'THOÁT KHỎI MOGADISHU', CAST(N'2022-07-15' AS Date), 1, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/m/a/main_poster_tho_t_kh_i_mogadishu_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (9, N'KAREM: VẬT CHỨA TỬ THẦN', CAST(N'2022-07-15' AS Date), 2, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/p/o/poster_700_x_1000_px_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (10, N'PORORO: CUỘC PHIÊU LƯU ĐẾN ĐẢO KHỦNG LONG', CAST(N'2022-07-15' AS Date), 5, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/p/o/pororo_dinosaur_island_adventure-_vietnamese_poster_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (11, N'CHERRY MAGIC: 30 TUỔI VẪN CÒN “ZIN” SẼ BIẾN THÀNH PHÙ THỦY', CAST(N'2022-07-15' AS Date), 4, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/c/h/cherry_magic-_vietnamese_poster-1.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (12, N'QUYẾT TÂM CHIA TAY', CAST(N'2022-07-15' AS Date), 4, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/d/t/dtl_m-poster_w700xh1000_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (13, N'MINIONS: SỰ TRỖI DẬY CỦA GRU', CAST(N'2022-07-01' AS Date), 5, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/m/i/minions_2_-_kc_01.7.22_1__1.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (14, N'THOR: TÌNH YÊU VÀ SẤM SÉT', CAST(N'2022-07-08' AS Date), 1, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/t/h/thor-main-poster_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (1002, N'THÁM TỬ LỪNG DANH CONAN: NÀNG DÂU HALLOWEEN', CAST(N'2022-07-25' AS Date), 5, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/c/o/conan_movie_2022-_vnese_poster_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (1003, N'LINH HỒN VŨ NỮ', CAST(N'2022-07-28' AS Date), 2, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/l/i/linh_h_n_v_n_-_payoff_poster_k_ch_th_c_facebook_-_kc_22.07.2022_1_.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (1004, N'CHUYỆN MA GIẢNG ĐƯỜNG – HỌC KỲ 2', CAST(N'2022-07-29' AS Date), 2, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/p/o/poster_700_x_1000_px.jpg')
INSERT [dbo].[Movies] ([MovieId], [Title], [Year], [GenreId], [Image]) VALUES (1005, N'LIÊN MINH SIÊU THÚ DC', CAST(N'2022-07-29' AS Date), 5, N'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/p/o/poster_lmst_3_no_qr_code_1_.jpg')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (1, 1, N'phim hay quaa', 3.5, CAST(N'2022-07-23T10:27:05.673' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (2, 2, N'so the hjx', 4, CAST(N'2022-07-19T21:28:19.797' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (2, 3, N'4 sao ', 4, CAST(N'2022-07-21T16:28:20.827' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (3, 2, N'toi thay cung duoc', 5, CAST(N'2022-07-20T00:30:14.173' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (3, 3, N'he hehehehehe chán chả có cgi', 3.5, CAST(N'2022-07-20T09:14:41.700' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (4, 1, N'phim hay vaiiii', 5, CAST(N'2022-07-19T21:33:59.593' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (4, 3, N'chán quá phim nhu cái quần', 4.5, CAST(N'2022-07-20T09:15:34.737' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (5, 3, N'phim fuckboiz', 4, CAST(N'2022-07-20T09:14:18.970' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (6, 1, N'bth', 4.5, CAST(N'2022-07-21T08:34:27.907' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (6, 3, N'hay', 5, CAST(N'2022-07-20T09:15:56.030' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (7, 1, N'so qua di', 5, CAST(N'2022-07-22T09:01:30.097' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (7, 3, N'chịu rồi ', 4.5, CAST(N'2022-07-20T09:16:12.717' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (8, 1, N'chan', 2.5, CAST(N'2022-07-23T10:01:26.017' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (8, 3, N'hú hú hay waaaaaa', 4, CAST(N'2022-07-20T09:16:37.803' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (9, 2, N'hihihi', 4, CAST(N'2022-07-23T08:07:25.513' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (10, 1, N'phim bifnh thuong', 3, CAST(N'2022-07-20T09:22:51.520' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (11, 1, N'ohhhh', 4.5, CAST(N'2022-07-23T09:14:33.973' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (12, 3, N'chia tay luôn đi khỏi xem phim', 1, CAST(N'2022-07-20T09:18:08.893' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (13, 3, N'uồi phim cute lắmmm', 5, CAST(N'2022-07-20T09:17:16.273' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (14, 1, N'hayyyyy', 5, CAST(N'2022-07-21T16:18:40.630' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [MemberId], [Comment], [Rating], [Time]) VALUES (14, 3, N'đỉnh của chóp', 4.5, CAST(N'2022-07-20T09:14:00.020' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [MovieDB] SET  READ_WRITE 
GO
