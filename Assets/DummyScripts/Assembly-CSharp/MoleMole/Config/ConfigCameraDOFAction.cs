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
	public class ConfigCameraDOFAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18419
	{
		// Fields
		private bool _enabled; // 0x30
		private float _focusDistance; // 0x34
		private float _focusRange; // 0x38
		private float _nearFocalDistance; // 0x3C
		private float _nearFocalTransDistance; // 0x40
		private float _dofBlurAmount; // 0x44
		private uint _quality; // 0x48
	
		// Properties
		public bool enabled { /* [XID] */ /* 0x0000000189750B00-0x0000000189750B20 */ get => default; /* [XID] */ /* 0x0000000189757ED0-0x0000000189757EF0 */ private set {} } // 0x0000000187E05DD0-0x0000000187E05E70 0x0000000187E06280-0x0000000187E06330
		public float focusDistance { /* [XID] */ /* 0x000000018975FA70-0x000000018975FA90 */ get => default; /* [XID] */ /* 0x0000000189766FC0-0x0000000189766FE0 */ private set {} } // 0x0000000187E05E70-0x0000000187E05F20 0x0000000187E06330-0x0000000187E063E0
		public float focusRange { /* [XID] */ /* 0x000000018976E500-0x000000018976E520 */ get => default; /* [XID] */ /* 0x0000000189775E80-0x0000000189775EA0 */ private set {} } // 0x0000000187E05F20-0x0000000187E05FD0 0x0000000187E063E0-0x0000000187E06490
		public float nearFocalDistance { /* [XID] */ /* 0x000000018977D560-0x000000018977D580 */ get => default; /* [XID] */ /* 0x0000000189784E60-0x0000000189784E80 */ private set {} } // 0x0000000187E05FD0-0x0000000187E06080 0x0000000187E06490-0x0000000187E06540
		public float nearFocalTransDistance { /* [XID] */ /* 0x000000018978C370-0x000000018978C390 */ get => default; /* [XID] */ /* 0x00000001897938E0-0x0000000189793900 */ private set {} } // 0x0000000187E06080-0x0000000187E06130 0x0000000187E06540-0x0000000187E065F0
		public float dofBlurAmount { /* [XID] */ /* 0x000000018979BB70-0x000000018979BB90 */ get => default; /* [XID] */ /* 0x00000001897A3020-0x00000001897A3040 */ private set {} } // 0x0000000187E05D20-0x0000000187E05DD0 0x0000000187E061D0-0x0000000187E06280
		public uint quality { /* [XID] */ /* 0x00000001897AA620-0x00000001897AA640 */ get => default; /* [XID] */ /* 0x00000001897B2110-0x00000001897B2130 */ private set {} } // 0x0000000187E06130-0x0000000187E061D0 0x0000000187E065F0-0x0000000187E066A0
	
		// Constructors
		public ConfigCameraDOFAction() {} // 0x0000000187E05C70-0x0000000187E05D20
	
		// Methods
		// [XID] // 0x00000001897B9AB0-0x00000001897B9AD0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187E04C70-0x0000000187E04E10
		// [XID] // 0x00000001897C1B50-0x00000001897C1B70
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187E03340-0x0000000187E033F0
		// [XID] // 0x00000001897C9520-0x00000001897C9540
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF97D9 */) => default; // 0x0000000187E03260-0x0000000187E03340
		// [XID] // 0x00000001897D0B10-0x00000001897D0B30
		public override int GetHashNum() => default; // 0x0000000187E03A70-0x0000000187E03B40
		// [XID] // 0x00000001897D88F0-0x00000001897D8910
		public override void InitEmpty() {} // 0x0000000187E03B40-0x0000000187E03BE0
		[BlackList] // 0x00000001897DF9B0-0x00000001897DF9F0
		// [XID] // 0x00000001897DF9B0-0x00000001897DF9F0
		public override bool FromJson(JSONNode node) => default; // 0x0000000187E036F0-0x0000000187E03A70
		// [XID] // 0x00000001897EA360-0x00000001897EA380
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000187E040F0-0x0000000187E04740
		[BlackList] // 0x00000001897F2050-0x00000001897F2090
		// [XID] // 0x00000001897F2050-0x00000001897F2090
		public static new ConfigCameraDOFAction ParseFromJson(JSONNode node) => default; // 0x0000000187E05030-0x0000000187E05280
		// [XID] // 0x00000001897FC900-0x00000001897FC920
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97DA */, bool useObjectPool = false /* Metadata: 0x00AF97DE */) => default; // 0x0000000187E033F0-0x0000000187E036F0
		// [XID] // 0x0000000189803E30-0x0000000189803E50
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97DF */, bool useObjectPool = false /* Metadata: 0x00AF97E3 */) => default; // 0x0000000187E03BE0-0x0000000187E040F0
		// [XID] // 0x000000018980B2C0-0x000000018980B2E0
		public static new ConfigCameraDOFAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97E4 */, bool useObjectPool = false /* Metadata: 0x00AF97E8 */) => default; // 0x0000000187E04E10-0x0000000187E05030
		[BlackList] // 0x00000001898129E0-0x0000000189812A20
		// [XID] // 0x00000001898129E0-0x0000000189812A20
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000187E05410-0x0000000187E056E0
		// [XID] // 0x000000018981D530-0x000000018981D550
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187E04740-0x0000000187E04C70
		[BlackList] // 0x00000001898249E0-0x0000000189824A20
		// [XID] // 0x00000001898249E0-0x0000000189824A20
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187E05320-0x0000000187E05410
		[BlackList] // 0x000000018982EF60-0x000000018982EFA0
		// [XID] // 0x000000018982EF60-0x000000018982EFA0
		public override void AutoAllocTypeFields() {} // 0x0000000187E03100-0x0000000187E031A0
		[BlackList] // 0x0000000189839660-0x00000001898396A0
		// [XID] // 0x0000000189839660-0x00000001898396A0
		public override void AutoRecycleTypeFields() {} // 0x0000000187E031A0-0x0000000187E03260
		[BlackList] // 0x0000000189843D40-0x0000000189843D80
		// [XID] // 0x0000000189843D40-0x0000000189843D80
		public override void ReturnToObjectPool() {} // 0x0000000187E05280-0x0000000187E05320
	}
}
