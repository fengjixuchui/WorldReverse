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
	public abstract class SliceFrameJobHandlerOfTBase<T> : ISliceFrameJobHandler // TypeDefIndex: 10632
		where T : class
	{
		// Fields
		protected T notify;
		protected int _currentIdx;
		protected int _totalCount;
	
		// Properties
		public int currentHandleIdx { get; }
		public int totalCount { get; }
		public bool bFinished { get; }
	
		// Constructors
		protected SliceFrameJobHandlerOfTBase() {}
	
		// Methods
		public void IncreaseHandledCount() {}
		public abstract void Handle(int i);
		public virtual void OnAccept(T inNotify) {}
		public virtual void Dispose() {}
		protected abstract void Dealloc();
	}
}
