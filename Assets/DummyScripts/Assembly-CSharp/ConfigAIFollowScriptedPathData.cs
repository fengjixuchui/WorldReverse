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
public class ConfigAIFollowScriptedPathData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17422
{
	// Fields
	private SimpleSafeFloat turnSpeedOverrideWalkRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRunRawNum; // 0x14
	private bool _spacial; // 0x18
	private bool _spacialRoll; // 0x19

	// Properties
	public float turnSpeedOverrideWalk { /* [XID] */ /* 0x0000000189BB9A00-0x0000000189BB9A20 */ get => default; /* [XID] */ /* 0x0000000189BC19A0-0x0000000189BC19C0 */ private set {} } // 0x00000001829DBC10-0x00000001829DBCF0 0x00000001829DC0F0-0x00000001829DC1D0
	public float turnSpeedOverrideRun { /* [XID] */ /* 0x0000000189BC8FE0-0x0000000189BC9000 */ get => default; /* [XID] */ /* 0x0000000189BD0890-0x0000000189BD08B0 */ private set {} } // 0x00000001829DAE50-0x00000001829DAF30 0x00000001829DB750-0x00000001829DB830
	public bool spacial { /* [XID] */ /* 0x0000000189BD7D90-0x0000000189BD7DB0 */ get => default; /* [XID] */ /* 0x0000000189BDF9C0-0x0000000189BDF9E0 */ private set {} } // 0x00000001829DB6B0-0x00000001829DB750 0x00000001829DB280-0x00000001829DB330
	public bool spacialRoll { /* [XID] */ /* 0x00000001895EC4F0-0x00000001895EC510 */ get => default; /* [XID] */ /* 0x00000001895F3970-0x00000001895F3990 */ private set {} } // 0x00000001829DA4D0-0x00000001829DA570 0x00000001829DBCF0-0x00000001829DBDA0

	// Constructors
	public ConfigAIFollowScriptedPathData() {} // 0x00000001829DC4F0-0x00000001829DC5A0

	// Methods
	// [XID] // 0x00000001895FB290-0x00000001895FB2B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829DC1D0-0x00000001829DC310
	// [XID] // 0x0000000189602A30-0x0000000189602A50
	public void InitEmpty() {} // 0x00000001829DB830-0x00000001829DB910
	[BlackList] // 0x000000018960A330-0x000000018960A370
	// [XID] // 0x000000018960A330-0x000000018960A370
	public bool FromJson(JSONNode node) => default; // 0x00000001829DB330-0x00000001829DB6B0
	// [XID] // 0x00000001896149A0-0x00000001896149C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001829DA570-0x00000001829DA9F0
	// [XID] // 0x000000018961C300-0x000000018961C320
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E15 */, bool useObjectPool = false /* Metadata: 0x00AF6E19 */) => default; // 0x00000001829DB910-0x00000001829DBC10
	// [XID] // 0x0000000189623720-0x0000000189623740
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E1A */, bool useObjectPool = false /* Metadata: 0x00AF6E1E */) => default; // 0x00000001829DAF30-0x00000001829DB280
	[BlackList] // 0x000000018962B080-0x000000018962B0C0
	// [XID] // 0x000000018962B080-0x000000018962B0C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001829DA9F0-0x00000001829DACC0
	// [XID] // 0x0000000189635C70-0x0000000189635C90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829DBDA0-0x00000001829DC0F0
	[BlackList] // 0x000000018963D390-0x000000018963D3D0
	// [XID] // 0x000000018963D390-0x000000018963D3D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001829DACC0-0x00000001829DAD60
	[BlackList] // 0x00000001896478B0-0x00000001896478F0
	// [XID] // 0x00000001896478B0-0x00000001896478F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829DAD60-0x00000001829DAE50
	[BlackList] // 0x0000000189652080-0x00000001896520C0
	// [XID] // 0x0000000189652080-0x00000001896520C0
	public virtual void ReturnToObjectPool() {} // 0x00000001829DC450-0x00000001829DC4F0
	[BlackList] // 0x000000018965C8C0-0x000000018965C900
	// [XID] // 0x000000018965C8C0-0x000000018965C900
	public virtual void OnPoolAllocated() {} // 0x00000001829DC3B0-0x00000001829DC450
	[BlackList] // 0x0000000189667010-0x0000000189667050
	// [XID] // 0x0000000189667010-0x0000000189667050
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829DC310-0x00000001829DC3B0
}

