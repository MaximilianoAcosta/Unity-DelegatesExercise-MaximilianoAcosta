using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer consumer;

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO: Add the parameter here to handle the secret.
        //You can log the value to test it :)
        consumer.ConsumeDelegate(PrintSecret);
    }

    private void PrintSecret(string secretWord)
    {
        Debug.Log(secretWord);
    }
}
