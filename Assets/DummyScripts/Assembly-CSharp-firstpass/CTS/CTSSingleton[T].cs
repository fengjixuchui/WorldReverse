/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace CTS
{
	public class CTSSingleton<T> : MonoBehaviour // TypeDefIndex: 9131
		where T : MonoBehaviour
	{
		// Fields
		private static T _instance;
		private static object _lock;
	
		// Properties
		public static T Instance { get => default; }
	
		// Constructors
		public CTSSingleton() {}
		static CTSSingleton() {}
	}
}
