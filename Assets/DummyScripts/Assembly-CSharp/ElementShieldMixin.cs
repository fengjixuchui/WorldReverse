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
public class ElementShieldMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16920
{
	// Fields
	private ElementType _elementType; // 0x30
	private string _showDamageText; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldAngle; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldHPRatio; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldHP; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damageRatio; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onShieldBroken; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onShieldSuccess; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onShieldFailed; // 0x70
	private bool _useMutiPlayerFixData; // 0x78

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189B23FE0-0x0000000189B24000 */ get => default; /* [XID] */ /* 0x0000000189B2B430-0x0000000189B2B450 */ private set {} } // 0x0000000183C38260-0x0000000183C38300 0x0000000183C399D0-0x0000000183C39A80
	public string showDamageText { /* [XID] */ /* 0x0000000189B32980-0x0000000189B329A0 */ get => default; /* [XID] */ /* 0x0000000189B3A270-0x0000000189B3A290 */ private set {} } // 0x0000000183C3AA50-0x0000000183C3AAF0 0x0000000183C37660-0x0000000183C37710
	public DynamicFloat shieldAngle { /* [XID] */ /* 0x0000000189B41C30-0x0000000189B41C50 */ get => default; /* [XID] */ /* 0x0000000189B495C0-0x0000000189B495E0 */ private set {} } // 0x0000000183C38E00-0x0000000183C38EA0 0x0000000183C39D70-0x0000000183C39E20
	public DynamicFloat shieldHPRatio { /* [XID] */ /* 0x0000000189B50C40-0x0000000189B50C60 */ get => default; /* [XID] */ /* 0x0000000189B58410-0x0000000189B58430 */ private set {} } // 0x0000000183C38FA0-0x0000000183C39040 0x0000000183C38550-0x0000000183C38600
	public DynamicFloat shieldHP { /* [XID] */ /* 0x0000000189B5FDC0-0x0000000189B5FDE0 */ get => default; /* [XID] */ /* 0x0000000189B67460-0x0000000189B67480 */ private set {} } // 0x0000000183C36410-0x0000000183C364B0 0x0000000183C390F0-0x0000000183C391A0
	public DynamicFloat damageRatio { /* [XID] */ /* 0x0000000189B6E6C0-0x0000000189B6E6E0 */ get => default; /* [XID] */ /* 0x0000000189B75EF0-0x0000000189B75F10 */ private set {} } // 0x0000000183C38380-0x0000000183C38420 0x0000000183C38110-0x0000000183C381C0
	public ConfigAbilityAction[] onShieldBroken { /* [XID] */ /* 0x0000000189B7D400-0x0000000189B7D420 */ get => default; /* [XID] */ /* 0x0000000189B85190-0x0000000189B851B0 */ private set {} } // 0x0000000183C3AAF0-0x0000000183C3AB90 0x0000000183C38D50-0x0000000183C38E00
	public ConfigAbilityAction[] onShieldSuccess { /* [XID] */ /* 0x0000000189B8BFE0-0x0000000189B8C000 */ get => default; /* [XID] */ /* 0x0000000189B93810-0x0000000189B93830 */ private set {} } // 0x0000000183C39A80-0x0000000183C39B20 0x0000000183C39040-0x0000000183C390F0
	public ConfigAbilityAction[] onShieldFailed { /* [XID] */ /* 0x0000000189B9AD00-0x0000000189B9AD20 */ get => default; /* [XID] */ /* 0x0000000189BA25B0-0x0000000189BA25D0 */ private set {} } // 0x0000000183C381C0-0x0000000183C38260 0x0000000183C37710-0x0000000183C377C0
	public bool useMutiPlayerFixData { /* [XID] */ /* 0x0000000189BA9A60-0x0000000189BA9A80 */ get => default; /* [XID] */ /* 0x0000000189BB1270-0x0000000189BB1290 */ private set {} } // 0x0000000183C386A0-0x0000000183C38740 0x0000000183C38420-0x0000000183C384D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018963A390-0x000000018963A3B0 */ get => default; } // 0x0000000183C38600-0x0000000183C386A0 

	// Constructors
	public ElementShieldMixin() {} // 0x0000000183C3AC30-0x0000000183C3ACF0

	// Methods
	// [XID] // 0x0000000189BB83A0-0x0000000189BB83C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C3A810-0x0000000183C3AA50
	// [XID] // 0x0000000189BBFBF0-0x0000000189BBFC10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183C39E80-0x0000000183C3A030
	// [XID] // 0x0000000189BC7700-0x0000000189BC7720
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D95 */) => default; // 0x0000000183C39890-0x0000000183C39970
	// [XID] // 0x0000000189BCF310-0x0000000189BCF330
	public override int GetHashNum() => default; // 0x0000000183C37590-0x0000000183C37660
	// [XID] // 0x0000000189BD6620-0x0000000189BD6640
	public override void InitEmpty() {} // 0x0000000183C391A0-0x0000000183C392E0
	[BlackList] // 0x0000000189BDE240-0x0000000189BDE280
	// [XID] // 0x0000000189BDE240-0x0000000189BDE280
	public override bool FromJson(JSONNode node) => default; // 0x0000000183C38740-0x0000000183C38AC0
	// [XID] // 0x00000001895EDC10-0x00000001895EDC30
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183C364B0-0x0000000183C36E50
	[BlackList] // 0x00000001895F5490-0x00000001895F54D0
	// [XID] // 0x00000001895F5490-0x00000001895F54D0
	public static new ElementShieldMixin ParseFromJson(JSONNode node) => default; // 0x0000000183C39B20-0x0000000183C39D70
	// [XID] // 0x00000001895FF9F0-0x00000001895FFA10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D96 */, bool useObjectPool = false /* Metadata: 0x00AF5D9A */) => default; // 0x0000000183C394B0-0x0000000183C397B0
	// [XID] // 0x00000001896071C0-0x00000001896071E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D9B */, bool useObjectPool = false /* Metadata: 0x00AF5D9F */) => default; // 0x0000000183C378A0-0x0000000183C38110
	// [XID] // 0x000000018960EC20-0x000000018960EC40
	public static new ElementShieldMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DA0 */, bool useObjectPool = false /* Metadata: 0x00AF5DA4 */) => default; // 0x0000000183C38B30-0x0000000183C38D50
	[BlackList] // 0x00000001896161C0-0x0000000189616200
	// [XID] // 0x00000001896161C0-0x0000000189616200
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C36E50-0x0000000183C37120
	// [XID] // 0x0000000189620AA0-0x0000000189620AC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C3A030-0x0000000183C3A810
	[BlackList] // 0x0000000189628010-0x0000000189628050
	// [XID] // 0x0000000189628010-0x0000000189628050
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183C393C0-0x0000000183C394B0
	// [XID] // 0x0000000189632860-0x0000000189632880
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183C397B0-0x0000000183C39890
	[BlackList] // 0x00000001896418C0-0x0000000189641900
	// [XID] // 0x00000001896418C0-0x0000000189641900
	public override void AutoAllocTypeFields() {} // 0x0000000183C37120-0x0000000183C371C0
	[BlackList] // 0x000000018964C210-0x000000018964C250
	// [XID] // 0x000000018964C210-0x000000018964C250
	public override void AutoRecycleTypeFields() {} // 0x0000000183C371C0-0x0000000183C37470
	[BlackList] // 0x0000000189656810-0x0000000189656850
	// [XID] // 0x0000000189656810-0x0000000189656850
	public override void ReturnToObjectPool() {} // 0x0000000183C3AB90-0x0000000183C3AC30
}

