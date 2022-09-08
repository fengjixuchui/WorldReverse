/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
	public struct Vector : IEmptyInitable, IHashable // TypeDefIndex: 17793
	{
		// Fields
		// [FormerlySerializedAs] // 0x000000018972FD10-0x000000018972FD50
		[SerializeField] // 0x000000018972FD10-0x000000018972FD50
		private float _x; // 0x00
		// [FormerlySerializedAs] // 0x000000018973BB70-0x000000018973BBC0
		[SerializeField] // 0x000000018973BB70-0x000000018973BBC0
		private float _y; // 0x04
		// [FormerlySerializedAs] // 0x0000000189747CB0-0x0000000189747D00
		[SerializeField] // 0x0000000189747CB0-0x0000000189747D00
		private float _z; // 0x08
	
		// Properties
		public float x { /* [XID] */ /* 0x0000000189919D50-0x0000000189919D70 */ get => default; /* [XID] */ /* 0x000000018975B0A0-0x000000018975B0C0 */ set {} } // 0x0000000186B7E260-0x0000000186B7E320 0x0000000186B7E4A0-0x0000000186B7E560
		public float y { /* [XID] */ /* 0x0000000189762A30-0x0000000189762A50 */ get => default; /* [XID] */ /* 0x000000018976A050-0x000000018976A070 */ set {} } // 0x0000000186B7E320-0x0000000186B7E3E0 0x0000000186B7E560-0x0000000186B7E620
		public float z { /* [XID] */ /* 0x0000000189771870-0x0000000189771890 */ get => default; /* [XID] */ /* 0x0000000189778FA0-0x0000000189778FC0 */ set {} } // 0x0000000186B7E3E0-0x0000000186B7E4A0 0x0000000186B7E620-0x0000000186B7E630
	
		// Methods
		// [IDTag] // 0x0000000189780660-0x00000001897806A0
		// [XID] // 0x0000000189780660-0x00000001897806A0
		public bool Equals(Vector otherVal) => default; // 0x0000000186B7CA20-0x0000000186B7CB60
		// [IDTag] // 0x000000018978AE00-0x000000018978AE40
		// [XID] // 0x000000018978AE00-0x000000018978AE40
		public override bool Equals(object other) => default; // 0x0000000186B7CB60-0x0000000186B7CE70
		// [XID] // 0x0000000189795320-0x0000000189795340
		public override int GetHashCode() => default; // 0x0000000186B7D2E0-0x0000000186B7D390
		// [XID] // 0x0000000189A2CAA0-0x0000000189A2CAC0
		public void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000186B7DD50-0x0000000186B7E030
		// [XID] // 0x00000001897A49F0-0x00000001897A4A10
		public void InitEmpty() {} // 0x0000000186B7D390-0x0000000186B7D670
		[BlackList] // 0x00000001897ABFE0-0x00000001897AC020
		// [XID] // 0x00000001897ABFE0-0x00000001897AC020
		public bool FromJson(JSONNode node) => default; // 0x0000000186B7D200-0x0000000186B7D2E0
		// [XID] // 0x0000000189BCCD60-0x0000000189BCCD80
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000186B7D9C0-0x0000000186B7DC90
		// [XID] // 0x00000001897BEF70-0x00000001897BEF90
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C53 */, bool useObjectPool = false /* Metadata: 0x00AF7C57 */) => default; // 0x0000000186B7CE70-0x0000000186B7D200
		// [XID] // 0x000000018979E250-0x000000018979E270
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C58 */, bool useObjectPool = false /* Metadata: 0x00AF7C5C */) => default; // 0x0000000186B7D670-0x0000000186B7D9C0
		[BlackList] // 0x00000001897CDDC0-0x00000001897CDE00
		// [XID] // 0x00000001897CDDC0-0x00000001897CDE00
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000186B7E030-0x0000000186B7E0F0
		// [XID] // 0x00000001897D8A10-0x00000001897D8A30
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000186B7DC90-0x0000000186B7DD50
	}
}
