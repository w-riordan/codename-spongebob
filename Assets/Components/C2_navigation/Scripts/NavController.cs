using UnityEngine;

public class NavController : MonoBehaviour
{
    private NavModel navModel;

    void Awake()
    {
        navModel = new NavModel();
    }

    public NavModel GetNavModel()
    {
        return navModel;
    }

    public void Forward() {

        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x, y+10);
    }

    public void Backwards()
    {
        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x, y-10);
    }

    public void Left()
    {
        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x-10, y);
    }

    public void Right()
    {
        float x = GameObject.Find("Ship").transform.position.x;
        float y = GameObject.Find("Ship").transform.position.y;

        GameObject.Find("Ship").transform.position = new Vector3(x+10, y);
    }

}