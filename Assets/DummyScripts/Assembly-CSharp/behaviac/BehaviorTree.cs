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
	public sealed class BehaviorTree : BehaviorNode // TypeDefIndex: 27442
	{
		// Fields
		private const int SupportedVersion = 5; // Metadata: 0x00B0C9B8
		private Dictionary<uint, ICustomizedProperty> m_localProps; // 0x60
		private string m_name; // 0x68
		private bool m_bIsFSM; // 0x70
	
		// Properties
		public Dictionary<uint, ICustomizedProperty> LocalProps { get => default; } // 0x00000001860B54E0-0x00000001860B5540 
		public bool IsFSM { get => default; set {} } // 0x00000001860B5480-0x00000001860B54E0 0x00000001860B5F40-0x00000001860B5FA0
	
		// Constructors
		public BehaviorTree() {} // 0x00000001860B5360-0x00000001860B5410
	
		// Methods
		public void AddPar(string agentType, string typeName, string name, string valueStr) {} // 0x00000001860B4EE0-0x00000001860B4F80
		public void AddLocal(string agentType, string typeName, string name, string valueStr) {} // 0x00000001860B4CD0-0x00000001860B4EE0
		public void InstantiatePars(Dictionary<uint, IInstantiatedVariable> vars) {} // 0x00000001860B4FE0-0x00000001860B51D0
		public void UnInstantiatePars(Dictionary<uint, IInstantiatedVariable> vars) {} // 0x00000001860B5230-0x00000001860B5360
		protected override void load_local(int version, string agentType, SecurityElement node) {} // 0x00000001860B59F0-0x00000001860B5B40
		protected override void load_local(int version, string agentType, BsonDeserizer d) {} // 0x00000001860B58E0-0x00000001860B59F0
		public bool load_xml(byte[] pBuffer) => default; // 0x00000001860B5B40-0x00000001860B5F40
		public bool load_bson(byte[] pBuffer) => default; // 0x00000001860B5540-0x00000001860B58E0
		public string GetName() => default; // 0x00000001860B4F80-0x00000001860B4FE0
		public void SetName(string name) {} // 0x00000001860B51D0-0x00000001860B5230
		protected override BehaviorTask createTask() => default; // 0x00000001860B5410-0x00000001860B5480
	}
}
