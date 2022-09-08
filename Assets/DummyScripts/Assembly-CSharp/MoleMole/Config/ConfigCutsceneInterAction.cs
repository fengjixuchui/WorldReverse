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
	public class ConfigCutsceneInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18393
	{
		// Fields
		// [PooledField] // 0x0000000189951E30-0x0000000189951E50
		private ConfigBaseCutscene _cutsceneCfg; // 0x30
		private uint _cutsceneIndex; // 0x38
		private bool _syncLoad; // 0x3C
	
		// Properties
		public ConfigBaseCutscene cutsceneCfg { /* [XID] */ /* 0x0000000189974170-0x0000000189974190 */ get => default; /* [XID] */ /* 0x000000018997B8A0-0x000000018997B8C0 */ private set {} } // 0x0000000188B8A670-0x0000000188B8A710 0x0000000188B8A850-0x0000000188B8A900
		public uint cutsceneIndex { /* [XID] */ /* 0x00000001899833B0-0x00000001899833D0 */ get => default; /* [XID] */ /* 0x000000018998ABC0-0x000000018998ABE0 */ private set {} } // 0x0000000188B8A710-0x0000000188B8A7B0 0x0000000188B8A900-0x0000000188B8A9B0
		public bool syncLoad { /* [XID] */ /* 0x0000000189992470-0x0000000189992490 */ get => default; /* [XID] */ /* 0x000000018999A250-0x000000018999A270 */ private set {} } // 0x0000000188B8A7B0-0x0000000188B8A850 0x0000000188B8A9B0-0x0000000188B8AA60
	
		// Constructors
		public ConfigCutsceneInterAction() {} // 0x0000000188B8A600-0x0000000188B8A670
	
		// Methods
		// [XID] // 0x00000001899A18F0-0x00000001899A1910
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B89660-0x0000000188B897A0
		// [XID] // 0x00000001899A91A0-0x00000001899A91C0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B88350-0x0000000188B88430
		// [XID] // 0x00000001899B0CB0-0x00000001899B0CD0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9719 */) => default; // 0x0000000188B88270-0x0000000188B88350
		// [XID] // 0x00000001899B7F10-0x00000001899B7F30
		public override int GetHashNum() => default; // 0x0000000188B88AB0-0x0000000188B88B80
		// [XID] // 0x00000001899BFB30-0x00000001899BFB50
		public override void InitEmpty() {} // 0x0000000188B88B80-0x0000000188B88C50
		[BlackList] // 0x00000001899C72B0-0x00000001899C72F0
		// [XID] // 0x00000001899C72B0-0x00000001899C72F0
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B88730-0x0000000188B88AB0
		// [XID] // 0x00000001899D18A0-0x00000001899D18C0
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B88F90-0x0000000188B89320
		[BlackList] // 0x00000001899D8E30-0x00000001899D8E70
		// [XID] // 0x00000001899D8E30-0x00000001899D8E70
		public static new ConfigCutsceneInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188B899C0-0x0000000188B89C10
		// [XID] // 0x00000001899E3710-0x00000001899E3730
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF971A */, bool useObjectPool = false /* Metadata: 0x00AF971E */) => default; // 0x0000000188B88430-0x0000000188B88730
		// [XID] // 0x00000001899EAAC0-0x00000001899EAAE0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF971F */, bool useObjectPool = false /* Metadata: 0x00AF9723 */) => default; // 0x0000000188B88C50-0x0000000188B88F90
		// [XID] // 0x00000001899F26A0-0x00000001899F26C0
		public static new ConfigCutsceneInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9724 */, bool useObjectPool = false /* Metadata: 0x00AF9728 */) => default; // 0x0000000188B897A0-0x0000000188B899C0
		[BlackList] // 0x00000001899F9BD0-0x00000001899F9C10
		// [XID] // 0x00000001899F9BD0-0x00000001899F9C10
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B89DA0-0x0000000188B8A070
		// [XID] // 0x0000000189A04150-0x0000000189A04170
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B89320-0x0000000188B89660
		[BlackList] // 0x0000000189A0B890-0x0000000189A0B8D0
		// [XID] // 0x0000000189A0B890-0x0000000189A0B8D0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B89CB0-0x0000000188B89DA0
		[BlackList] // 0x0000000189A15E60-0x0000000189A15EA0
		// [XID] // 0x0000000189A15E60-0x0000000189A15EA0
		public override void AutoAllocTypeFields() {} // 0x0000000188B88090-0x0000000188B88130
		[BlackList] // 0x0000000189A203D0-0x0000000189A20410
		// [XID] // 0x0000000189A203D0-0x0000000189A20410
		public override void AutoRecycleTypeFields() {} // 0x0000000188B88130-0x0000000188B88270
		[BlackList] // 0x0000000189A2A840-0x0000000189A2A880
		// [XID] // 0x0000000189A2A840-0x0000000189A2A880
		public override void ReturnToObjectPool() {} // 0x0000000188B89C10-0x0000000188B89CB0
	}
}
