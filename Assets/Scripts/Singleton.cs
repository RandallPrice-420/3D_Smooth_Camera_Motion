//------------------------------------------------------------------------------
//  USAGE:  the class inherits from 'Singleton' instead of' MonoBehavior', etc.
//
//  Example:
//
//    public class MyClass : Singleton
//    {
//        ...
//    }
//
//------------------------------------------------------------------------------
using UnityEngine;


public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public  static T Instance
    {
        get
        {
            // The first time "_instance" is null so attempt to create it.
            if (_instance == null)
            {
                // Try to find the <T> object...
                _instance = FindObjectOfType<T>();

                // If <T> object is not found, then create a new one.
                if (_instance == null)
                {
                    // This happens the first time and after <T> got destroyed somewhere.
                    _instance = new GameObject(name: "Instance of " + typeof(T)).AddComponent<T>();
                }
            }

            return _instance;
        }
    }


}   // class Singleton<T>
