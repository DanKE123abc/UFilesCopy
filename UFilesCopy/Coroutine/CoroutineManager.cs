using System.Collections;
using UFilesCopy.Base;

namespace UFilesCopy.Coroutine;

public class CoroutineManager : Singleton<CoroutineManager>
{
    //链表存储所有协程对象
    private LinkedList<Coroutine> _coroutineList = new LinkedList<Coroutine>();
    private LinkedList<Coroutine> _coroutinesToStop = new LinkedList<Coroutine>();

    /// <summary>
    /// 开启协程
    /// </summary>
    public Coroutine StartCoroutine(IEnumerator ie)
    {
        var c = new Coroutine(ie);
        _coroutineList.AddLast(c);
        return c;
    }

    /// <summary>
    /// 停止协程
    /// </summary>
    public void StopCoroutine(Coroutine coroutine)
    {
        _coroutinesToStop.AddLast(coroutine);
    }

    /// <summary>
    /// 停止所有协程
    /// </summary>
    public void StopAllCoroutines() //停止所有协程
    {
        _coroutinesToStop = _coroutineList;
    }
    
    public void CoroutinesUpdate()
    {
        var node = _coroutineList.First;
        while (node != null)
        {
            var cor = node.Value;
            bool ret = false;
            if (cor != null)
            {
                bool toStop = _coroutinesToStop.Contains(cor);
                if (!toStop)
                {
                    ret = cor.MoveNext();
                }
            }

            if (!ret)
            {
                _coroutineList.Remove(node);
            }

            node = node.Next;
        }
    }
}