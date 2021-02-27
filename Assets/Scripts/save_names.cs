using UnityEngine;
using UnityEngine.UI;

public class save_names : MonoBehaviour
{

    public static save_names save_Names;
    public InputField inputField;
    public string userName;

    private void Awake()
    {
        if (save_Names == null)
        {
            save_Names = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    private void Update()
    {
        if (userName != inputField.text)
        {
            userName = inputField.text;
        }
    }
}