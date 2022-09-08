/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class JSONNode // TypeDefIndex: 6094
	{
		// Fields
		public static readonly JSONNode InvalidNode; // 0x00
		public static readonly JSONNode NullNode; // 0x08
		public NodeType _type; // 0x10
		private string _stringValue; // 0x18
		private double _numberValue; // 0x20
		private Dictionary<string, JSONNode> _objectValue; // 0x28
		private List<JSONNode> _arrayValue; // 0x30
		private bool _boolValue; // 0x38
	
		// Properties
		public NodeType Type { get => default; } // 0x00000001856B0010-0x00000001856B0070 
		public bool IsValid { get => default; } // 0x00000001856AFDE0-0x00000001856AFE40 
		public JSONNode this[string k] { get => default; set {} } // 0x00000001856AFF30-0x00000001856B0010 0x00000001856B07D0-0x00000001856B0900
		public JSONNode this[int idx] { get => default; set {} } // 0x00000001856AFE40-0x00000001856AFF30 0x00000001856B0900-0x00000001856B0AA0
		public int Count { get => default; } // 0x00000001856AFCD0-0x00000001856AFD80 
		public bool IsNull { get => default; } // 0x00000001856AFD80-0x00000001856AFDE0 
		public object Value { get => default; } // 0x00000001856B0070-0x00000001856B0190 
		public string AsJSON { get => default; } // 0x00000001856AFC40-0x00000001856AFCD0 
	
		// Nested types
		public enum NodeType // TypeDefIndex: 6095
		{
			Invalid = 0,
			String = 1,
			Number = 2,
			Object = 3,
			Array = 4,
			Bool = 5,
			Null = 6
		}
	
		// Constructors
		public JSONNode() {} // Dummy constructor
		public JSONNode(NodeType type = NodeType.Null /* Metadata: 0x00ADBC17 */) {} // 0x00000001856AF8F0-0x00000001856AF9C0
		public JSONNode(string value) {} // 0x00000001856AFA40-0x00000001856AFAC0
		public JSONNode(double value) {} // 0x00000001856AF9C0-0x00000001856AFA40
		public JSONNode(Dictionary<string, JSONNode> value) {} // 0x00000001856AFAC0-0x00000001856AFB40
		public JSONNode(List<JSONNode> value) {} // 0x00000001856AFB40-0x00000001856AFBC0
		public JSONNode(bool value) {} // 0x00000001856AFBC0-0x00000001856AFC40
		static JSONNode() {} // 0x00000001856AF7B0-0x00000001856AF8F0
	
		// Methods
		public static JSONNode Parse(string json) => default; // 0x00000001856AF720-0x00000001856AF7B0
		public JSONNode Check() => default; // 0x00000001856AF650-0x00000001856AF720
		public static implicit operator string(JSONNode n) => default; // 0x00000001856B0330-0x00000001856B03B0
		public static implicit operator JSONNode(string v) => default; // 0x00000001856B0190-0x00000001856B0210
		public static implicit operator int(JSONNode n) => default; // 0x00000001856B0430-0x00000001856B04B0
		public static implicit operator JSONNode(int v) => default; // 0x00000001856B0210-0x00000001856B02A0
		public static implicit operator float(JSONNode n) => default; // 0x00000001856B04B0-0x00000001856B0540
		public static implicit operator JSONNode(float v) => default; // 0x00000001856B05C0-0x00000001856B0650
		public static implicit operator double(JSONNode n) => default; // 0x00000001856B03B0-0x00000001856B0430
		public static implicit operator JSONNode(double v) => default; // 0x00000001856B0650-0x00000001856B06D0
		public static implicit operator Dictionary<string, JSONNode>(JSONNode n) => default; // 0x00000001856B06D0-0x00000001856B0750
		public static implicit operator List<JSONNode>(JSONNode n) => default; // 0x00000001856B0750-0x00000001856B07D0
		public void Add(JSONNode item) {} // 0x00000001856AF560-0x00000001856AF650
		public static implicit operator bool(JSONNode n) => default; // 0x00000001856B0540-0x00000001856B05C0
		public static implicit operator JSONNode(bool v) => default; // 0x00000001856B02A0-0x00000001856B0330
	}
}
