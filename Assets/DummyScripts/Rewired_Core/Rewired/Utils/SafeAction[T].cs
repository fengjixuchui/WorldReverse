/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal sealed class SafeAction<T> : SafeDelegate<Action<T>> // TypeDefIndex: 4366
	{
		// Fields
		private T JlMCBZeMbvoncHXCRldnqnFCoRnV;
		private static Action<object, Action<T>> JqkKvONojrNrQhtXccOtrbSsnZb;
	
		// Properties
		private static Action<object, Action<T>> invokeDelegate { get => default; }
	
		// Constructors
		public SafeAction() {}
		public SafeAction(Action<Exception> exceptionHandler) {}
		protected SafeAction(SafeAction<T> source) {}
	
		// Methods
		public void Invoke(T arg0) {}
		public override object Clone() => default;
		private static void bpepNPWIUMvlIWByBwlQNAILiEgd(object param_0000913c, Action<T> param_0000913d) {}
		public static SafeAction<T> operator +(SafeAction<T> eventList, Action<T> listener) => default;
		public static SafeAction<T> operator -(SafeAction<T> eventList, Action<T> listener) => default;
	}
}
