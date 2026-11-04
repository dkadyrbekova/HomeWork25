using System;
using System.Collections.Generic;

public static class ListExtensions
{
    // Новый список с элементами, прошедшими проверку
    public static List<T> Filter<T>(
        this List<T> items,
        Predicate<T> predicate)
    {
        List<T> result = new();

        foreach (T item in items)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    // Преобразование T -> TResult
    public static List<TResult> Transform<T, TResult>(
        this List<T> items,
        Func<T, TResult> selector)
    {
        List<TResult> result = new();

        foreach (T item in items)
        {
            result.Add(selector(item));
        }

        return result;
    }

    // Действие для каждого элемента
    public static void ForEach<T>(
        this List<T> items,
        Action<T> action)
    {
        foreach (T item in items)
        {
            action(item);
        }
    }
}