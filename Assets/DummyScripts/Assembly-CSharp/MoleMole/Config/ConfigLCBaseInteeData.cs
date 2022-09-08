/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigLCBaseInteeData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18449
	{
		// Fields
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		private Dictionary<string, ConfigLCBaseIntee> _configDic; // 0x10
	
		// Properties
		public Dictionary<string, ConfigLCBaseIntee> configDic { /* [XID] */ /* 0x00000001897C2640-0x00000001897C2660 */ get => default; /* [XID] */ /* 0x000000018988D340-0x000000018988D360 */ private set {} } // 0x000000018882CCF0-0x000000018882CD90 0x000000018882CD90-0x000000018882CE40
	
		// Constructors
		public ConfigLCBaseInteeData() {} // 0x000000018882CC90-0x000000018882CCF0
	
		// Methods
		// [XID] // 0x00000001898949F0-0x0000000189894A10
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018882C700-0x000000018882C7E0
		// [XID] // 0x000000018989BEC0-0x000000018989BEE0
		public void InitEmpty() {} // 0x000000018882C050-0x000000018882C120
		[BlackList] // 0x00000001898A3560-0x00000001898A35A0
		// [XID] // 0x00000001898A3560-0x00000001898A35A0
		public bool FromJson(JSONNode node) => default; // 0x000000018882BCD0-0x000000018882C050
		// [XID] // 0x00000001898ADE30-0x00000001898ADE50
		private bool InternalFromJson(JSONNode node) => default; // 0x000000018882C330-0x000000018882C510
		// [XID] // 0x00000001898B5290-0x00000001898B52B0
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98D9 */, bool useObjectPool = false /* Metadata: 0x00AF98DD */) => default; // 0x000000018882B9D0-0x000000018882BCD0
		// [XID] // 0x00000001898BCD60-0x00000001898BCD80
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98DE */, bool useObjectPool = false /* Metadata: 0x00AF98E2 */) => default; // 0x000000018882C120-0x000000018882C330
		[BlackList] // 0x00000001898C4480-0x00000001898C44C0
		// [XID] // 0x00000001898C4480-0x00000001898C44C0
		public bool ToBinary(ByteArray byteArray) => default; // 0x000000018882C9C0-0x000000018882CC90
		// [XID] // 0x00000001898CEAF0-0x00000001898CEB10
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018882C510-0x000000018882C700
		[BlackList] // 0x00000001898D6440-0x00000001898D6480
		// [XID] // 0x00000001898D6440-0x00000001898D6480
		public virtual void AutoAllocTypeFields() {} // 0x000000018882B870-0x000000018882B910
		[BlackList] // 0x00000001898E1120-0x00000001898E1160
		// [XID] // 0x00000001898E1120-0x00000001898E1160
		public virtual void AutoRecycleTypeFields() {} // 0x000000018882B910-0x000000018882B9D0
		[BlackList] // 0x00000001898EBB50-0x00000001898EBB90
		// [XID] // 0x00000001898EBB50-0x00000001898EBB90
		public virtual void ReturnToObjectPool() {} // 0x000000018882C920-0x000000018882C9C0
		[BlackList] // 0x00000001898F64A0-0x00000001898F64E0
		// [XID] // 0x00000001898F64A0-0x00000001898F64E0
		public virtual void OnPoolAllocated() {} // 0x000000018882C880-0x000000018882C920
		[BlackList] // 0x0000000189900E10-0x0000000189900E50
		// [XID] // 0x0000000189900E10-0x0000000189900E50
		public virtual void OnBeforePoolRecycled() {} // 0x000000018882C7E0-0x000000018882C880
	}
}
