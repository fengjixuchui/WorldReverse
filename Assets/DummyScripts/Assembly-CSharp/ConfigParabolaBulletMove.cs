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

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigParabolaBulletMove : ConfigBulletMove, IAutoAllocRecycle // TypeDefIndex: 18618
{
	// Fields
	private SimpleSafeFloat angleOffHorRawNum; // 0x58
	private SimpleSafeFloat gravityOfAccelerationRawNum; // 0x5C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveCorrection _correction; // 0x60

	// Properties
	public float angleOffHor { /* [XID] */ /* 0x0000000189989340-0x0000000189989360 */ get => default; /* [XID] */ /* 0x0000000189990B50-0x0000000189990B70 */ private set {} } // 0x0000000184B1A150-0x0000000184B1A230 0x0000000184B19C90-0x0000000184B19D70
	public float gravityOfAcceleration { /* [XID] */ /* 0x00000001899985D0-0x00000001899985F0 */ get => default; /* [XID] */ /* 0x000000018999FE30-0x000000018999FE50 */ private set {} } // 0x0000000184B18BF0-0x0000000184B18CD0 0x0000000184B18430-0x0000000184B18510
	public ConfigMoveCorrection correction { /* [XID] */ /* 0x00000001898A0FF0-0x00000001898A1010 */ get => default; /* [XID] */ /* 0x00000001899AF2B0-0x00000001899AF2D0 */ private set {} } // 0x0000000184B19890-0x0000000184B19930 0x0000000184B195C0-0x0000000184B19670

	// Constructors
	public ConfigParabolaBulletMove() {} // 0x0000000184B1AB50-0x0000000184B1ABB0

	// Methods
	// [XID] // 0x00000001899B6670-0x00000001899B6690
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B1A970-0x0000000184B1AAB0
	// [XID] // 0x00000001899BE250-0x00000001899BE270
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B1A540-0x0000000184B1A620
	// [XID] // 0x00000001899C5A50-0x00000001899C5A70
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA5F5 */) => default; // 0x0000000184B1A070-0x0000000184B1A150
	// [XID] // 0x00000001899CD050-0x00000001899CD070
	public override int GetHashNum() => default; // 0x0000000184B18B20-0x0000000184B18BF0
	// [XID] // 0x00000001899D4630-0x00000001899D4650
	public override void InitEmpty() {} // 0x0000000184B199A0-0x0000000184B19AC0
	[BlackList] // 0x00000001899DBC90-0x00000001899DBCD0
	// [XID] // 0x00000001899DBC90-0x00000001899DBCD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184B19240-0x0000000184B195C0
	// [XID] // 0x00000001899E66B0-0x00000001899E66D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184B17FD0-0x0000000184B18430
	[BlackList] // 0x00000001899EDCE0-0x00000001899EDD20
	// [XID] // 0x00000001899EDCE0-0x00000001899EDD20
	public static new ConfigParabolaBulletMove ParseFromJson(JSONNode node) => default; // 0x0000000184B1A290-0x0000000184B1A4E0
	// [XID] // 0x00000001899F83D0-0x00000001899F83F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5F6 */, bool useObjectPool = false /* Metadata: 0x00AFA5FA */) => default; // 0x0000000184B19D70-0x0000000184B1A070
	// [XID] // 0x00000001899FF9C0-0x00000001899FF9E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5FB */, bool useObjectPool = false /* Metadata: 0x00AFA5FF */) => default; // 0x0000000184B18DB0-0x0000000184B19140
	// [XID] // 0x0000000189A071F0-0x0000000189A07210
	public static new ConfigParabolaBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA600 */, bool useObjectPool = false /* Metadata: 0x00AFA604 */) => default; // 0x0000000184B19670-0x0000000184B19890
	[BlackList] // 0x0000000189A0E750-0x0000000189A0E790
	// [XID] // 0x0000000189A0E750-0x0000000189A0E790
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B18510-0x0000000184B187E0
	// [XID] // 0x0000000189A18C70-0x0000000189A18C90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B1A620-0x0000000184B1A970
	[BlackList] // 0x0000000189A20310-0x0000000189A20350
	// [XID] // 0x0000000189A20310-0x0000000189A20350
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B19BA0-0x0000000184B19C90
	[BlackList] // 0x0000000189A2A7E0-0x0000000189A2A820
	// [XID] // 0x0000000189A2A7E0-0x0000000189A2A820
	public override void AutoAllocTypeFields() {} // 0x0000000184B187E0-0x0000000184B18880
	[BlackList] // 0x0000000189A34F90-0x0000000189A34FD0
	// [XID] // 0x0000000189A34F90-0x0000000189A34FD0
	public override void AutoRecycleTypeFields() {} // 0x0000000184B18880-0x0000000184B18A00
	[BlackList] // 0x0000000189A3F6E0-0x0000000189A3F720
	// [XID] // 0x0000000189A3F6E0-0x0000000189A3F720
	public override void ReturnToObjectPool() {} // 0x0000000184B1AAB0-0x0000000184B1AB50
}

