using System;
/// <summary>
/// Singleton Pattern
/// </summary>
/// <typeparam name="T"></typeparam>
public static class Singleton<T> where T : class
{
    private static T _instance;
    /// <summary>
    /// Singletonクラスのインスタンスを取る
    /// </summary>
    public static T Instance { get { return _instance; } }
    /// <summary>
    /// 構造関数を隠す
    /// </summary>
    static Singleton() { }
    /// <summary>
    /// Objectを使ってSingletonクラスを作成
    /// </summary>
    /// <param name="instance"></param>
    public static void CreateByInstance(T instance)
    {
        _instance = instance;
    }
    /// <summary>
    /// Singletonクラスを作成
    /// </summary>
    public static void Create()
    {
        _instance = (T)Activator.CreateInstance(typeof(T), true);
    }
    /// <summary>
    /// Singletonクラスを削除
    /// </summary>
    public static void Destroy()
    {
        _instance = null;
    }
}

