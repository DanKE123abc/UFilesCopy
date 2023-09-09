namespace UFilesCopy.Base;

public class Singleton<T> where T : new()
{
    private static T i;

    public static T instance
    {
        get
        {
            if (i == null)
            {
                i = new T();
            }
            
            return i;
        }
        
    }
}
