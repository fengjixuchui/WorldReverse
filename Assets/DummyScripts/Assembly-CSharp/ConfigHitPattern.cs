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
public class ConfigHitPattern : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17676
{
	// Fields
	private string _onHitEffectName; // 0x10
	private HitLevel _hitLevel; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _hitImpulseX; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _hitImpulseY; // 0x28
	private string _hitImpulseType; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHitImpulse _overrideHitImpulse; // 0x38
	private RetreatType _retreatType; // 0x40
	private SimpleSafeFloat hitHaltTimeRawNum; // 0x44
	private SimpleSafeFloat hitHaltTimeScaleRawNum; // 0x48
	private bool _canBeDefenceHalt; // 0x4C
	private bool _muteHitText; // 0x4D
	private bool _recurring; // 0x4E

	// Properties
	public string onHitEffectName { /* [XID] */ /* 0x0000000189905FB0-0x0000000189905FD0 */ get => default; /* [XID] */ /* 0x0000000189AC8470-0x0000000189AC8490 */ private set {} } // 0x0000000181E36F10-0x0000000181E36FB0 0x0000000181E363E0-0x0000000181E36490
	public HitLevel hitLevel { /* [XID] */ /* 0x000000018990D960-0x000000018990D980 */ get => default; /* [XID] */ /* 0x0000000189AD7940-0x0000000189AD7960 */ private set {} } // 0x0000000181E36A40-0x0000000181E36AE0 0x0000000181E35090-0x0000000181E35140
	public DynamicFloat hitImpulseX { /* [XID] */ /* 0x0000000189915070-0x0000000189915090 */ get => default; /* [XID] */ /* 0x0000000189AE6BF0-0x0000000189AE6C10 */ private set {} } // 0x0000000181E361B0-0x0000000181E36250 0x0000000181E34FE0-0x0000000181E35090
	public DynamicFloat hitImpulseY { /* [XID] */ /* 0x000000018991CC90-0x000000018991CCB0 */ get => default; /* [XID] */ /* 0x0000000189AF5CF0-0x0000000189AF5D10 */ private set {} } // 0x0000000181E35280-0x0000000181E35320 0x0000000181E36990-0x0000000181E36A40
	public string hitImpulseType { /* [XID] */ /* 0x0000000189924620-0x0000000189924640 */ get => default; /* [XID] */ /* 0x0000000189B04A80-0x0000000189B04AA0 */ private set {} } // 0x0000000181E35C00-0x0000000181E35CA0 0x0000000181E36D10-0x0000000181E36DC0
	public ConfigHitImpulse overrideHitImpulse { /* [XID] */ /* 0x000000018992BA10-0x000000018992BA30 */ get => default; /* [XID] */ /* 0x0000000189B13810-0x0000000189B13830 */ private set {} } // 0x0000000181E351E0-0x0000000181E35280 0x0000000181E35CA0-0x0000000181E35D50
	public RetreatType retreatType { /* [XID] */ /* 0x0000000189950EB0-0x0000000189950ED0 */ get => default; /* [XID] */ /* 0x0000000189B224F0-0x0000000189B22510 */ private set {} } // 0x0000000181E36AE0-0x0000000181E36B80 0x0000000181E36DC0-0x0000000181E36E70
	public float hitHaltTime { /* [XID] */ /* 0x0000000189B29A20-0x0000000189B29A40 */ get => default; /* [XID] */ /* 0x0000000189B31070-0x0000000189B31090 */ private set {} } // 0x0000000181E36B80-0x0000000181E36C60 0x0000000181E36250-0x0000000181E36330
	public float hitHaltTimeScale { /* [XID] */ /* 0x0000000189B386B0-0x0000000189B386D0 */ get => default; /* [XID] */ /* 0x0000000189B40100-0x0000000189B40120 */ private set {} } // 0x0000000181E377C0-0x0000000181E378A0 0x0000000181E35D50-0x0000000181E35E30
	public bool canBeDefenceHalt { /* [XID] */ /* 0x0000000189967640-0x0000000189967660 */ get => default; /* [XID] */ /* 0x0000000189B4F110-0x0000000189B4F130 */ private set {} } // 0x0000000181E36E70-0x0000000181E36F10 0x0000000181E36C60-0x0000000181E36D10
	public bool muteHitText { /* [XID] */ /* 0x000000018996E850-0x000000018996E870 */ get => default; /* [XID] */ /* 0x0000000189B5E340-0x0000000189B5E360 */ private set {} } // 0x0000000181E34C40-0x0000000181E34CE0 0x0000000181E36330-0x0000000181E363E0
	public bool recurring { /* [XID] */ /* 0x0000000189B658A0-0x0000000189B658C0 */ get => default; /* [XID] */ /* 0x0000000189B6CE20-0x0000000189B6CE40 */ private set {} } // 0x0000000181E35140-0x0000000181E351E0 0x0000000181E365E0-0x0000000181E36690

	// Constructors
	public ConfigHitPattern() {} // 0x0000000181E37CD0-0x0000000181E37D70

	// Methods
	// [XID] // 0x0000000189B74610-0x0000000189B74630
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E378A0-0x0000000181E37AF0
	// [XID] // 0x0000000189B7BC10-0x0000000189B7BC30
	public void InitEmpty() {} // 0x0000000181E36490-0x0000000181E365E0
	[BlackList] // 0x0000000189B83540-0x0000000189B83580
	// [XID] // 0x0000000189B83540-0x0000000189B83580
	public bool FromJson(JSONNode node) => default; // 0x0000000181E35E30-0x0000000181E361B0
	// [XID] // 0x0000000189B8D730-0x0000000189B8D750
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181E33DF0-0x0000000181E34970
	// [XID] // 0x0000000189B94D30-0x0000000189B94D50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF774D */, bool useObjectPool = false /* Metadata: 0x00AF7751 */) => default; // 0x0000000181E36690-0x0000000181E36990
	// [XID] // 0x0000000189B9C460-0x0000000189B9C480
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7752 */, bool useObjectPool = false /* Metadata: 0x00AF7756 */) => default; // 0x0000000181E35320-0x0000000181E35C00
	[BlackList] // 0x0000000189BA3A70-0x0000000189BA3AB0
	// [XID] // 0x0000000189BA3A70-0x0000000189BA3AB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E34970-0x0000000181E34C40
	// [XID] // 0x0000000189BADBA0-0x0000000189BADBC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E36FB0-0x0000000181E377C0
	[BlackList] // 0x0000000189BB5330-0x0000000189BB5370
	// [XID] // 0x0000000189BB5330-0x0000000189BB5370
	public virtual void AutoAllocTypeFields() {} // 0x0000000181E34CE0-0x0000000181E34D80
	[BlackList] // 0x0000000189BBF8D0-0x0000000189BBF910
	// [XID] // 0x0000000189BBF8D0-0x0000000189BBF910
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181E34D80-0x0000000181E34FE0
	[BlackList] // 0x0000000189BCA9B0-0x0000000189BCA9F0
	// [XID] // 0x0000000189BCA9B0-0x0000000189BCA9F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181E37C30-0x0000000181E37CD0
	[BlackList] // 0x0000000189BD4D90-0x0000000189BD4DD0
	// [XID] // 0x0000000189BD4D90-0x0000000189BD4DD0
	public virtual void OnPoolAllocated() {} // 0x0000000181E37B90-0x0000000181E37C30
	[BlackList] // 0x0000000189BDF8E0-0x0000000189BDF920
	// [XID] // 0x0000000189BDF8E0-0x0000000189BDF920
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181E37AF0-0x0000000181E37B90
}

