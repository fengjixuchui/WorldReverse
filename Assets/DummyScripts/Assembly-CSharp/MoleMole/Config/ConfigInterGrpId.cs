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
	[CSharpCallLua] // 0x00000001899BE290-0x00000001899BE2D0
	[RecycleType] // 0x00000001899BE290-0x00000001899BE2D0
	public class ConfigInterGrpId : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18374
	{
		// Fields
		private uint _index; // 0x10
		private uint _grpId; // 0x14
		private uint _nextGrpId; // 0x18
	
		// Properties
		public uint index { /* [XID] */ /* 0x00000001897E0680-0x00000001897E06A0 */ get => default; /* [XID] */ /* 0x0000000189BBC950-0x0000000189BBC970 */ private set {} } // 0x000000018882B520-0x000000018882B5C0 0x000000018882B710-0x000000018882B7C0
		public uint grpId { /* [XID] */ /* 0x0000000189BC45C0-0x0000000189BC45E0 */ get => default; /* [XID] */ /* 0x0000000189BCBFC0-0x0000000189BCBFE0 */ private set {} } // 0x000000018882B480-0x000000018882B520 0x000000018882B660-0x000000018882B710
		public uint nextGrpId { /* [XID] */ /* 0x0000000189BD3550-0x0000000189BD3570 */ get => default; /* [XID] */ /* 0x0000000189BDAE00-0x0000000189BDAE20 */ private set {} } // 0x000000018882B5C0-0x000000018882B660 0x000000018882B7C0-0x000000018882B870
	
		// Constructors
		public ConfigInterGrpId() {} // 0x000000018882B420-0x000000018882B480
	
		// Methods
		// [XID] // 0x00000001895E7830-0x00000001895E7850
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018882AE50-0x000000018882AF70
		// [XID] // 0x00000001895EF120-0x00000001895EF140
		public void InitEmpty() {} // 0x000000018882A4E0-0x000000018882A580
		[BlackList] // 0x00000001895F6AC0-0x00000001895F6B00
		// [XID] // 0x00000001895F6AC0-0x00000001895F6B00
		public bool FromJson(JSONNode node) => default; // 0x000000018882A160-0x000000018882A4E0
		// [XID] // 0x0000000189601040-0x0000000189601060
		private bool InternalFromJson(JSONNode node) => default; // 0x000000018882A850-0x000000018882AB90
		// [XID] // 0x0000000189608A30-0x0000000189608A50
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9695 */, bool useObjectPool = false /* Metadata: 0x00AF9699 */) => default; // 0x0000000188829E60-0x000000018882A160
		// [XID] // 0x00000001899D2340-0x00000001899D2360
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF969A */, bool useObjectPool = false /* Metadata: 0x00AF969E */) => default; // 0x000000018882A580-0x000000018882A850
		[BlackList] // 0x00000001896174B0-0x00000001896174F0
		// [XID] // 0x00000001896174B0-0x00000001896174F0
		public bool ToBinary(ByteArray byteArray) => default; // 0x000000018882B150-0x000000018882B420
		// [XID] // 0x0000000189621DE0-0x0000000189621E00
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018882AB90-0x000000018882AE50
		[BlackList] // 0x0000000189629750-0x0000000189629790
		// [XID] // 0x0000000189629750-0x0000000189629790
		public virtual void AutoAllocTypeFields() {} // 0x0000000188829D20-0x0000000188829DC0
		[BlackList] // 0x0000000189633F90-0x0000000189633FD0
		// [XID] // 0x0000000189633F90-0x0000000189633FD0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188829DC0-0x0000000188829E60
		[BlackList] // 0x000000018963E6C0-0x000000018963E700
		// [XID] // 0x000000018963E6C0-0x000000018963E700
		public virtual void ReturnToObjectPool() {} // 0x000000018882B0B0-0x000000018882B150
		[BlackList] // 0x0000000189648F00-0x0000000189648F40
		// [XID] // 0x0000000189648F00-0x0000000189648F40
		public virtual void OnPoolAllocated() {} // 0x000000018882B010-0x000000018882B0B0
		[BlackList] // 0x0000000189653580-0x00000001896535C0
		// [XID] // 0x0000000189653580-0x00000001896535C0
		public virtual void OnBeforePoolRecycled() {} // 0x000000018882AF70-0x000000018882B010
	}
}
