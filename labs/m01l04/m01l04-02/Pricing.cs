// Modern .NET Core, C# & Enterprise Microservices — lesson m01l04 — Collections, Generics, and LINQ
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l04
// © LearnSome.tech
public static class Pricing
{
    // One algorithm, any element type: T comes from the caller.
    public static T[] Repeat<T>(T value, int count)
    {
        T[] buffer = new T[count];
        Array.Fill(buffer, value);
        return buffer;
    }
}

public interface IStore<TKey, TItem>
    where TKey : notnull
    where TItem : class
{
    TItem? Get(TKey key);
    void Put(TKey key, TItem item);
}
