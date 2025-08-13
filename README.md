## 📅 공부 타임라인 + 키워드

- **2025-08-07**: Closed Sprite Shape, Sprite Shape Profile, Edge Collider 2D
- **2025-08-09**: Cinemachine(2D) – Framing Transposer, Package Manager, Center of Mass 조정, Surface Effector 2D, Collision Detection(2D)
- **2025-08-12**: AddTorque, Angular Drag, SceneManagement.LoadScene(0), CrashDetector.cs, FinishLine.cs, PlayerController.cs
- **2025-08-14**: Invoke Delay, Particle System(Emission, Start Speed 등), 코드 최신화

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

### Invoke Delay
- `Invoke("메서드명", 지연시간)` 형태로 일정 시간 뒤 메서드 실행.
- 코루틴 없이 간단히 지연 동작 구현 가능.

### Particle System
- **기능**: 불꽃, 연기, 폭발, 먼지, 반짝임 등 시각 효과 구현.
- **구성**: 여러 모듈(Modules)로 파티클 속성·행동 제어.

#### 주요 모듈 & 속성
1. **Main**
   - Duration: 한 번 재생되는 시간.
   - Looping: 반복 재생 여부.
   - Start Lifetime: 파티클 생존 시간.
   - Start Speed: 초기 속도.
   - Start Size: 초기 크기.
   - Start Color: 초기 색상.
   - Simulation Space: 월드/로컬 기준.
2. **Emission**
   - Rate over Time: 초당 생성 개수.
   - Rate over Distance: 이동 거리 기반 생성.
   - Bursts: 특정 시점에 대량 방출.
3. **Shape**
   - 방출 영역 형태(원, 구, 원뿔, 메쉬 등).
4. **Velocity over Lifetime**
   - 시간에 따른 속도 변화.
5. **Color over Lifetime**
   - 시간에 따른 색상 변화.
6. **Size over Lifetime**
   - 시간에 따른 크기 변화.
7. **Rotation over Lifetime**
   - 시간에 따른 회전 변화.
8. **Renderer**
   - 머티리얼, 쉐이더, 텍스처 시트 애니메이션, Sorting Layer 설정.

#### 사용 팁
- `Play()`, `Stop()`, `Clear()`로 스크립트 제어.
- 과도한 Emission은 FPS 저하 → Rate와 Lifetime 최적화.
- 필요한 순간에만 활성화해 성능 절약.

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
9. Invoke Delay 적용
10. 파티클 시스템 구현 및 세부 설정

---

## 📝 메모
- Collider Detail은 성능·품질 균형 고려.
- Cinemachine Dead Zone/Damping으로 시야 안정성 확보.
- 무게중심은 자식 Collider로 직관적 조정.
- AddTorque·Angular Drag로 회전 제어.
- SceneManagement.LoadScene 빌드 인덱스 주의.
- Invoke Delay는 간단한 지연 처리에 유용.
- 파티클은 시각적 효과 강화에 필수적이며, 성능 최적화 중요.
