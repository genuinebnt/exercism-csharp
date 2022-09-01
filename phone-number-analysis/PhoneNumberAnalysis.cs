using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var IsNewYork = phoneNumber.Split('-')[0];
        var IsFake = phoneNumber.Split('-')[1];
        var LocalNumber = phoneNumber.Split('-')[2];

        return (IsNewYork == "212", IsFake == "555", LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
