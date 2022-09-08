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
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigEmotionTemplateAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18437
	{
		// Fields
		private uint _emoTemplateID; // 0x30
	
		// Properties
		public uint emoTemplateID { /* [XID] */ /* 0x000000018985DC70-0x000000018985DC90 */ get => default; /* [XID] */ /* 0x00000001898656F0-0x0000000189865710 */ private set {} } // 0x0000000188BA14A0-0x0000000188BA1540 0x0000000188BA1540-0x0000000188BA15F0
	
		// Constructors
		public ConfigEmotionTemplateAction() {} // 0x0000000188BA1440-0x0000000188BA14A0
	
		// Methods
		// [XID] // 0x000000018986CB90-0x000000018986CBB0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188BA04F0-0x0000000188BA05E0
		// [XID] // 0x0000000189874020-0x0000000189874040
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B9F620-0x0000000188B9F6D0
		// [XID] // 0x000000018987BB00-0x000000018987BB20
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9869 */) => default; // 0x0000000188B9F540-0x0000000188B9F620
		// [XID] // 0x0000000189882CF0-0x0000000189882D10
		public override int GetHashNum() => default; // 0x0000000188B9FD50-0x0000000188B9FE20
		// [XID] // 0x000000018988A490-0x000000018988A4B0
		public override void InitEmpty() {} // 0x0000000188B9FE20-0x0000000188B9FEC0
		[BlackList] // 0x00000001898918E0-0x0000000189891920
		// [XID] // 0x00000001898918E0-0x0000000189891920
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B9F9D0-0x0000000188B9FD50
		// [XID] // 0x000000018989BEE0-0x000000018989BF00
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188BA00F0-0x0000000188BA02F0
		[BlackList] // 0x00000001898A35A0-0x00000001898A35E0
		// [XID] // 0x00000001898A35A0-0x00000001898A35E0
		public static new ConfigEmotionTemplateAction ParseFromJson(JSONNode node) => default; // 0x0000000188BA0800-0x0000000188BA0A50
		// [XID] // 0x00000001898ADE50-0x00000001898ADE70
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF986A */, bool useObjectPool = false /* Metadata: 0x00AF986E */) => default; // 0x0000000188B9F6D0-0x0000000188B9F9D0
		// [XID] // 0x00000001898B52B0-0x00000001898B52D0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF986F */, bool useObjectPool = false /* Metadata: 0x00AF9873 */) => default; // 0x0000000188B9FEC0-0x0000000188BA00F0
		// [XID] // 0x00000001898BCD80-0x00000001898BCDA0
		public static new ConfigEmotionTemplateAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9874 */, bool useObjectPool = false /* Metadata: 0x00AF9878 */) => default; // 0x0000000188BA05E0-0x0000000188BA0800
		[BlackList] // 0x00000001898C44C0-0x00000001898C4500
		// [XID] // 0x00000001898C44C0-0x00000001898C4500
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188BA0BE0-0x0000000188BA0EB0
		// [XID] // 0x00000001898CEB10-0x00000001898CEB30
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188BA02F0-0x0000000188BA04F0
		[BlackList] // 0x00000001898D6480-0x00000001898D64C0
		// [XID] // 0x00000001898D6480-0x00000001898D64C0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188BA0AF0-0x0000000188BA0BE0
		[BlackList] // 0x00000001898E1160-0x00000001898E11A0
		// [XID] // 0x00000001898E1160-0x00000001898E11A0
		public override void AutoAllocTypeFields() {} // 0x0000000188B9F3F0-0x0000000188B9F490
		[BlackList] // 0x00000001898EBB90-0x00000001898EBBD0
		// [XID] // 0x00000001898EBB90-0x00000001898EBBD0
		public override void AutoRecycleTypeFields() {} // 0x0000000188B9F490-0x0000000188B9F540
		[BlackList] // 0x00000001898F64E0-0x00000001898F6520
		// [XID] // 0x00000001898F64E0-0x00000001898F6520
		public override void ReturnToObjectPool() {} // 0x0000000188BA0A50-0x0000000188BA0AF0
	}
}
