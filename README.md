# BackpackHeroCopy

2023-02-13
백팩 히어로 개발 시작

tag v0.0.1
프로젝트 생성

2023-02-13
tag v0.0.2
타이틀씬 : 게임시작버튼 구현
인게임씬 : 지도와 인벤토리 이동하는 버튼 구현

Title 씬
World Space 캔버스를 사용할경우 캔버스가 매우 크게 잡히므로 내부 오브젝트들을 관리할 Empty Objects를 만들고
스케일을 pixel per Unit만큼 스케일을 줄인 뒤 그 하위에서 관리했다.

버튼 부모 오브젝트에서 Vertical Layout Group컴포넌트를 사용하여 전체크기를 정하고 N등분을 했다.

2023-02-14
tag v0.0.3
인게임씬 : 인벤토리 구현중 (인벤토리 확장 기능 구현도중 크기가 좌우로 커지는 로직에서 막힘)
-> 2023-02-15 해결
해결 방법 : 계층 구조를 나눔 원래는 BackPack밑에 NowPockets가 이미지도 들고 있어서 이미지의 좌표를 변경할 경우 하위 오브젝트들도 위치가
변경됨. 따라서 가방의 백그라운드 이미지와 프론트 이미지를 더 추가함

2023-02-15
tag v0.0.4
인게임씬 : 인벤토리 확장 기능(레벨업) 완료 아이템을 드래그앤 드랍으로 가장 가까운 위치의 활성화된 인벤토리 칸으로 갔을 때 그 위치에
아이템 잔상 표시 및 나갔을 시 잔상 사라짐

-> 다음시간에 할 것 아이템의 차지 칸 수를 배열로 저장한 뒤 가장 가까운 위치의 활성화된 인벤토리 칸 주위의 3X3 배열을 받아와서
아이템 차지 칸 수를 비교하는 로직 생각 (아이템 인벤토리에 배치)
2023-02-17
tag v0.1.0
인게임씬 : 인벤토리안에 아이템 넣기 구현
어려웠던 점 :
아이템을 3X3형태의 배열로 저장했었는데 회전을 시킬때마다 배열도 같이 회전되어서 회전수에 따라 인벤토리의 [Y,X]탐색순서를 바꿔줌
2X2의 아이템이 3X3의 크기로 맞추다보니 오차가 발생해서 오차값을 수정해야되는데 포지션을 더할때 Ui의 pixel per unit이 100이여서
바꿔줄경우 좌표가 이상한 곳으로 튀었음(1/100을 곱해서 오차범위를 수정함)

2023-02-21
인게임씬 : 적 구현 (스크립터블 오브젝트 R&D)

2023-11-06
사용안한 에셋 삭제