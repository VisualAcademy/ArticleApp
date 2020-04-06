# ArticleApp 리포지토리

**게시판 프로젝트** 개발 또는 강의 또는 집필 소스 모음


# 게시판 프로젝트

## 001. 게시판 프로젝트 시작

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


## 002. 솔루션 및 프로젝트 생성 그리고 GitHub에 공개

게시판 프로젝트를 진행하기 위해 Visual Studio에서 기본 솔루션을 생성하고 이를 GitHub의 공개 리포지토리에 게시하여 기능을 계속 만들어 나가는 기반을 마련합니다. 

__솔루션__, __프로젝트__, **GitHub** 

- Visual Studio 2019 사용
- ArticleApp 솔루션
  - ArticleApp.Models
  - ArticleApp.Models.Tests
  - ArticleApp.SqlServer 

- GitHub
  - https://github.com/VisualAcademy/ArticleApp.git


## 003. 최소 크기의 모델과 테이블 생성 그리고 로컬 데이터베이스 게시

게시판의 전체 기능을 구현하기 전에 전체 뼈대를 학습을 위한 가장 기초적인 형태의 모델 클래스와 테이블을 생성하고 로컬 데이터베이스에 게시합니다. 

__모델클래스__, __게시판테이블__, __로컬데이터베이스__

- Article.cs 모델 클래스
- Articles.sql 테이블
- ArticleApp 데이터베이스 


## 004. 리포지토리 패턴과 리포지토리 인터페이스

리포지토리 패턴을 사용하여 게시판 데이터에 대한 주요 API를 담당하는 리포지토리 인터페이스를 만들고 기본 메서드에 대한 메서드 시그니처를 생성합니다. 

**Repository**, **리포지토리**, **리포지토리인터페이스**

- Dul.dll 파일 참조
- IArticleRepository.cs
- ArticleRepository.cs (ArticleRepositoryAdoNet, ArticleRepositoryDapper, ArticleRepositoryEfCore, ...)


## 005. Entity Framework Core 참조 및 데이터베이스 컨텍스트 클래스 생성

이번 시간에는 닷넷 스탠다드 프로젝트에 Entity Framework Core 관련 NuGet 패키지를 추가하고 전체 데이터베이스에 접근할 수 있는 부모 클래스인 DbContext 클래스를 생성합니다. 

**NuGet**, **EFCore**, **DbContext**, 

- ArticleDbContext.cs


## 006. 리포지토리 클래스의 주요 비동기 메서드 기능 구현

이번 시간에는 Entity Framework Core를 사용하여 리포지토리 클래스의 주요 비동기 메서드의 기능을 구현합니다.

**리포지토리**, **EF Core**, **CRUD**

- ArticleRepository.cs


## 007. 테스트 프로젝트에서 리포지토리 클래스의 모든 비동기 메서드 테스트

MSTest 프로젝트인 테스트 프로젝트에서 리포지토리 클래스의 모든 메서드를 하나씩 테스트합니다.

__MSTest__, **테스트**, **단위테스트**

- ArticleRepositoryTest.cs


## 008. Blazor 프로젝트 생성 및 게시판 관련 기본 페이지 생성 

현재 강의 시점에서 가장 최신의 웹 개발 기술인 블레이저를 사용하여 웹 페이지 제작을 시작하겠습니다.

__Blazor__, **블레이저**, __웹앱__


## 009. 공통 클래스인 DbContext와 Repository 클래스에 대한 의존성 주입 관련 코드를 Startup 파일에 추가

Models 클래스 라이브러리의 DbContext와 Repository 클래스를 블레이저 프로젝트에 사용 가능하도록 의존성 주입 코드를 작성합니다. 

__DI__, **의존성주입**, __Startup__


## 010. 게시판 리스트 페이지 작성 

