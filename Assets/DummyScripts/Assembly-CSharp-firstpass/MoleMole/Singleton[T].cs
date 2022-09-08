/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class Singleton<T> // TypeDefIndex: 10613
		where T : class
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		static Singleton() {}
	
		// Methods
		public static void CreateByInstance(T instance) {}
		public static void Create() {}
		public static T GetInstance() => default;
		public static void Destroy() {}
	}
}
