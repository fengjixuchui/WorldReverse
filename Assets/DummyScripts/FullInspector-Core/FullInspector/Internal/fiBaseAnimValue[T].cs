/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public abstract class fiBaseAnimValue<T> // TypeDefIndex: 4969
	{
		// Fields
		private double m_LerpPosition;
		public float speed;
		private T m_Start;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private T m_Target;
		private double m_LastTime;
		private bool m_Animating;
	
		// Properties
		public bool isAnimating { get; }
		protected float lerpPosition { get; }
		public T target { get; set; }
		public T value { get; }
	
		// Constructors
		protected fiBaseAnimValue() {} // Dummy constructor
		protected fiBaseAnimValue(T value) {}
	
		// Methods
		private static T2 Clamp<T2>(T2 val, T2 min, T2 max)
			where T2 : IComparable<T2> => default;
		protected void BeginAnimating(T newTarget, T newStart) {}
		private void Update() {}
		private void UpdateLerpPosition() {}
		protected abstract T GetValue();
	}
}
