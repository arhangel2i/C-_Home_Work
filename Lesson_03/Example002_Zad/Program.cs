//===== Работа с текстом

string ModifyString(string msg)
{
    string retStr = string.Empty;
    for (int i =0; i<msg.Length; i++)
    {
        if (msg[i]=='к') retStr +='К';
        else if (msg[i]==' ') retStr +='-';
        else if (msg[i]=='С') retStr +='с';
        else retStr +=msg[i];
    }
    return retStr;
}

string msg = "каркуши-Сакуши-МарсушиС";
Console.Write(ModifyString(msg));