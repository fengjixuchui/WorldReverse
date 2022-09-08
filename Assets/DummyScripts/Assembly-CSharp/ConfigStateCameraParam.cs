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
public class ConfigStateCameraParam : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17898
{
	// Fields
	private SimpleSafeFloat radiusSpringRatioRawNum; // 0x10
	private SimpleSafeFloat combatElevWithHeightRatioRawNum; // 0x14
	private SimpleSafeFloat forceRadiusRawNum; // 0x18
	private SimpleSafeFloat forceRadiusDurationRawNum; // 0x1C
	private bool _shouldKeepForceRadius; // 0x20

	// Properties
	public float radiusSpringRatio { /* [XID] */ /* 0x00000001898CF740-0x00000001898CF760 */ get => default; /* [XID] */ /* 0x0000000189B353C0-0x0000000189B353E0 */ private set {} } // 0x0000000183B39E50-0x0000000183B39F30 0x0000000183B3A550-0x0000000183B3A630
	public float combatElevWithHeightRatio { /* [XID] */ /* 0x0000000189947D10-0x0000000189947D30 */ get => default; /* [XID] */ /* 0x0000000189B449F0-0x0000000189B44A10 */ private set {} } // 0x0000000183B3AA30-0x0000000183B3AB10 0x0000000183B3A010-0x0000000183B3A0F0
	public float forceRadius { /* [XID] */ /* 0x000000018990C020-0x000000018990C040 */ get => default; /* [XID] */ /* 0x0000000189B53860-0x0000000189B53880 */ private set {} } // 0x0000000183B3B240-0x0000000183B3B320 0x0000000183B39760-0x0000000183B39840
	public float forceRadiusDuration { /* [XID] */ /* 0x0000000189B5B0D0-0x0000000189B5B0F0 */ get => default; /* [XID] */ /* 0x0000000189B62570-0x0000000189B62590 */ private set {} } // 0x0000000183B3A470-0x0000000183B3A550 0x0000000183B39F30-0x0000000183B3A010
	public bool shouldKeepForceRadius { /* [XID] */ /* 0x0000000189B6A130-0x0000000189B6A150 */ get => default; /* [XID] */ /* 0x0000000189B71810-0x0000000189B71830 */ private set {} } // 0x0000000183B399E0-0x0000000183B39A80 0x0000000183B3AB10-0x0000000183B3ABC0

	// Constructors
	public ConfigStateCameraParam() {} // 0x0000000183B3B3C0-0x0000000183B3B490

	// Methods
	// [XID] // 0x0000000189B78D00-0x0000000189B78D20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B3AFA0-0x0000000183B3B100
	// [XID] // 0x0000000189B801F0-0x0000000189B80210
	public void InitEmpty() {} // 0x0000000183B3A630-0x0000000183B3A730
	[BlackList] // 0x0000000189B87C80-0x0000000189B87CC0
	// [XID] // 0x0000000189B87C80-0x0000000189B87CC0
	public bool FromJson(JSONNode node) => default; // 0x0000000183B3A0F0-0x0000000183B3A470
	// [XID] // 0x0000000189B91EA0-0x0000000189B91EC0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B38EC0-0x0000000183B39490
	// [XID] // 0x0000000189B99340-0x0000000189B99360
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8099 */, bool useObjectPool = false /* Metadata: 0x00AF809D */) => default; // 0x0000000183B3A730-0x0000000183B3AA30
	// [XID] // 0x0000000189BA0870-0x0000000189BA0890
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF809E */, bool useObjectPool = false /* Metadata: 0x00AF80A2 */) => default; // 0x0000000183B39A80-0x0000000183B39E50
	[BlackList] // 0x0000000189BA7FB0-0x0000000189BA7FF0
	// [XID] // 0x0000000189BA7FB0-0x0000000189BA7FF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B39490-0x0000000183B39760
	// [XID] // 0x0000000189BB24F0-0x0000000189BB2510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B3ABC0-0x0000000183B3AFA0
	[BlackList] // 0x0000000189BB9920-0x0000000189BB9960
	// [XID] // 0x0000000189BB9920-0x0000000189BB9960
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B39840-0x0000000183B398E0
	[BlackList] // 0x0000000189BC4700-0x0000000189BC4740
	// [XID] // 0x0000000189BC4700-0x0000000189BC4740
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B398E0-0x0000000183B399E0
	[BlackList] // 0x0000000189BCF1F0-0x0000000189BCF230
	// [XID] // 0x0000000189BCF1F0-0x0000000189BCF230
	public virtual void ReturnToObjectPool() {} // 0x0000000183B3B320-0x0000000183B3B3C0
	[BlackList] // 0x0000000189BD9680-0x0000000189BD96C0
	// [XID] // 0x0000000189BD9680-0x0000000189BD96C0
	public virtual void OnPoolAllocated() {} // 0x0000000183B3B1A0-0x0000000183B3B240
	[BlackList] // 0x00000001895E9190-0x00000001895E91D0
	// [XID] // 0x00000001895E9190-0x00000001895E91D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B3B100-0x0000000183B3B1A0
}

