# ArticleApp 리포지토리

**게시판 프로젝트** 개발 또는 강의 또는 집필 소스 모음


# 게시판 프로젝트

## 1. 게시판 프로젝트 시작

안녕하세요. 박용준입니다. 이번 시간부터는 게시판 프로젝트를 만들어보도록 하겠습니다. 기본적인 기능부터 계속 확장해 나가는 형태로 진행됩니다. 

__게시판__, __VisualStudio__, __닷넷__

- 박용준 강사(https://www.dotnetkorea.com)
- Article: 아티클, 글, 기사
- ArticleApp 솔루션: ArticleApp 프로젝트, ArticleApp.SqlServer 프로젝트, ...
- 3Pro: Professionals(People) -> Projects(Processes) -> Products
- GitHub 공개: https://github.com/VisualAcademy/ArticleApp.git
- 개발 도구: Visual Studio, Visual Studio Code
- 개발 기술: C#, .NET, ASP.NET Core, Blazor, SQL Server, ...
- 개발 제약: 모든 API에 대해서 모두 비동기, 모두 테스트, 모두 SPA(Single Page Application)


## 2. 솔루션 및 프로젝트 생성 그리고 GitHub에 공개

게시판 프로젝트를 진행하기 위해 Visual Studio에서 기본 솔루션을 생성하고 이를 GitHub의 공개 리포지토리에 게시하여 기능을 계속 만들어 나가는 기반을 마련합니다. 

__솔루션__, __프로젝트__, **GitHub** 

- Visual Studio 2019 사용
- ArticleApp 솔루션
  - ArticleApp.Models
  - ArticleApp.Models.Tests
  - ArticleApp.SqlServer 

- GitHub
  - https://github.com/VisualAcademy/ArticleApp.git


## 3. 최소 크기의 모델과 테이블 생성 그리고 로컬 데이터베이스 게시

게시판의 전체 기능을 구현하기 전에 전체 뼈대를 학습을 위한 가장 기초적인 형태의 모델 클래스와 테이블을 생성하고 로컬 데이터베이스에 게시합니다. 

__모델클래스__, __게시판테이블__, __로컬데이터베이스__

- Article.cs 모델 클래스
- Articles.sql 테이블
- ArticleApp 데이터베이스 


## 4. 리포지토리 패턴과 리포지토리 인터페이스

리포지토리 패턴을 사용하여 게시판 데이터에 대한 주요 API를 담당하는 리포지토리 인터페이스를 만들고 기본 메서드에 대한 메서드 시그니처를 생성합니다. 

**Repository**, **리포지토리**, **리포지토리인터페이스**

- Dul.dll 파일 참조
- IArticleRepository.cs
- ArticleRepository.cs (ArticleRepositoryAdoNet, ArticleRepositoryDapper, ArticleRepositoryEfCore, ...)


## 5. Entity Framework Core 참조 및 데이터베이스 컨텍스트 클래스 생성

이번 시간에는 닷넷 스탠다드 프로젝트에 Entity Framework Core 관련 NuGet 패키지를 추가하고 전체 데이터베이스에 접근할 수 있는 부모 클래스인 DbContext 클래스를 생성합니다. 

**NuGet**, **EFCore**, **DbContext**, 

- ArticleDbContext.cs


## 6. 리포지토리 클래스의 주요 비동기 메서드 기능 구현

이번 시간에는 Entity Framework Core를 사용하여 리포지토리 클래스의 주요 비동기 메서드의 기능을 구현합니다.

**리포지토리**, **EF Core**, **CRUD**

- ArticleRepository.cs


## 7. 테스트 프로젝트에서 리포지토리 클래스의 모든 비동기 메서드 테스트

MSTest 프로젝트인 테스트 프로젝트에서 리포지토리 클래스의 모든 메서드를 하나씩 테스트합니다.

__MSTest__, **테스트**, **단위테스트**

- ArticleRepositoryTest.cs


## 8. Blazor 프로젝트 생성 및 게시판 관련 기본 페이지 생성 

현재 강의 시점에서 가장 최신의 웹 개발 기술인 블레이저를 사용하여 웹 페이지 제작을 시작하겠습니다.

__Blazor__, **블레이저**, __웹앱__


## 9. 공통 클래스인 DbContext와 Repository 클래스에 대한 의존성 주입 및 게시판 리스트 페이지 작성 

Models 클래스 라이브러리의 DbContext와 Repository 클래스를 블레이저 프로젝트에 사용 가능하도록 의존성 주입 코드를 작성합니다. 

__DI__, **의존성주입**, __리스트__

