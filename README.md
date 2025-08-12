## 📅 공부 타임라인 + 키워드

- **2025-08-07**: Closed Sprite Shape, Sprite Shape Profile, Edge Collider 2D
- **2025-08-09**: Cinemachine(2D) – Framing Transposer, Package Manager, Center of Mass 조정, Surface Effector 2D, Collision Detection(2D)
- **2025-08-12**: AddTorque, Angular Drag, SceneManagement.LoadScene(0), CrashDetector.cs, FinishLine.cs, PlayerController.cs

---

## 📌 상세 학습 내용

### Closed Sprite Shape
- 곡선 경로를 따라 스프라이트를 배치하는 기능.
- Closed Shape 활성화 시 시작·끝점 연결, 폐곡선 생성.
- Spline 제어점으로 자유로운 형태 조정 가능.

### Sprite Shape Profile
- 스타일과 구성 방식을 정의하는 에셋.
- Angle Range·Segment Sprite·Corner Sprite·Fill Texture 설정 가능.
- 하나의 Profile로 다양한 지형 스타일 전환.

### Edge Collider 2D
- Sprite Shape에 자동 추가, 경로를 따라 충돌 경계 생성.
- **Geometry Precision**: 세밀도 조정, 성능·품질 균형 필요.
- **Offset**: Sprite와 Collider 위치 보정.

### Cinemachine(2D) – Framing Transposer
- 플레이어를 화면 내 안정적으로 유지.
- Dead/Soft Zone, Damping, Screen X/Y 조절.
- Damping 낮으면 카메라 반응 속도 향상.

### Package Manager
- Unity 패키지 설치·업데이트·제거.
- Cinemachine, 2D Sprite Shape, ProBuilder 등 관리.

### Center of Mass 조정
- Rigidbody2D 무게중심은 자식 Collider 배치로 변경 가능.
- centerOfMass를 직접 변경 시 자동 계산 중단됨.

### Surface Effector 2D
- Collider 표면을 따라 접선 방향 속도 부여.
- Force Scale·Use Contact Force로 물리 효과 조정.

### Collision Detection(2D)
- Discrete/Continuous/Speculative 모드 선택.
- 빠른 오브젝트는 Continuous 이상 사용.

### AddTorque & Angular Drag
- AddTorque: 회전력 부여.
- Angular Drag: 회전 감속 속도 제어.

### SceneManagement.LoadScene(0)
- 0번 빌드 인덱스 씬 로드, 주로 재시작에 사용.

---

## 🛠 작업 현황
1. Sprite Shape 생성 및 지형 제작
2. Edge Collider 2D 조정
3. Cinemachine 2D 카메라 적용
4. Rigidbody2D 무게중심 조정
5. Surface Effector 2D 설정
6. Collision Detection 최적화
7. AddTorque & Angular Drag 적용
8. 씬 로드 기능 추가 (0번 씬)

---

## 📝 메모
- Collider Detail은 성능·품질 균형 고려.
- Cinemachine 설정으로 플레이어 시야 안정성 확보.
- 무게중심은 자식 Collider 활용 시 직관적.
- AddTorque·Angular Drag로 회전 제어.
- SceneManagement.LoadScene 빌드 인덱스 주의.
