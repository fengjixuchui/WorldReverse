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
	public class ConfigSteerInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 14937
	{
		// Fields
		private DialogSteerType _steerType; // 0x30
		private bool _useAngle; // 0x34
		private Vector _steerDir; // 0x38
		private float _steerAngle; // 0x44
		private bool _useSteerAnim; // 0x48
		private bool _interruptFreestyle; // 0x49
		private bool _forceSteer; // 0x4A
		private string _targetNpcAlias; // 0x50
	
		// Properties
		public DialogSteerType steerType { /* [XID] */ /* 0x0000000189799F50-0x0000000189799F70 */ get => default; /* [XID] */ /* 0x00000001897A1E40-0x00000001897A1E60 */ private set {} } // 0x0000000189232500-0x00000001892325A0 0x0000000189232A60-0x0000000189232B10
		public bool useAngle { /* [XID] */ /* 0x00000001897A9660-0x00000001897A9680 */ get => default; /* [XID] */ /* 0x00000001897B0EC0-0x00000001897B0EE0 */ private set {} } // 0x0000000189232640-0x00000001892326E0 0x0000000189232BC0-0x0000000189232C70
		public Vector steerDir { /* [XID] */ /* 0x00000001897B8B40-0x00000001897B8B60 */ get => default; /* [XID] */ /* 0x00000001897C0B20-0x00000001897C0B40 */ private set {} } // 0x0000000189232420-0x0000000189232500 0x0000000189232990-0x0000000189232A60
		public float steerAngle { /* [XID] */ /* 0x00000001897C8510-0x00000001897C8530 */ get => default; /* [XID] */ /* 0x00000001897CF930-0x00000001897CF950 */ private set {} } // 0x0000000189232370-0x0000000189232420 0x00000001892328E0-0x0000000189232990
		public bool useSteerAnim { /* [XID] */ /* 0x00000001897D7200-0x00000001897D7220 */ get => default; /* [XID] */ /* 0x00000001897DE790-0x00000001897DE7B0 */ private set {} } // 0x00000001892326E0-0x0000000189232780 0x0000000189232C70-0x0000000189232D20
		public bool interruptFreestyle { /* [XID] */ /* 0x00000001897E62B0-0x00000001897E62D0 */ get => default; /* [XID] */ /* 0x00000001897EDD50-0x00000001897EDD70 */ private set {} } // 0x00000001892322D0-0x0000000189232370 0x0000000189232830-0x00000001892328E0
		public bool forceSteer { /* [XID] */ /* 0x00000001897F5450-0x00000001897F5470 */ get => default; /* [XID] */ /* 0x00000001897FCD80-0x00000001897FCDA0 */ private set {} } // 0x0000000189232230-0x00000001892322D0 0x0000000189232780-0x0000000189232830
		public string targetNpcAlias { /* [XID] */ /* 0x0000000189804410-0x0000000189804430 */ get => default; /* [XID] */ /* 0x000000018980B880-0x000000018980B8A0 */ private set {} } // 0x00000001892325A0-0x0000000189232640 0x0000000189232B10-0x0000000189232BC0
	
		// Constructors
		public ConfigSteerInterAction(InteractionType type, float duration, bool useAngle, DialogSteerType steerType, float steerAngle, bool forceSteer) {} // 0x0000000189232150-0x0000000189232230
		public ConfigSteerInterAction() {} // 0x00000001892320E0-0x0000000189232150
	
		// Methods
		// [XID] // 0x0000000189813020-0x0000000189813040
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001892310B0-0x0000000189231280
		// [XID] // 0x000000018981AB40-0x000000018981AB60
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018922F450-0x000000018922F530
		// [XID] // 0x00000001898223D0-0x00000001898223F0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFAD6 */) => default; // 0x000000018922F370-0x000000018922F450
		// [XID] // 0x00000001898298B0-0x00000001898298D0
		public override int GetHashNum() => default; // 0x000000018922FBB0-0x000000018922FC80
		// [XID] // 0x0000000189830E20-0x0000000189830E40
		public override void InitEmpty() {} // 0x000000018922FC80-0x000000018922FD70
		[BlackList] // 0x00000001898385A0-0x00000001898385E0
		// [XID] // 0x00000001898385A0-0x00000001898385E0
		public override bool FromJson(JSONNode node) => default; // 0x000000018922F830-0x000000018922FBB0
		// [XID] // 0x0000000189842C60-0x0000000189842C80
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000189230350-0x0000000189230AB0
		[BlackList] // 0x000000018984A050-0x000000018984A090
		// [XID] // 0x000000018984A050-0x000000018984A090
		public static new ConfigSteerInterAction ParseFromJson(JSONNode node) => default; // 0x00000001892314A0-0x00000001892316F0
		// [XID] // 0x00000001898541A0-0x00000001898541C0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAD7 */, bool useObjectPool = false /* Metadata: 0x00AEFADB */) => default; // 0x000000018922F530-0x000000018922F830
		// [XID] // 0x000000018985BB30-0x000000018985BB50
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFADC */, bool useObjectPool = false /* Metadata: 0x00AEFAE0 */) => default; // 0x000000018922FD70-0x0000000189230350
		// [XID] // 0x0000000189863110-0x0000000189863130
		public static new ConfigSteerInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAE1 */, bool useObjectPool = false /* Metadata: 0x00AEFAE5 */) => default; // 0x0000000189231280-0x00000001892314A0
		[BlackList] // 0x000000018986A640-0x000000018986A680
		// [XID] // 0x000000018986A640-0x000000018986A680
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189231880-0x0000000189231B50
		// [XID] // 0x00000001898746C0-0x00000001898746E0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189230AB0-0x00000001892310B0
		[BlackList] // 0x000000018987C220-0x000000018987C260
		// [XID] // 0x000000018987C220-0x000000018987C260
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189231790-0x0000000189231880
		[BlackList] // 0x00000001898866C0-0x0000000189886700
		// [XID] // 0x00000001898866C0-0x0000000189886700
		public override void AutoAllocTypeFields() {} // 0x000000018922F200-0x000000018922F2A0
		[BlackList] // 0x00000001898908C0-0x0000000189890900
		// [XID] // 0x00000001898908C0-0x0000000189890900
		public override void AutoRecycleTypeFields() {} // 0x000000018922F2A0-0x000000018922F370
		[BlackList] // 0x000000018989B030-0x000000018989B070
		// [XID] // 0x000000018989B030-0x000000018989B070
		public override void ReturnToObjectPool() {} // 0x00000001892316F0-0x0000000189231790
	}
}
