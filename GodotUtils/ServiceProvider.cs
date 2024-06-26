﻿namespace GodotUtils;

public class ServiceProvider
{
    public class Service
    {
        public object Instance { get; set; }
        public bool Persistent { get; set; }
    }

    protected Dictionary<Type, Service> services = new();

    /// <summary>
    /// Add a Node that exists within the game tree. For example UIItemNotification
    /// exists within the game tree.
    /// </summary>
    public virtual Service Add(object instance, bool persistent = false)
    {
        Service service = new Service { 
            Instance = instance, 
            Persistent = persistent 
        };

        services.Add(instance.GetType(), service);

        return service;
    }

    /// <summary>
    /// Add a object that does not exist within the game tree. For example
    /// the Logger class does not extend from Node.
    /// </summary>
    public Service Add<T>() where T : new()
    {
        T instance = new T();
        Service service = new Service { 
            Instance = instance, 
            Persistent = true // all instances that do not exist in the game tree
            // should be persistent
        };

        services.Add(instance.GetType(), service);

        return service;
    }

    public T Get<T>() => (T)services[typeof(T)].Instance;

    public override string ToString() => services.Print();
}
