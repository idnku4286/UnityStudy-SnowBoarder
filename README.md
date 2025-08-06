## 공부 내용: Closed Sprite Shape, Sprite Shape Profile, Edge Collider 2D

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

### 작업 요약
1. 2D Object > Sprite Shape 생성
2. Sprite Shape Controller에서 Profile 연결
3. Spline의 제어점을 편집하여 지형 생성
4. Closed Shape 옵션 활성화
5. 자동 생성된 Edge Collider 2D 확인 및 Offset, Geometry Precision 조절

---

### 메모
- Sprite Shape과 Edge Collider 조합을 통해 시각적 표현과 충돌 판정을 동시에 처리할 수 있어 효율적이다.
- Collider Offset 조절은 충돌 오류나 캐릭터 위치 보정에 유용하다.
- 추후 Polygon Collider 2D, Composite Collider 2D, Tilemap Collider 2D와의 차이점도 비교할 예정.
