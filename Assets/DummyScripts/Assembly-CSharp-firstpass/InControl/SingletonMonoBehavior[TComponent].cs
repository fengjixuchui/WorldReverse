/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public abstract class SingletonMonoBehavior<TComponent> : MonoBehaviour // TypeDefIndex: 8003
		where TComponent : MonoBehaviour
	{
		// Fields
		private static TComponent instance;
		private static bool hasInstance;
		private static int instanceId;
		private static readonly object lockObject;
	
		// Properties
		public static TComponent Instance { get; }
		protected bool EnforceSingleton { get; }
		protected bool IsTheSingleton { get; }
		protected bool IsNotTheSingleton { get; }
	
		// Constructors
		protected SingletonMonoBehavior() {}
		static SingletonMonoBehavior() {}
	
		// Methods
		private static TComponent[] FindInstances() => default;
		private static TComponent FindFirstInstance() => default;
		protected virtual void Awake() {}
		protected virtual void OnDestroy() {}
	}
}
