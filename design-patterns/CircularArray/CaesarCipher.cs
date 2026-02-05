namespace CircularArray;

public class CaesarCipher
{
    private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    public string Encode(string text, int shift)
    {
        text = text.ToUpper();
        char[] input = text.ToCharArray();
        int i = 0;
        foreach (char c in text)
        {
            int position = 0;
            foreach (char index in _alphabet)
            {
                if (c == index)
                    break;
                position++;
            }
            int finalPosition = (position+shift) % 26;
            input[i] = _alphabet[finalPosition];
            i++;
            text = new string(input);
        }
        return text;
    }

    public string Decode(string text, int shift)
    {
        text = text.ToUpper();
        char[] input = text.ToCharArray();
        int i = 0;
        foreach (char c in text)
        {
            int position = 0;
            foreach (char index in _alphabet)
            {
                if (c == index)
                    break;
                position++;
            }
            int finalPosition = (position-shift) % 26;
            input[i] = _alphabet[finalPosition];
            text = new string(input);
            i++;
        }
        return text;
    }
    
}