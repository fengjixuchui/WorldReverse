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
	[LuaCallCSharp] // 0x00000001895F3770-0x00000001895F37B0
	[RecycleType] // 0x00000001895F3770-0x00000001895F37B0
	public class ConfigRoute : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18508
	{
		// Fields
		private uint _localId; // 0x10
		private string _name; // 0x18
		private RouteType _type; // 0x20
		private bool _isForward; // 0x24
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		private ConfigWaypoint[] _points; // 0x28
		private RotType _rotType; // 0x30
		private RotAngleType _rotAngleType; // 0x34
		private float _arriveRange; // 0x38
	
		// Properties
		public uint localId { /* [XID] */ /* 0x00000001896FC550-0x00000001896FC570 */ get => default; /* [XID] */ /* 0x000000018960D0A0-0x000000018960D0C0 */ set {} } // 0x000000018921CC70-0x000000018921CD10 0x000000018921D190-0x000000018921D240
		public string name { /* [XID] */ /* 0x0000000189614700-0x0000000189614720 */ get => default; /* [XID] */ /* 0x000000018961C010-0x000000018961C030 */ set {} } // 0x000000018921CD10-0x000000018921CDB0 0x000000018921D240-0x000000018921D2F0
		public RouteType type { /* [XID] */ /* 0x0000000189623560-0x0000000189623580 */ get => default; /* [XID] */ /* 0x000000018962AE20-0x000000018962AE40 */ set {} } // 0x000000018921CF90-0x000000018921D030 0x000000018921D500-0x000000018921D5B0
		public bool isForward { /* [XID] */ /* 0x0000000189632500-0x0000000189632520 */ get => default; /* [XID] */ /* 0x0000000189639FB0-0x0000000189639FD0 */ set {} } // 0x000000018921CBD0-0x000000018921CC70 0x000000018921D0E0-0x000000018921D190
		public ConfigWaypoint[] points { /* [XID] */ /* 0x0000000189848B20-0x0000000189848B40 */ get => default; /* [XID] */ /* 0x0000000189648EC0-0x0000000189648EE0 */ set {} } // 0x000000018921CDB0-0x000000018921CE50 0x000000018921D2F0-0x000000018921D3A0
		public RotType rotType { /* [XID] */ /* 0x00000001896504F0-0x0000000189650510 */ get => default; /* [XID] */ /* 0x0000000189657E30-0x0000000189657E50 */ set {} } // 0x000000018921CEF0-0x000000018921CF90 0x000000018921D450-0x000000018921D500
		public RotAngleType rotAngleType { /* [XID] */ /* 0x000000018965F460-0x000000018965F480 */ get => default; /* [XID] */ /* 0x0000000189666D70-0x0000000189666D90 */ set {} } // 0x000000018921CE50-0x000000018921CEF0 0x000000018921D3A0-0x000000018921D450
		public float arriveRange { /* [XID] */ /* 0x0000000189892400-0x0000000189892420 */ get => default; /* [XID] */ /* 0x0000000189676180-0x00000001896761A0 */ set {} } // 0x000000018921CB20-0x000000018921CBD0 0x000000018921D030-0x000000018921D0E0
	
		// Constructors
		public ConfigRoute() {} // 0x000000018921CAB0-0x000000018921CB20
	
		// Methods
		// [XID] // 0x000000018967DA00-0x000000018967DA20
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018921C550-0x000000018921C600
		// [XID] // 0x0000000189685060-0x0000000189685080
		public void InitEmpty() {} // 0x000000018921B1F0-0x000000018921B2D0
		[BlackList] // 0x000000018968CB20-0x000000018968CB60
		// [XID] // 0x000000018968CB20-0x000000018968CB60
		public bool FromJson(JSONNode node) => default; // 0x000000018921AE70-0x000000018921B1F0
		// [XID] // 0x0000000189697840-0x0000000189697860
		private bool InternalFromJson(JSONNode node) => default; // 0x000000018921B860-0x000000018921BFC0
		// [XID] // 0x000000018969EC90-0x000000018969ECB0
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FCD */, bool useObjectPool = false /* Metadata: 0x00AF9FD1 */) => default; // 0x000000018921AB70-0x000000018921AE70
		// [XID] // 0x00000001896A5F70-0x00000001896A5F90
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FD2 */, bool useObjectPool = false /* Metadata: 0x00AF9FD6 */) => default; // 0x000000018921B2D0-0x000000018921B860
		[BlackList] // 0x00000001896AD430-0x00000001896AD470
		// [XID] // 0x00000001896AD430-0x00000001896AD470
		public bool ToBinary(ByteArray byteArray) => default; // 0x000000018921C7E0-0x000000018921CAB0
		// [XID] // 0x00000001896B7B10-0x00000001896B7B30
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018921BFC0-0x000000018921C550
		[BlackList] // 0x00000001896BEAD0-0x00000001896BEB10
		// [XID] // 0x00000001896BEAD0-0x00000001896BEB10
		public virtual void AutoAllocTypeFields() {} // 0x000000018921AA00-0x000000018921AAA0
		[BlackList] // 0x00000001896C9110-0x00000001896C9150
		// [XID] // 0x00000001896C9110-0x00000001896C9150
		public virtual void AutoRecycleTypeFields() {} // 0x000000018921AAA0-0x000000018921AB70
		[BlackList] // 0x00000001896D3420-0x00000001896D3460
		// [XID] // 0x00000001896D3420-0x00000001896D3460
		public virtual void ReturnToObjectPool() {} // 0x000000018921C740-0x000000018921C7E0
		[BlackList] // 0x00000001896DDE80-0x00000001896DDEC0
		// [XID] // 0x00000001896DDE80-0x00000001896DDEC0
		public virtual void OnPoolAllocated() {} // 0x000000018921C6A0-0x000000018921C740
		[BlackList] // 0x00000001896E8280-0x00000001896E82C0
		// [XID] // 0x00000001896E8280-0x00000001896E82C0
		public virtual void OnBeforePoolRecycled() {} // 0x000000018921C600-0x000000018921C6A0
	}
}
