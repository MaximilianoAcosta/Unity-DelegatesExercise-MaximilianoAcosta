using UnityEngine;

public class DataConsumer : MonoBehaviour
{
    //TODO: Complete this method
    public delegate int GetAge(int personId);
    public delegate string GetName(int personId);
    public delegate short GetPostalCode(int personId);
    public void ReportPersonData(int personId, GetAge getAge, GetName getName, GetPostalCode getPostalCode)
    {
        string name = string.Empty;
        int age = -1;
        short postalCode = -1;

        name = getName(personId);
        age = getAge(personId);
        postalCode = getPostalCode(personId);


        var dataReport = string.Format("name: {0}, age: {1}, postal code: {2}", name, age, postalCode);
        Debug.Log($"{name}: Giving report on Data. {dataReport}");
    }
}
