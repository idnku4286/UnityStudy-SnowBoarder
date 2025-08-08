## 공부 내용

### 2025-08-07
- Closed Sprite Shape
- Sprite Shape Profile
- Edge Collider 2D

### 2025-08-09
- Cinemachine(2D) – Framing Transposer로 카메라 이동
- Package Manager 사용
- Center of Mass(무게중심) 조정 – 자식 콜라이더 배치
- Surface Effector 2D
- Collision Detection(2D)

---

### Closed Sprite Shape
- Sprite Shape는 곡선 경로를 따라 스프라이트를 배치하는 Unity 2D 기능이다.
- Closed Shape 옵션을 활성화하면 시작점과 끝점이 연결되어 폐곡선 형태가 된다.
- 섬, 연못, 울타리, 벽 같은 닫힌 지형을 만들 때 유용하다.
- Spline의 제어점(Control Point)을 추가·이동·삭제하여 지형의 형태를 자유롭게 조절할 수 있다.

### Sprite Shape Profile
- Sprite Shape의 스타일과 구성 방식을 정의하는 에셋 파일이다.
- 주요 구성 요소:
  - Angle Range: 각도 범위에 따라 사용할 스프라이트 지정
  - Segment Sprite: 일반 구간에서 반복적으로 배치될 스프라이트
  - Corner Sprite: 꺾이는 구간에서 사용할 스프라이트
  - Fill Texture: Closed Shape일 때 내부를 채우는 텍스처
- 하나의 Profile로 다양한 지형 스타일을 빠르게 전환할 수 있어 재사용성이 높다.

---

### Edge Collider 2D + 충돌 감지 범위 조정

- Sprite Shape에는 자동으로 Edge Collider 2D가 추가되어, Spline 경로를 따라 충돌 경계가 생성된다.
- 이 콜라이더는 실제 물리 엔진에서 충돌 판정을 담당한다.

#### Geometry Precision
- Sprite Shape Controller의 Geometry > Collider Detail 값을 조절하면 곡선 경로의 세밀도를 변경할 수 있다.
- 이 값이 클수록 경로가 더 촘촘한 선분으로 분할되어 곡선이 부드럽게 표현된다.
- 시각적으로는 좋아지지만, 세그먼트 수가 많아져 렌더링과 충돌 계산의 성능 부담이 증가할 수 있다.

#### Edge Collider 2D Offset
- Offset 속성은 콜라이더 전체를 로컬 좌표 기준으로 평행 이동시킨다.
- 시각적 Sprite와 실제 충돌 위치가 어긋나는 경우, Offset을 조절해 충돌 범위를 정확하게 맞출 수 있다.
- 예: Offset의 Y값을 조절하면 지형 위를 걷는 캐릭터의 발이 떠보이거나 박히는 현상을 보정할 수 있다.

---

### Cinemachine(2D) – Framing Transposer로 카메라 이동
- 개요: 플레이어를 화면 내 지정 영역에 안정적으로 유지하는 카메라 바디 알고리즘.
- 설정 절차:
  1. Window > Package Manager에서 Cinemachine 설치
  2. GameObject > Cinemachine > Create 2D Camera 생성
  3. Virtual Camera의 Body를 Framing Transposer로 설정
  4. Follow에 플레이어 오브젝트 지정
  5. Screen X/Y, Dead Zone, Soft Zone, Damping 값 조절로 원하는 카메라 움직임 구현
- 팁:
  - Damping 값을 낮추면 카메라 반응 속도가 빨라짐.
  - Screen X/Y로 화면 내 플레이어 위치를 중앙이 아닌 특정 위치로 유지 가능.

### Package Manager 사용
- 개요: Unity의 패키지 설치, 업데이트, 제거를 관리하는 기능.
- 위치: Window > Package Manager
- 활용 예시: Cinemachine, 2D Sprite Shape, ProBuilder 등 필요한 기능을 추가 설치 가능.

### Center of Mass(무게중심) 조정 – 자식 콜라이더 배치
- 원리: Rigidbody2D는 부모와 자식의 Collider2D 정보를 종합해 질량분포와 무게중심(center of mass)을 자동 계산.
- 방법: 자식 오브젝트의 위치, 콜라이더 크기, 밀도를 변경해 무게중심 위치 조정 가능.
- 주의:
  - Rigidbody2D.centerOfMass를 스크립트로 직접 변경하면 자동 계산이 중단됨.
  - 물리 정확도를 위해 콜라이더의 스케일 왜곡은 피하는 것이 좋음.

### Surface Effector 2D
- 개요: Effector가 붙은 Collider 표면을 따라 접선 방향으로 속도를 부여하는 2D 물리 컴포넌트.
- 활용 예시: 컨베이어 벨트, 얼음판, 움직이는 바닥
- 설정 절차:
  1. Collider2D에 Used by Effector 체크
  2. Surface Effector 2D 추가
  3. Speed(목표 속도), Speed Variation, Use Friction, Use Bounce 설정
- Force Scale:
  - Effector가 목표 속도를 만들기 위해 가하는 힘의 배율.
  - 0~1 범위에서 조정, 너무 크면 비자연스러운 움직임 발생.
  - Use Contact Force 활성화 시 접촉 지점에서만 힘이 적용됨.

### Collision Detection(2D)
- 옵션:
  - Discrete: 기본값, 저속 오브젝트에 적합
  - Continuous: 고속 이동체가 얇은 물체를 통과하는 문제 방지
  - Continuous Speculative: 고속 + 예측 기반 처리
- 활용 가이드:
  - 플레이어, 느린 오브젝트: Discrete
  - 총알, 빠른 대시, 얇은 플랫폼: Continuous 또는 Continuous Speculative
- 주의: 연속 충돌 모드는 성능 부담이 커서 필요한 오브젝트에만 사용.

---

### 작업 요약
1. 2D Object > Sprite Shape 생성
2. Sprite Shape Controller에서 Profile 연결
3. Spline의 제어점을 편집하여 지형 생성
4. Closed Shape 옵션 활성화
5. 자동 생성된 Edge Collider 2D 확인 및 Offset, Geometry Precision 조절
6. Package Manager에서 Cinemachine 설치 후 2D Camera 생성
7. Body=Framing Transposer로 설정, Follow에 플레이어 지정
8. Dead/Soft Zone, Damping, Screen X/Y 값 조정
9. Rigidbody2D 무게중심 조정 시 자식 Collider 배치 활용
10. Surface Effector 2D로 표면 이동 효과 구현, Force Scale 및 Use Contact Force 조정
11. 고속 오브젝트에 적합한 Collision Detection 모드 선택

---

### 메모
- Geometry Precision(또는 Collider Detail)은 충돌 경계 세밀도를 결정하므로 성능과 품질을 균형 있게 조절해야 함.
- Offset은 콜라이더와 시각 스프라이트의 불일치를 보정하는 핵심 수단.
- Cinemachine의 Damping과 Dead Zone은 카메라의 반응성과 부드러움을 좌우하므로 세밀하게 튜닝 필요.
- Rigidbody2D의 무게중심은 자식 콜라이더 배치로 직관적으로 조정 가능.
- Surface Effector 2D의 Force Scale은 너무 크면 물리 동작이 비자연스러워질 수 있음.
- 연속 충돌 모드는 필요한 오브젝트에만 적용해 성능 부담 최소화.
