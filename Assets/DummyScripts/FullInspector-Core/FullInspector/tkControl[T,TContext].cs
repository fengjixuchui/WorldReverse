/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public abstract class tkControl<T, TContext> : tkIControl // TypeDefIndex: 4946
	{
		// Fields
		private int _uniqueId;
		private List<tkStyle<T, TContext>> _styles;
	
		// Properties
		public System.Type ContextType { get; }
		public tkStyle<T, TContext> Style { get; set; }
		public List<tkStyle<T, TContext>> Styles { get; set; }
		protected virtual IEnumerable<tkIControl> NonMemberChildControls { get; }
	
		// Constructors
		protected tkControl() {}
	
		// Methods
		protected fiGraphMetadata GetInstanceMetadata(fiGraphMetadata metadata) => default;
		protected abstract T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata);
		protected abstract float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata);
		public virtual bool ShouldShow(T obj, TContext context, fiGraphMetadata metadata) => default;
		public T Edit(Rect rect, T obj, TContext context, fiGraphMetadata metadata) => default;
		public object Edit(Rect rect, object obj, object context, fiGraphMetadata metadata) => default;
		public float GetHeight(T obj, TContext context, fiGraphMetadata metadata) => default;
		public float GetHeight(object obj, object context, fiGraphMetadata metadata) => default;
		void tkIControl.InitializeId(ref int nextId) {}
		private static bool TryReadValue<TValue>(MemberInfo member, object context, out TValue value) {
			value = default;
			return default;
		}
		private static bool TryGetMemberType(MemberInfo member, out System.Type memberType) {
			memberType = default;
			return default;
		}
	}
}
