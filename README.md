# roullete

#작성 에디터 버전 : 2022.3.17f1

## 🎰 Roulette Game

Unity로 **처음 만든** 아주 단순한 2D 랜덤 룰렛 프로젝트입니다.

### 프로젝트 소개
2022년에 Unity를 처음 배우면서 만든 연습 프로젝트예요.  
마우스 클릭으로 룰렛을 돌리고 서서히 느려지면서 멈추는 기본 회전 로직만 구현되어 있습니다.

### 현재 구현된 기능
- 마우스 왼쪽 클릭으로 룰렛 회전 시작
- 서서히 감속되면서 자연스럽게 멈추는 효과 (`rotSpeed *= 0.96f`)
- 원판 위에 고정된 **화살표**로 결과 섹터를 시각적으로 확인 가능

### 주요 스크립트 (RouletController.cs)
```csharp
public class RouletController : MonoBehaviour
{
    float rotSpeed = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))     // 마우스 왼쪽 클릭
        {
            rotSpeed = 10f;
        }

        transform.Rotate(0, 0, rotSpeed);    // 회전
        rotSpeed *= 0.96f;                   // 자연스러운 감속
    }
}
