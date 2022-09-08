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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DungeonWayPoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14978
{
	// Fields
	private MoleMole.Config.Vector _size; // 0x60
	private bool _isBoss; // 0x6C
	private bool _isActive; // 0x6D
	private SimpleSafeUInt32[] _groupIds; // 0x70

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189833EE0-0x0000000189833F00 */ get => default; } // 0x0000000182013C50-0x0000000182013CF0 
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x000000018983B340-0x000000018983B360 */ get => default; /* [XID] */ /* 0x0000000189842C00-0x0000000189842C20 */ private set {} } // 0x0000000182014760-0x0000000182014840 0x00000001820137A0-0x0000000182013870
	public bool isBoss { /* [XID] */ /* 0x000000018984A030-0x000000018984A050 */ get => default; /* [XID] */ /* 0x0000000189851650-0x0000000189851670 */ private set {} } // 0x0000000182013320-0x00000001820133C0 0x0000000182013600-0x00000001820136B0
	public bool isActive { /* [XID] */ /* 0x0000000189858C20-0x0000000189858C40 */ get => default; /* [XID] */ /* 0x000000018985FE30-0x000000018985FE50 */ private set {} } // 0x00000001820146C0-0x0000000182014760 0x0000000182012C50-0x0000000182012D00
	public SimpleSafeUInt32[] groupIds { /* [XID] */ /* 0x00000001898674D0-0x00000001898674F0 */ get => default; /* [XID] */ /* 0x000000018986EC70-0x000000018986EC90 */ private set {} } // 0x0000000182014150-0x00000001820141F0 0x0000000182014610-0x00000001820146C0

	// Constructors
	public DungeonWayPoint() {} // 0x0000000182014A50-0x0000000182014AB0

	// Methods
	// [XID] // 0x0000000189876160-0x0000000189876180
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182014840-0x00000001820149B0
	// [XID] // 0x000000018987DCE0-0x000000018987DD00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182014000-0x00000001820140E0
	// [XID] // 0x0000000189884CB0-0x0000000189884CD0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD48 */) => default; // 0x0000000182013B70-0x0000000182013C50
	// [XID] // 0x000000018988C300-0x000000018988C320
	public override int GetHashNum() => default; // 0x0000000182012630-0x0000000182012700
	// [XID] // 0x0000000189893890-0x00000001898938B0
	public override void InitEmpty() {} // 0x0000000182013430-0x0000000182013520
	[BlackList] // 0x000000018989AFD0-0x000000018989B010
	// [XID] // 0x000000018989AFD0-0x000000018989B010
	public override bool FromJson(JSONNode node) => default; // 0x0000000182012D80-0x0000000182013100
	// [XID] // 0x00000001898A5620-0x00000001898A5640
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182011C50-0x00000001820120D0
	[BlackList] // 0x00000001898ACB80-0x00000001898ACBC0
	// [XID] // 0x00000001898ACB80-0x00000001898ACBC0
	public static new DungeonWayPoint ParseFromJson(JSONNode node) => default; // 0x0000000182013D50-0x0000000182013FA0
	// [XID] // 0x00000001898B7190-0x00000001898B71B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD49 */, bool useObjectPool = false /* Metadata: 0x00AEFD4D */) => default; // 0x0000000182013870-0x0000000182013B70
	// [XID] // 0x00000001898BE8C0-0x00000001898BE8E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD4E */, bool useObjectPool = false /* Metadata: 0x00AEFD52 */) => default; // 0x00000001820127E0-0x0000000182012BD0
	// [XID] // 0x00000001898C6090-0x00000001898C60B0
	public static new DungeonWayPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD53 */, bool useObjectPool = false /* Metadata: 0x00AEFD57 */) => default; // 0x0000000182013100-0x0000000182013320
	[BlackList] // 0x00000001898CD820-0x00000001898CD860
	// [XID] // 0x00000001898CD820-0x00000001898CD860
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001820120D0-0x00000001820123A0
	// [XID] // 0x00000001898D81C0-0x00000001898D81E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820141F0-0x0000000182014610
	[BlackList] // 0x00000001898E0040-0x00000001898E0080
	// [XID] // 0x00000001898E0040-0x00000001898E0080
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820136B0-0x00000001820137A0
	[BlackList] // 0x00000001898EAB30-0x00000001898EAB70
	// [XID] // 0x00000001898EAB30-0x00000001898EAB70
	public override void AutoAllocTypeFields() {} // 0x00000001820123A0-0x0000000182012440
	[BlackList] // 0x00000001898F5240-0x00000001898F5280
	// [XID] // 0x00000001898F5240-0x00000001898F5280
	public override void AutoRecycleTypeFields() {} // 0x0000000182012440-0x0000000182012510
	[BlackList] // 0x00000001898FFAB0-0x00000001898FFAF0
	// [XID] // 0x00000001898FFAB0-0x00000001898FFAF0
	public override void ReturnToObjectPool() {} // 0x00000001820149B0-0x0000000182014A50
}

