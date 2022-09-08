/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_MonoBehaviourSingleton<T> : MonoBehaviour // TypeDefIndex: 3412
		where T : MonoBehaviour
	{
		// Fields
		private static MonoBehaviour _instance;
	
		// Properties
		public static T instance { get => default; }
		public static T nullableInstance { get => default; }
	
		// Constructors
		public pb_MonoBehaviourSingleton() {}
	
		// Methods
		public static bool Valid() => default;
		public virtual void Awake() {}
		public virtual void OnEnable() {}
	}
}
