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
public class ConfigGadgetMisc : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17994
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigChest _chest; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGear _gear; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigConstForceField _forceField; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCrystal _crystal; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSeal _seal; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPickup _pickup; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWindSeed _windSeed; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAutoDool _autoDoor; // 0x48
	private string _escapeEffect; // 0x50
	private bool _guidePoint; // 0x58
	private bool _isUIPoint; // 0x59
	private TargetIndicatorType _guidePointType; // 0x5C
	private SimpleSafeFloat targetIndicatorYOffsetRawNum; // 0x60

	// Properties
	public ConfigChest chest { /* [XID] */ /* 0x000000018983B850-0x000000018983B870 */ get => default; /* [XID] */ /* 0x0000000189AF0010-0x0000000189AF0030 */ private set {} } // 0x0000000181764BD0-0x0000000181764C70 0x00000001817644A0-0x0000000181764550
	public ConfigGear gear { /* [XID] */ /* 0x0000000189AF74A0-0x0000000189AF74C0 */ get => default; /* [XID] */ /* 0x0000000189AFEB50-0x0000000189AFEB70 */ private set {} } // 0x0000000181762950-0x00000001817629F0 0x0000000181765EB0-0x0000000181765F60
	public ConfigConstForceField forceField { /* [XID] */ /* 0x0000000189B062E0-0x0000000189B06300 */ get => default; /* [XID] */ /* 0x0000000189B0DA90-0x0000000189B0DAB0 */ private set {} } // 0x0000000181763130-0x00000001817631D0 0x0000000181765D50-0x0000000181765E00
	public ConfigCrystal crystal { /* [XID] */ /* 0x0000000189B14EB0-0x0000000189B14ED0 */ get => default; /* [XID] */ /* 0x0000000189B1C850-0x0000000189B1C870 */ private set {} } // 0x0000000181761930-0x00000001817619D0 0x0000000181765880-0x0000000181765930
	public ConfigSeal seal { /* [XID] */ /* 0x00000001896CE740-0x00000001896CE760 */ get => default; /* [XID] */ /* 0x0000000189B2B0E0-0x0000000189B2B100 */ private set {} } // 0x0000000181764790-0x0000000181764830 0x0000000181764D50-0x0000000181764E00
	public ConfigPickup pickup { /* [XID] */ /* 0x0000000189B32720-0x0000000189B32740 */ get => default; /* [XID] */ /* 0x0000000189B3A070-0x0000000189B3A090 */ private set {} } // 0x0000000181763DF0-0x0000000181763E90 0x00000001817646E0-0x0000000181764790
	public ConfigWindSeed windSeed { /* [XID] */ /* 0x0000000189ADCFB0-0x0000000189ADCFD0 */ get => default; /* [XID] */ /* 0x0000000189B493E0-0x0000000189B49400 */ private set {} } // 0x0000000181763FE0-0x0000000181764080 0x0000000181763C90-0x0000000181763D40
	public ConfigAutoDool autoDoor { /* [XID] */ /* 0x0000000189675670-0x0000000189675690 */ get => default; /* [XID] */ /* 0x0000000189B582C0-0x0000000189B582E0 */ private set {} } // 0x0000000181762FB0-0x0000000181763050 0x00000001817657D0-0x0000000181765880
	public string escapeEffect { /* [XID] */ /* 0x0000000189B5FBA0-0x0000000189B5FBC0 */ get => default; /* [XID] */ /* 0x0000000189B67260-0x0000000189B67280 */ private set {} } // 0x0000000181764400-0x00000001817644A0 0x0000000181763F30-0x0000000181763FE0
	public bool guidePoint { /* [XID] */ /* 0x0000000189B6E4E0-0x0000000189B6E500 */ get => default; /* [XID] */ /* 0x0000000189B75D10-0x0000000189B75D30 */ private set {} } // 0x0000000181763E90-0x0000000181763F30 0x0000000181762F00-0x0000000181762FB0
	public bool isUIPoint { /* [XID] */ /* 0x0000000189B7D160-0x0000000189B7D180 */ get => default; /* [XID] */ /* 0x0000000189B84F90-0x0000000189B84FB0 */ private set {} } // 0x0000000181764830-0x00000001817648D0 0x0000000181763D40-0x0000000181763DF0
	public TargetIndicatorType guidePointType { /* [XID] */ /* 0x0000000189B8BE00-0x0000000189B8BE20 */ get => default; /* [XID] */ /* 0x0000000189B935F0-0x0000000189B93610 */ private set {} } // 0x0000000181764E00-0x0000000181764EA0 0x0000000181765E00-0x0000000181765EB0
	public float targetIndicatorYOffset { /* [XID] */ /* 0x0000000189B9AB60-0x0000000189B9AB80 */ get => default; /* [XID] */ /* 0x0000000189BA2350-0x0000000189BA2370 */ private set {} } // 0x0000000181764C70-0x0000000181764D50 0x0000000181763050-0x0000000181763130

	// Constructors
	public ConfigGadgetMisc() {} // 0x0000000181766000-0x0000000181766070

	// Methods
	// [XID] // 0x0000000189BA97A0-0x0000000189BA97C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181765930-0x0000000181765C10
	// [XID] // 0x0000000189BB0FB0-0x0000000189BB0FD0
	public void InitEmpty() {} // 0x0000000181764550-0x00000001817646E0
	[BlackList] // 0x0000000189BB8160-0x0000000189BB81A0
	// [XID] // 0x0000000189BB8160-0x0000000189BB81A0
	public bool FromJson(JSONNode node) => default; // 0x0000000181764080-0x0000000181764400
	// [XID] // 0x0000000189BC3130-0x0000000189BC3150
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001817619D0-0x0000000181762680
	// [XID] // 0x0000000189BCA990-0x0000000189BCA9B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8607 */, bool useObjectPool = false /* Metadata: 0x00AF860B */) => default; // 0x00000001817648D0-0x0000000181764BD0
	// [XID] // 0x0000000189BD1FE0-0x0000000189BD2000
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF860C */, bool useObjectPool = false /* Metadata: 0x00AF8610 */) => default; // 0x00000001817631D0-0x0000000181763C90
	[BlackList] // 0x0000000189BD9640-0x0000000189BD9680
	// [XID] // 0x0000000189BD9640-0x0000000189BD9680
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181762680-0x0000000181762950
	// [XID] // 0x00000001895E9130-0x00000001895E9150
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181764EA0-0x00000001817657D0
	[BlackList] // 0x00000001895F0940-0x00000001895F0980
	// [XID] // 0x00000001895F0940-0x00000001895F0980
	public virtual void AutoAllocTypeFields() {} // 0x00000001817629F0-0x0000000181762A90
	[BlackList] // 0x00000001895FB110-0x00000001895FB150
	// [XID] // 0x00000001895FB110-0x00000001895FB150
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181762A90-0x0000000181762F00
	[BlackList] // 0x00000001896057B0-0x00000001896057F0
	// [XID] // 0x00000001896057B0-0x00000001896057F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181765F60-0x0000000181766000
	[BlackList] // 0x00000001896102D0-0x0000000189610310
	// [XID] // 0x00000001896102D0-0x0000000189610310
	public virtual void OnPoolAllocated() {} // 0x0000000181765CB0-0x0000000181765D50
	[BlackList] // 0x000000018961A840-0x000000018961A880
	// [XID] // 0x000000018961A840-0x000000018961A880
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181765C10-0x0000000181765CB0
}