게시판에서 제일 먼저 접근하는 메인 페이지인 리스트 페이지를 꾸며보도록 하겠습니다. 

 __리스트__, **Index**, __메인페이지__
 
 
 ## 011. 게시판 글쓰기 페이지 작성
 
 게시판에 데이터를 입력하는 글쓰기 페이지를 부트스트랩을 사용하여 폼을 만들고 데이터를 입력하는 코드를 작성합니다.
 
 **글쓰기**, **부트스트랩**, **폼**
 
 
 ## 012. 게시판 상세보기 페이지 작성
 
 게시판에 작성된 데이터에 대한 상세 내용을 볼 수 있는 상세보기 페이지를 작성합니다. 
 
 **상세**, **게시판**, **Details**
 
 
 ## 013. 게시판 수정 페이지 작성 및 Content 열 추가 후 관련 코드 수정
  
 게시판에 작성된 데이터를 수정할 수 있는 페이지를 작성합니다. 
 
 **수정**, **게시판**, **Edit**


 ## 014. 게시판 삭제 페이지 작성 및 확인 관련 기능을 IJSRuntime으로 구현
  
게시판에 작성된 데이터를 삭제할 수 있는 페이지를 작성합니다. C#에서 JavaScript의 함수를 호출하는 방법을 다룹니다.
 
 **삭제**, **게시판**, **Delete**
 

 ## 015. 게시판 리스트에 페이저 컴포넌트 적용 및 기본 페이징 구현
  
게시판의 리스트에 적용되어 사용되는 페이저 컴포넌트의 기능을 리스트 페이지에 적용합니다.  
 
 **Pager**, **페이징**, **페이저**
 

 ## 016. 페이저 컴포넌트 UI 만들기 
  
게시판의 리스트에 적용되어 사용되는 페이저 컴포넌트의 UI 기능을 작성합니다.  
 
 **Pager**, **페이징**, **페이저**


 ## 017. IsPinned 속성 추가 및 공지글로 설정하는 기능을 모달 폼으로 구현하기
  
새로운 열과 속성을 추가하고 순수 C# 코드를 사용하여 모달 폼을 띄우거나 닫는 기능을 구현합니다.  
 
 **Modal**, **공지설정**, **모달폼**
 
 
 ## 018. 부트스트랩 모달 폼을 사용하여 관리자 전용 데이터 삭제 모달 다이얼로그 구현 
  
부트스트랩 모달 폼과 jQuery를 연동하여 관리자 전용 데이터 삭제 모달 다이얼로그를 구현하는 방법을 보여줍니다. 
 
 **Modal**, **삭제폼**, **모달폼**
 
  
 ## 019. 부트스트랩 모달 폼을 사용하여 관리자 전용 데이터 입력 및 수정 모달 폼 구현 
  
부트스트랩 모달 폼과 jQuery를 연동하여 관리자 전용 데이터 입력 및 수정 모달 다이얼로그를 구현하는 방법을 보여줍니다. 
 
 **Modal**, **수정폼**, **모달폼**
 
 
 ## 020. 상세보기 내용의 줄바꿈 등을 추가 및 게시판의 UI를 개선하기
  
마스터 브랜치가 아닌 새로운 브랜치에서 게시판의 UI를 개선하는 작업을 진행하고 테스트가 완료되면 마스터 브랜치로 병합하면서 개발을 진행합니다.
 
 **마스터**, **브랜치**, **병합**
 
 
 ## 021. 21_인라인 코드 방식을 코드 비하인드 방식으로 변경
  
 게시판에 작성된 데이터를 삭제할 수 있는 페이지를 작성합니다. 
 
 **삭제**, **게시판**, **Delete**
 
 
 ## 022. 페이저 컴포넌트를 Razor 클래스 라이브러리로 만들어 NuGet 갤러리에 공개
  
 게시판에서 사용되는 페이저 컴포넌트를 NuGet 갤러리에 공개합니다. 
  
 **NuGet**, **Pager**, **DulPager**


 ## 023. 페이저 컴포넌트를 NuGet 갤러리의 DulPager로 대체
  
NuGet 갤러리에 공개된 DulPager 컴포넌트를 사용합니다. 
  
 **NuGet**, **Pager**, **DulPager**
 
