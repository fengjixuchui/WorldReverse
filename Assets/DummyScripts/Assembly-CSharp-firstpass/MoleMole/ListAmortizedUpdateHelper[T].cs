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
	public abstract class ListAmortizedUpdateHelper<T> : AmortizedUpateHelper, IReusable // TypeDefIndex: 10454
		where T : class
	{
		// Fields
		protected DeferredAddRemoveHashList<T> _updateList;
		protected DoublyList<T> _lastUpdateNode;
		protected float _lastGlobalTime;
		protected float _lastDeltaTime;
		public static bool useWhile;
	
		// Properties
		public int lastTickCount { get; private set; }
	
		// Nested types
		public enum ETimeout // TypeDefIndex: 10455
		{
			ETO_NoTimeout = 0,
			ETO_TimeoutWithCurrentTick = 1,
			ETO_TimeoutWithNoCurrentTick = 2
		}
	
		// Constructors
		protected ListAmortizedUpdateHelper() {}
		static ListAmortizedUpdateHelper() {}
	
		// Methods
		protected void Init() {}
		public override void BeforeRecycle() {}
		protected abstract void DoFirstUpdate(T inElement, float globalTime, float deltaTime);
		protected abstract void DoUpdate(T inElement, float globalTime);
		protected virtual void DoDestroy(T inElement) {}
		protected void OnFirstAddNode(T inElement) {}
		protected void OnRemoveListNode(DoublyList<T> toRemoveListNode) {}
		private void DoInternalTick(DoublyList<T> it, float globalTime) {}
		private ETimeout InternalTickWithWatch(DoublyList<T> it, float globalTime) => default;
		public void Add(T data) {}
		public void Remove(T data) {}
		public void DestroyAll() {}
		public override void AmortizedTick(float globalTime, float deltaTime) {}
		public bool Contains(T inElement) => default;
	}
}
