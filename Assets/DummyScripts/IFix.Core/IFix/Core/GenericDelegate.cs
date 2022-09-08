/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	internal class GenericDelegate // TypeDefIndex: 5053
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		private bool pushSelf; // 0x28
		private int extraArgNum; // 0x2C
	
		// Constructors
		public GenericDelegate() {} // Dummy constructor
		internal GenericDelegate(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000189415100-0x00000001894151A0
	
		// Methods
		public void Action() {} // 0x0000000189415020-0x0000000189415100
		public void Action<T1>(T1 p1)
			where T1 : class {}
		public void Action<T1, T2>(T1 p1, T2 p2)
			where T1 : class
			where T2 : class {}
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
			where T1 : class
			where T2 : class
			where T3 : class {}
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class {}
		public TResult Func<TResult>()
			where TResult : class => default;
		public TResult Func<T1, TResult>(T1 p1)
			where T1 : class
			where TResult : class => default;
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2)
			where T1 : class
			where T2 : class
			where TResult : class => default;
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3)
			where T1 : class
			where T2 : class
			where T3 : class
			where TResult : class => default;
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4)
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class
			where TResult : class => default;
	}
}
