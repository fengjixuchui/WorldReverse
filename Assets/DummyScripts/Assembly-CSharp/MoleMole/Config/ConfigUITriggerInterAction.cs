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
	public sealed class ConfigUITriggerInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 14938
	{
		// Fields
		private string _contextName; // 0x30
		private string _param; // 0x38
	
		// Properties
		public string contextName { /* [XID] */ /* 0x00000001898AFC90-0x00000001898AFCB0 */ get => default; /* [XID] */ /* 0x00000001898B71B0-0x00000001898B71D0 */ private set {} } // 0x0000000188D46AC0-0x0000000188D46B60 0x0000000188D46C00-0x0000000188D46CB0
		public string param { /* [XID] */ /* 0x00000001898BE920-0x00000001898BE940 */ get => default; /* [XID] */ /* 0x00000001898C60B0-0x00000001898C60D0 */ private set {} } // 0x0000000188D46B60-0x0000000188D46C00 0x0000000188D46CB0-0x0000000188D46D60
	
		// Constructors
		public ConfigUITriggerInterAction(InteractionType type, string contextName, string param) {} // 0x0000000188D46A20-0x0000000188D46AC0
		public ConfigUITriggerInterAction() {} // 0x0000000188D469C0-0x0000000188D46A20
	
		// Methods
		// [XID] // 0x00000001898CD860-0x00000001898CD880
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D45AB0-0x0000000188D45BC0
		// [XID] // 0x00000001898D5390-0x00000001898D53B0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188D448D0-0x0000000188D449D0
		// [XID] // 0x00000001898DCCD0-0x00000001898DCCF0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFAE6 */) => default; // 0x0000000188D447E0-0x0000000188D448D0
		// [XID] // 0x00000001898E46C0-0x00000001898E46E0
		public override int GetHashNum() => default; // 0x0000000188D45050-0x0000000188D45120
		// [XID] // 0x00000001898EC0D0-0x00000001898EC0F0
		public override void InitEmpty() {} // 0x0000000188D45120-0x0000000188D45210
		[BlackList] // 0x00000001898F3900-0x00000001898F3940
		// [XID] // 0x00000001898F3900-0x00000001898F3940
		public override bool FromJson(JSONNode node) => default; // 0x0000000188D44CD0-0x0000000188D45050
		// [XID] // 0x00000001898FE200-0x00000001898FE220
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188D45510-0x0000000188D45820
		[BlackList] // 0x0000000189905AA0-0x0000000189905AE0
		// [XID] // 0x0000000189905AA0-0x0000000189905AE0
		public static new ConfigUITriggerInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188D45DB0-0x0000000188D45FD0
		// [XID] // 0x0000000189910170-0x0000000189910190
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAE7 */, bool useObjectPool = false /* Metadata: 0x00AEFAEB */) => default; // 0x0000000188D449D0-0x0000000188D44CD0
		// [XID] // 0x0000000189917D40-0x0000000189917D60
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAEC */, bool useObjectPool = false /* Metadata: 0x00AEFAF0 */) => default; // 0x0000000188D45210-0x0000000188D45510
		// [XID] // 0x000000018991F300-0x000000018991F320
		public static new ConfigUITriggerInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAF1 */, bool useObjectPool = false /* Metadata: 0x00AEFAF5 */) => default; // 0x0000000188D45BC0-0x0000000188D45DB0
		[BlackList] // 0x0000000189926F20-0x0000000189926F60
		// [XID] // 0x0000000189926F20-0x0000000189926F60
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D46160-0x0000000188D46430
		// [XID] // 0x0000000189931380-0x00000001899313A0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D45820-0x0000000188D45AB0
		[BlackList] // 0x0000000189938850-0x0000000189938890
		// [XID] // 0x0000000189938850-0x0000000189938890
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188D46070-0x0000000188D46160
		[BlackList] // 0x0000000189942EF0-0x0000000189942F30
		// [XID] // 0x0000000189942EF0-0x0000000189942F30
		public override void AutoAllocTypeFields() {} // 0x0000000188D44690-0x0000000188D44730
		[BlackList] // 0x000000018994D750-0x000000018994D790
		// [XID] // 0x000000018994D750-0x000000018994D790
		public override void AutoRecycleTypeFields() {} // 0x0000000188D44730-0x0000000188D447E0
		[BlackList] // 0x0000000189957FE0-0x0000000189958020
		// [XID] // 0x0000000189957FE0-0x0000000189958020
		public override void ReturnToObjectPool() {} // 0x0000000188D45FD0-0x0000000188D46070
	}
}
