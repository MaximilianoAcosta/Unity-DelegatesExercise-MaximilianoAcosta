
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateConsumer : MonoBehaviour
{
    [SerializeField] private string secretData = "this is a secret that I'll only share through delegates >:)";
    public delegate void GiveSecret(string secretData);
    
    public void ConsumeDelegate(GiveSecret giveSecret)
    {
        //TODO: Receive a delegate as parameter on this method and consume it.
        giveSecret?.Invoke(secretData);
        //TODO: Try your logic giving it a null and see if it shows a NullPointerException :)
    }
}
