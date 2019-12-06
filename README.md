# ArticleApp
"게시판 프로젝트" 개발 또는 강의 또는 집필 소스 모음

# 게시판 프로젝트

1. 게시판 프로젝트 시작

박용준 강사(https://www.dotnetkorea.com)

Article: 아티클, 글, 기사

ArticleApp 솔루션: ArticleApp 프로젝트, ArticleApp.SqlServer 프로젝트, ...

3Pro: Professionals(People) -> Projects(Processes) -> Products

GitHub 공개: https://github.com/VisualAcademy/ArticleApp.git

개발 도구: Visual Studio, Visual Studio Code

개발 기술: C#, .NET, ASP.NET Core, Blazor, SQL Server, ...

개발 제약: 모든 API에 대해서 모두 비동기, 모두 테스트, 모두 SPA(Single Page Application)

2. 솔루션 및 프로젝트 생성 그리고 GitHub에 공개

Visual Studio 2019 사용

ArticleApp 솔루션
    ArticleApp.Models
    ArticleApp.Models.Tests
    ArticleApp.SqlServer 

GitHub
    https://github.com/VisualAcademy/ArticleApp.git


3. 최소 크기의 모델과 테이블 생성 그리고 로컬 데이터베이스 게시

- Article.cs 모델 클래스
- Articles.sql 테이블
- ArticleApp 데이터베이스 

## 4. 리포지토리 패턴과 리포지토리 인터페이스

- Dul.dll 파일 참조
- IArticleRepository.cs
- ArticleRepository.cs (ArticleRepositoryAdoNet, ArticleRepositoryDapper, ArticleRepositoryEfCore, ...)


## 5. Entity Framework Core 참조 및 데이터베이스 컨텍스트 클래스(ArticleAppDbContext.cs) 생성

- ArticleDbContext.cs

