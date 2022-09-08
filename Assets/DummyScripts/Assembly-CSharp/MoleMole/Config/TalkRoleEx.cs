/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class TalkRoleEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19058
	{
		// Fields
		private TalkRoleType _type; // 0x10
		private string _id; // 0x18
		private uint _roleId; // 0x20
	
		// Properties
		public TalkRoleType type { /* [XID] */ /* 0x0000000189AF15B0-0x0000000189AF15D0 */ get => default; /* [XID] */ /* 0x0000000189AF8B80-0x0000000189AF8BA0 */ set {} } // 0x0000000186B7A8B0-0x0000000186B7A950 0x0000000186B7AA00-0x0000000186B7AAB0
		public string id { /* [XID] */ /* 0x0000000189B000D0-0x0000000189B000F0 */ get => default; /* [XID] */ /* 0x0000000189B076B0-0x0000000189B076D0 */ set {} } // 0x0000000186B7A810-0x0000000186B7A8B0 0x0000000186B7A950-0x0000000186B7AA00
	
		// Constructors
		public TalkRoleEx() {} // 0x0000000186B7A7B0-0x0000000186B7A810
	
		// Methods
		// [XID] // 0x0000000189B0EED0-0x0000000189B0EEF0
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000186B7A250-0x0000000186B7A300
		// [XID] // 0x0000000189B161F0-0x0000000189B16210
		public void InitEmpty() {} // 0x0000000186B799E0-0x0000000186B79AB0
		[BlackList] // 0x0000000189B1D8B0-0x0000000189B1D8F0
		// [XID] // 0x0000000189B1D8B0-0x0000000189B1D8F0
		public bool FromJson(JSONNode node) => default; // 0x0000000186B79500-0x0000000186B79880
		// [XID] // 0x0000000189B27FD0-0x0000000189B27FF0
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000186B79D50-0x0000000186B7A010
		// [XID] // 0x0000000189B2F330-0x0000000189B2F350
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB903 */, bool useObjectPool = false /* Metadata: 0x00AFB907 */) => default; // 0x0000000186B79200-0x0000000186B79500
		// [XID] // 0x0000000189B36CB0-0x0000000189B36CD0
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB908 */, bool useObjectPool = false /* Metadata: 0x00AFB90C */) => default; // 0x0000000186B79AB0-0x0000000186B79D50
		[BlackList] // 0x0000000189B3E4E0-0x0000000189B3E520
		// [XID] // 0x0000000189B3E4E0-0x0000000189B3E520
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000186B7A4E0-0x0000000186B7A7B0
		// [XID] // 0x0000000189B490C0-0x0000000189B490E0
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000186B7A010-0x0000000186B7A250
		[BlackList] // 0x0000000189B50680-0x0000000189B506C0
		// [XID] // 0x0000000189B50680-0x0000000189B506C0
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B790B0-0x0000000186B79150
		[BlackList] // 0x0000000189B5AE70-0x0000000189B5AEB0
		// [XID] // 0x0000000189B5AE70-0x0000000189B5AEB0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B79150-0x0000000186B79200
		[BlackList] // 0x0000000189B65500-0x0000000189B65540
		// [XID] // 0x0000000189B65500-0x0000000189B65540
		public virtual void ReturnToObjectPool() {} // 0x0000000186B7A440-0x0000000186B7A4E0
		[BlackList] // 0x0000000189B6FBC0-0x0000000189B6FC00
		// [XID] // 0x0000000189B6FBC0-0x0000000189B6FC00
		public virtual void OnPoolAllocated() {} // 0x0000000186B7A3A0-0x0000000186B7A440
		[BlackList] // 0x0000000189B7A190-0x0000000189B7A1D0
		// [XID] // 0x0000000189B7A190-0x0000000189B7A1D0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B7A300-0x0000000186B7A3A0
		// [XID] // 0x0000000189B84E30-0x0000000189B84E50
		public uint GetID(uint mainQuestId = 0 /* Metadata: 0x00AFB90D */) => default; // 0x0000000186B79880-0x0000000186B799E0
	}
}
