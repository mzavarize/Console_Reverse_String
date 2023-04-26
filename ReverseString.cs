namespace Console_Reverse_String;
public class ReverseString
{
    public string Reverse(string strInput)
    {
        return ReversePosition(strInput, 0);
    }

    private string ReversePosition(string strInput, int Pos)
    {
        string strOutput = null!;
        if (strInput.Length > Pos)
        {
            strOutput = ReversePosition(strInput, Pos+1);
            strOutput += strInput[Pos];
        }
        return strOutput;


    }
}

