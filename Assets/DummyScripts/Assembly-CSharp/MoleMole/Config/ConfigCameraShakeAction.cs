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
	public class ConfigCameraShakeAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18409
	{
		// Fields
		private float _shakeRange; // 0x30
		private float _shakeTime; // 0x34
		private float _shakeDinstance; // 0x38
		private Vector _shakeDir; // 0x3C
	
		// Properties
		public float shakeRange { /* [XID] */ /* 0x000000018997FFE0-0x0000000189980000 */ get => default; /* [XID] */ /* 0x0000000189987770-0x0000000189987790 */ private set {} } // 0x0000000188B87BF0-0x0000000188B87CA0 0x0000000188B87ED0-0x0000000188B87F80
		public float shakeTime { /* [XID] */ /* 0x000000018998F3E0-0x000000018998F400 */ get => default; /* [XID] */ /* 0x0000000189996D40-0x0000000189996D60 */ private set {} } // 0x0000000188B87CA0-0x0000000188B87D50 0x0000000188B87F80-0x0000000188B88030
		public float shakeDinstance { /* [XID] */ /* 0x000000018999E990-0x000000018999E9B0 */ get => default; /* [XID] */ /* 0x00000001899A6330-0x00000001899A6350 */ private set {} } // 0x0000000188B87A60-0x0000000188B87B10 0x0000000188B87D50-0x0000000188B87E00
		public Vector shakeDir { /* [XID] */ /* 0x00000001899AD960-0x00000001899AD980 */ get => default; /* [XID] */ /* 0x00000001899B5240-0x00000001899B5260 */ private set {} } // 0x0000000188B87B10-0x0000000188B87BF0 0x0000000188B87E00-0x0000000188B87ED0
	
		// Constructors
		public ConfigCameraShakeAction() {} // 0x0000000188B87A00-0x0000000188B87A60
	
		// Methods
		// [XID] // 0x00000001899BC8F0-0x00000001899BC910
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B86A30-0x0000000188B86BA0
		// [XID] // 0x00000001899C4300-0x00000001899C4320
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B85550-0x0000000188B85600
		// [XID] // 0x00000001899CBA60-0x00000001899CBA80
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9789 */) => default; // 0x0000000188B85470-0x0000000188B85550
		// [XID] // 0x00000001899D2F50-0x00000001899D2F70
		public override int GetHashNum() => default; // 0x0000000188B85C80-0x0000000188B85D50
		// [XID] // 0x00000001899DA560-0x00000001899DA580
		public override void InitEmpty() {} // 0x0000000188B85D50-0x0000000188B85E20
		[BlackList] // 0x00000001899E1F60-0x00000001899E1FA0
		// [XID] // 0x00000001899E1F60-0x00000001899E1FA0
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B85900-0x0000000188B85C80
		// [XID] // 0x00000001899EC450-0x00000001899EC470
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B861E0-0x0000000188B86640
		[BlackList] // 0x00000001899F40B0-0x00000001899F40F0
		// [XID] // 0x00000001899F40B0-0x00000001899F40F0
		public static new ConfigCameraShakeAction ParseFromJson(JSONNode node) => default; // 0x0000000188B86DC0-0x0000000188B87010
		// [XID] // 0x00000001899FE470-0x00000001899FE490
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF978A */, bool useObjectPool = false /* Metadata: 0x00AF978E */) => default; // 0x0000000188B85600-0x0000000188B85900
		// [XID] // 0x0000000189A05D50-0x0000000189A05D70
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF978F */, bool useObjectPool = false /* Metadata: 0x00AF9793 */) => default; // 0x0000000188B85E20-0x0000000188B861E0
		// [XID] // 0x0000000189A0D080-0x0000000189A0D0A0
		public static new ConfigCameraShakeAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9794 */, bool useObjectPool = false /* Metadata: 0x00AF9798 */) => default; // 0x0000000188B86BA0-0x0000000188B86DC0
		[BlackList] // 0x0000000189A14900-0x0000000189A14940
		// [XID] // 0x0000000189A14900-0x0000000189A14940
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B871A0-0x0000000188B87470
		// [XID] // 0x0000000189A1EB30-0x0000000189A1EB50
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B86640-0x0000000188B86A30
		[BlackList] // 0x0000000189A261E0-0x0000000189A26220
		// [XID] // 0x0000000189A261E0-0x0000000189A26220
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B870B0-0x0000000188B871A0
		[BlackList] // 0x0000000189A305B0-0x0000000189A305F0
		// [XID] // 0x0000000189A305B0-0x0000000189A305F0
		public override void AutoAllocTypeFields() {} // 0x0000000188B85310-0x0000000188B853B0
		[BlackList] // 0x0000000189A3AD40-0x0000000189A3AD80
		// [XID] // 0x0000000189A3AD40-0x0000000189A3AD80
		public override void AutoRecycleTypeFields() {} // 0x0000000188B853B0-0x0000000188B85470
		[BlackList] // 0x0000000189A45620-0x0000000189A45660
		// [XID] // 0x0000000189A45620-0x0000000189A45660
		public override void ReturnToObjectPool() {} // 0x0000000188B87010-0x0000000188B870B0
	}
}
