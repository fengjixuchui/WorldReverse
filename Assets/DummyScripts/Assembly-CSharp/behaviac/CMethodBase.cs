/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class CMethodBase // TypeDefIndex: 27420
	{
		// Fields
		private MethodMetaInfoAttribute descAttrbute_; // 0x10
		private MethodBase method_; // 0x18
		protected string m_variableName; // 0x20
		private CStringID m_id; // 0x28
	
		// Properties
		public string Name { get => default; } // 0x0000000186D6DFC0-0x0000000186D6E020 
	
		// Constructors
		public CMethodBase() {} // Dummy constructor
		public CMethodBase(MethodBase m, MethodMetaInfoAttribute a, string methodNameOverride) {} // 0x0000000186D6DE40-0x0000000186D6DF40
		protected CMethodBase(CMethodBase copy) {} // 0x0000000186D6DDA0-0x0000000186D6DE40
	
		// Methods
		public CStringID GetId() => default; // 0x0000000186D6DCF0-0x0000000186D6DD50
		public virtual bool IsNamedEvent() => default; // 0x0000000186D6DD50-0x0000000186D6DDA0
		public virtual CMethodBase clone() => default; // 0x0000000186D6DF40-0x0000000186D6DFC0
	}
}
