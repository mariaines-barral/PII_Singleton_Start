namespace Library;

public class Singleton<T> where T : new()
{
    public Singleton()
    {
        T t = new T();
    }
    
    public static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }

            return instance;
        }
    }
}