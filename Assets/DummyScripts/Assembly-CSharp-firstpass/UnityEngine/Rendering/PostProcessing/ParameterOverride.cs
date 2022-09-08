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
	public abstract class ParameterOverride // TypeDefIndex: 9554
	{
		// Fields
		public bool overrideState; // 0x10
	
		// Constructors
		protected ParameterOverride() {} // 0x0000000185BFDB10-0x0000000185BFDB70
	
		// Methods
		internal abstract bool Interp(ParameterOverride from, ParameterOverride to, float t);
		public abstract int GetHash();
		public T GetValue<T>() => default;
	}
}
