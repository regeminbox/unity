using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fire_Talk : MonoBehaviour
{
    public Text dialogueText;
    public Image backgroundImage1;
    public Image characterImage1;
    public Image characterImage2;
    public Button choiceButton1, choiceButton2, choiceButton3;
    public Sprite[] backgrounds;
    public Sprite[] characterImages1;
    public Sprite[] characterImages2;

    private int currentLine = 0;
    private bool choicesActive = false;

    private string[] dialogues = new string[]
    {
        "이슬이 : 와! 여기 정말 예쁜 게 많아 정말 다 갖고 싶을걸?",//0
        "이슬이 : 난 어른이 되면 이걸 전부 다 사고 말거야!",//1
        "진구 : 거 참 돈을 많이 벌어야겠네",//2
        "로봇핑 : 삐릿삐삐",//3
        "로봇핑 : 이 백화점 물건을 전부 계산하면 5억 3500백이 듭니다.",//4
        "로봇핑 : 직장인 평균 연봉을 계산하면 4,214만원 평소에 한푼도 안 쓰고 13년 모으신다면 다 사실 수 있습니다.",//5
        "이슬이 : 쓸데없는 걸 계산하지 말라고! 그리고 왜 존댓말을 쓰는 거야!",//6
        "이슬이 : 원래대로 하라고! 원래대로!",//7
        "진구 : 저거 고장났네",//8
        "로봇핑 : 힝",//9
        "그 시각 백화점 창고안",//10
        "직원1 : 아이고 너무 힘들다 과장님은 날 안 괴롭혀서 안달이 났어,(담배를 피면서)",//11
        "직원2 : 그러게 좀 직원들 편하게 나두지",//12
        "직원1 : 하, 정말 이직하고 싶다.",//13
        "직원1 : 그나저나 우리 식품구역 재고정리 했었나?",//14
        "직원2 : 우리 가구구역만 하고 식품구역은 안한걸로 알고 있어",//15
        "직원1 : 그래? 하,, 그럼 이제 가야겠네",//16
        "직원2 : 그럼 바로 가자(담배꽁초를 땅에 버린다)",//17
        "(담배꽁초가 땅에 떨어진다)",//18
        "(담배꽁초 불이 불에 잘 붙는 물질에 닿아 불이 점점 커진다)",//19
        "(창고의 불이 백화점 내부까지 번진다)",//20
        "(백화점 내부가 연기에 의해 자욱해진다)",//21
        "이슬이 : 어? 백화점 내부에서 약간 타는 냄새가 나는 거 같은데?",//22
        "진구 : 백화점 내부에서 달고 나라도 팔아? 근데 나는 뻥튀기가 좋은데",//23
        "백화점 스피커 : 손님 여러분 백화점 내부에서 화재가 발생했으므로 신속한 대피 바랍니다.",//24
        "이슬이 : 어? 어? 어떻게 백화점에 화재가 발생했대! 어떻게 하지?",//25
        "진구 : 어? 따뜻하다",//26
        "이슬이 : 아니 얘는! 무슨 이상한 소리를 하고 있어! 빨리 대피해야지!",//27
        "이슬이 : 로봇 핑! 어떻게 해야 여기서 대피를 할 수 있어?",//28
        "로봇핑 : 일단 여기 연기로부터 입과 코를 보호할 물건을 집고 탈출을 시도해보자",//29
    };

    void Start()
    {
        choiceButton1.gameObject.SetActive(false);
        choiceButton2.gameObject.SetActive(false);
        choiceButton3.gameObject.SetActive(false);

        choiceButton1.onClick.AddListener(() => OnChoiceSelected(1));
        choiceButton2.onClick.AddListener(() => OnChoiceSelected(2));
        choiceButton3.onClick.AddListener(() => OnChoiceSelected(3));

        UpdateDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !choicesActive)
        {
            currentLine++;
            if (currentLine < dialogues.Length)
            {
                UpdateDialogue();// 그전이면 계속해서 텍스트를 넘기고
            }
            else
            {
                ShowChoices(); //마지막에 달았을 경우 선택지를 줘라 
            }
        }
    }

    void UpdateDialogue()
    {
        dialogueText.text = dialogues[currentLine];

        if (currentLine == 0)
        {
            FadeOutInBackground(0); // 첫 번째 배경으로 전환
            ChangeCharacterImage(1, 0, new Vector3(462, -127, 0));
            ChangeCharacterImage(2, 2, new Vector3(-411, -137, 0));
        }else if(currentLine == 3){
            ChangeCharacterImage(2, 1, new Vector3(-411, -137, 0));
        }else if(currentLine ==8){
            ChangeCharacterImage(2, 2, new Vector3(-411, -137, 0));
        }else if(currentLine == 9){
            ChangeCharacterImage(2, 1, new Vector3(-411, -137, 0));
        }
        else if (currentLine == 10)
        {
            FadeOutInBackground(1); // 두 번째 배경으로 전환
            ChangeCharacterImage(1, 3, new Vector3(462, -127, 0));
            ChangeCharacterImage(2, 3, new Vector3(-411, -137, 0));
        }else if (currentLine ==18){
            ChangeCharacterImage(1, -1, new Vector3(462, -127, 0));
            ChangeCharacterImage(2, -1, new Vector3(-411, -137, 0));

        }else if(currentLine == 19 ){
            FadeOutInBackground(3);
        }else if (currentLine == 20){
            FadeOutInBackground(2);
        }else if (currentLine == 22){
             ChangeCharacterImage(1, 0, new Vector3(462, -127, 0));
             ChangeCharacterImage(2, 2, new Vector3(-411, -137, 0));
        }else if (currentLine ==29){
            ChangeCharacterImage(2,1,new Vector3(-411, -137, 0));
        }

        if (currentLine == 0 || currentLine == 6 || currentLine == 11 || currentLine ==25) // 캐릭터 움직임 적용
        {
            StartCoroutine(BounceCharacter(characterImage1));
        }
        if (currentLine == 17){
            StartCoroutine(MoveCharacterHorizontally(characterImage1, -600, 1.5f));
            StartCoroutine(MoveCharacterHorizontally(characterImage2, -600, 1f));
        }



    }

    void ShowChoices()
    {
        choicesActive = true;
        choiceButton1.gameObject.SetActive(true);
        choiceButton2.gameObject.SetActive(true);
        choiceButton3.gameObject.SetActive(true);
    }

    void OnChoiceSelected(int choice)
    {
        if (choice == 1 || choice == 3)
        {
            dialogueText.text = choice == 1 ? "이슬이 : 무슨 탈출에 장난감이야!" : "이슬이 : 으이구! 다시 한번 생각해봐";
            Invoke("ShowChoices", 1.5f);
        }
        else if (choice == 2)
        {
            dialogueText.text = "로봇핑 : 좋아 손수건에 물을 적셔서 코와 입을 가린 후 탈출을 해보자";
            Invoke("LoadFireEscapeScene",1.5f);
        }

        choiceButton1.gameObject.SetActive(false);
        choiceButton2.gameObject.SetActive(false);
        choiceButton3.gameObject.SetActive(false);
        choicesActive = false;
    }

    void ChangeBackground(int index) //배경화면 바꾸는 함수 
    {
        if (index < backgrounds.Length)
        {
            backgroundImage1.sprite = backgrounds[index];
        }
    }

    void LoadFireEscapeScene(){ //다음씬으로 넘어가기 
        SceneManager.LoadScene("FireEscape");
    }



    void ChangeCharacterImage(int characterNumber, int imageIndex, Vector3 newPosition) //캐릭터의 이미지를 바꾼다 
    {
        Image characterImage = characterNumber == 1 ? characterImage1 : characterImage2;

    if(characterImage != null){
            if (imageIndex == -1){  // 이미지 널값을 주고 싶으면 -1을 넣으면 됨
                characterImage.color = new Color(1,1,1,0);
            }  
        else if (imageIndex < characterImages1.Length)
        {
            characterImage.sprite = characterNumber == 1 ? characterImages1[imageIndex] : characterImages2[imageIndex];
            characterImage.color = new Color(1,1,1,1);
            characterImage.rectTransform.localPosition = newPosition;
        }
      }
    }
    //이미지가 뛴다
    IEnumerator BounceCharacter(Image character) //이미지 움직임 
    {
        Vector3 startPos = character.rectTransform.localPosition;
        for (int i = 0; i < 4; i++)
        {
            character.rectTransform.localPosition = new Vector3(startPos.x, startPos.y + 10f, startPos.z);
            yield return new WaitForSeconds(0.1f);
            character.rectTransform.localPosition = startPos; // 정확히 복원
            yield return new WaitForSeconds(0.1f);
        }
    }
    // 오류 잡기 배경화면이나 휴먼이미지가 없으면 오류발생 
    IEnumerator FadeOutAndIn(int newBackgroundIndex)
    {
        if (backgroundImage1 == null)
        {
            Debug.LogError("backgroundImage1 is not assigned.");
            yield break;
        }

        if (newBackgroundIndex >= backgrounds.Length || backgrounds[newBackgroundIndex] == null)
        {
            Debug.LogError("The background image is not assigned or the index is out of range.");
            yield break;
        }

        for (float t = 0; t < 1; t += Time.deltaTime)
        {
            backgroundImage1.color = new Color(1, 1, 1, 1 - t);
            yield return null;
        }

        backgroundImage1.sprite = backgrounds[newBackgroundIndex];

        for (float t = 0; t < 1; t += Time.deltaTime)
        {
            backgroundImage1.color = new Color(1, 1, 1, t);
            yield return null;
        }
    }
    IEnumerator MoveCharacterHorizontally(Image character, float targetX, float duration)
{
    Vector3 startPosition = character.rectTransform.localPosition;
    Vector3 targetPosition = new Vector3(targetX, startPosition.y, startPosition.z);
    float elapsedTime = 0;

    while (elapsedTime < duration)
    {
        character.rectTransform.localPosition = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
        elapsedTime += Time.deltaTime;
        yield return null;
    }

    character.rectTransform.localPosition = targetPosition; // 최종 위치로 설정
}





    void FadeOutInBackground(int newBackgroundIndex)
    {
        StartCoroutine(FadeOutAndIn(newBackgroundIndex));
    }
}
