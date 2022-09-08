/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class CMemberBase // TypeDefIndex: 27421
	{
		// Fields
		protected string m_name; // 0x10
		private float m_range; // 0x18
		private CStringID m_id; // 0x1C
		private string m_instanceName; // 0x20
	
		// Properties
		public virtual System.Type MemberType { get => default; } // 0x0000000186D6DBE0-0x0000000186D6DC30 
		public string Name { get => default; } // 0x0000000186D6DC30-0x0000000186D6DC90 
		public string InstanceName { get => default; set {} } // 0x0000000186D6DB80-0x0000000186D6DBE0 0x0000000186D6DC90-0x0000000186D6DCF0
	
		// Constructors
		public CMemberBase() {} // Dummy constructor
		public CMemberBase(string name, MemberMetaInfoAttribute a) {} // 0x0000000186D6DAD0-0x0000000186D6DB80
	
		// Methods
		public virtual bool ISSTATIC() => default; // 0x0000000186D6D990-0x0000000186D6D9E0
		public float GetRange() => default; // 0x0000000186D6D880-0x0000000186D6D8F0
		public CStringID GetId() => default; // 0x0000000186D6D820-0x0000000186D6D880
		public virtual string GetClassNameString() => default; // 0x0000000186D6D7D0-0x0000000186D6D820
		public virtual int GetTypeId() => default; // 0x0000000186D6D8F0-0x0000000186D6D940
		public virtual void Load(Agent parent, ISerializableNode node) {} // 0x0000000186D6D9E0-0x0000000186D6DA30
		public virtual void Save(Agent parent, ISerializableNode node) {} // 0x0000000186D6DA30-0x0000000186D6DA80
		public virtual object Get(object agentFrom) => default; // 0x0000000186D6D940-0x0000000186D6D990
		public virtual void Set(object objectFrom, object v) {} // 0x0000000186D6DA80-0x0000000186D6DAD0
	}
}
