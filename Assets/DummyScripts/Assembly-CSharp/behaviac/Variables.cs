/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class Variables // TypeDefIndex: 27552
	{
		// Fields
		protected Dictionary<uint, IInstantiatedVariable> m_variables; // 0x10
	
		// Properties
		public Dictionary<uint, IInstantiatedVariable> Vars { get => default; } // 0x0000000186DFDB70-0x0000000186DFDBD0 
	
		// Constructors
		public Variables(Dictionary<uint, IInstantiatedVariable> vars) {} // 0x0000000186DFDAD0-0x0000000186DFDB70
		public Variables() {} // 0x0000000186DFDA20-0x0000000186DFDAD0
	
		// Methods
		public bool IsExisting(uint varId) => default; // 0x0000000186DFD610-0x0000000186DFD6A0
		public virtual IInstantiatedVariable GetVariable(uint varId) => default; // 0x0000000186DFD560-0x0000000186DFD610
		public virtual void AddVariable(uint varId, IInstantiatedVariable pVar, int stackIndex) {} // 0x0000000186DFD130-0x0000000186DFD1D0
		public void Log(Agent agent) {} // 0x0000000186DFD6A0-0x0000000186DFD6F0
		public void UnLoad(string variableName) {} // 0x0000000186DFD8F0-0x0000000186DFD9D0
		public void Unload() {} // 0x0000000186DFD9D0-0x0000000186DFDA20
		public void CopyTo(Agent pAgent, Variables target) {} // 0x0000000186DFD1D0-0x0000000186DFD560
		private void Save(ISerializableNode node) {} // 0x0000000186DFD6F0-0x0000000186DFD8F0
	}
}
