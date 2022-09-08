/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public class ParameterOverride<T> : ParameterOverride, IEquatable<UnityEngine.Rendering.PostProcessing.ParameterOverride<T>> // TypeDefIndex: 9555
	{
		// Fields
		public T value;
	
		// Constructors
		public ParameterOverride() {}
		public ParameterOverride(T value) {}
		public ParameterOverride(T value, bool overrideState) {}
	
		// Methods
		public virtual bool Equals(ParameterOverride<T> other) => default;
		internal override bool Interp(ParameterOverride from, ParameterOverride to, float t) => default;
		public virtual void Interp(T from, T to, float t) {}
		public void Override(T x) {}
		public override int GetHash() => default;
		public static implicit operator T(ParameterOverride<T> prop) => default;
	}
}
