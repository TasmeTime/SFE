using System;

public class SFE
{
    public byte[] Encrypt(byte[] DATA)
    {
        byte[] newByte = new byte[DATA.Length];
        for (int i = 0; i < DATA.Length; i++)
        {
            newByte[i] = (byte)(DATA[i] + 2);
        }
        return newByte;
    }

    public byte[] Decrypt(byte[] DATA)
    {
        byte[] newByte = new byte[DATA.Length];
        for (int i = 0; i < DATA.Length; i++)
        {
            newByte[i] = (byte)(DATA[i] - 2);
        }
        return newByte;
    }

    public byte[] GetBytes(string PATH)
    {
        FileStream fs = new FileStream(PATH, FileMode.Open);
        byte[] b = new byte[fs.Length];
        fs.Read(b, 0, b.Length);
        fs.Close();
        return b;
    }

    public bool SaveFile(string PATH, byte[] DATA)
    {
        try
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            fs.Write(DATA, 0, DATA.Length);
            fs.Close();
            return true;
        }catch(Exception ex)
        {
            return false;
        }
    }

}
