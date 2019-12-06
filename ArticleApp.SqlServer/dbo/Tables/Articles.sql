-- 게시판 테이블
CREATE TABLE [dbo].[Articles]
(
	[Id] Int Not Null Primary Key Identity(1, 1),	-- 일련번호
	[Title] NVarChar(255) Not Null,					-- 제목
)
Go
