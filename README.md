# BackpackHeroCopy

2023-02-13
백팩 히어로 개발 시작

tag v0.0.1
프로젝트 생성

tag v0.0.2
타이틀씬 : 게임시작버튼 구현
인게임씬 : 지도와 인벤토리 이동하는 버튼 구현

Title 씬
World Space 캔버스를 사용할경우 캔버스가 매우 크게 잡히므로 내부 오브젝트들을 관리할 Empty Objects를 만들고
스케일을 pixel per Unit만큼 스케일을 줄인 뒤 그 하위에서 관리했다.

버튼 부모 오브젝트에서 Vertical Layout Group컴포넌트를 사용하여 전체크기를 정하고 N등분을 했다.