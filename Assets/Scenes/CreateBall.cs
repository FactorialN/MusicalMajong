
using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour
{

    private IEnumerator coroutine;
    private bool isStart = false;//用于控制生成器是否进行的flag
    public GameObject CreateObject;//设置物体形式参数

    void Start()
    {
        coroutine = WaitAndPrint(1.0f);//WaitAndPrint函数将0.2s执行一次
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))//如果按下鼠标右键
        {
            if (!isStart)//没开始
            {
                StartCoroutine(coroutine);//则打开这个生成器呗
                isStart = true;
            }
            else
            {
                StopCoroutine(coroutine);//否则销毁
                isStart = false;
                coroutine = WaitAndPrint(1.0f);//当然，销毁之后要留种，为下次再打开作准备              
            }
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)//协程coroutine的存在，配合下面的yield return回调，这段代码将被0.2s执行一次
    {
        while (true)
        {
            GameObject.Instantiate(CreateObject, gameObject.transform.position, gameObject.transform.rotation);//其实就这一段代码
            //CreateObject是被生成的物体，第二第三个参数分别指生成的位置与方向，这里就是穿过来的位置的当前位置和方向了
            yield return new WaitForSeconds(waitTime);
        }
    }
}