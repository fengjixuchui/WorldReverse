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
public class ConfigEnvironmentZone : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18939
{
	// Fields
	private SimpleSafeUInt32 areaIdRawNum; // 0x10
	private EnvironmentType _envType; // 0x14
	private Point2D[] _pointVec; // 0x18
	private SimpleSafeUInt32 animalMaxNumRawNum; // 0x20
	private SimpleSafeUInt32 refreshTimeRawNum; // 0x24
	private SimpleSafeUInt32 indexRawNum; // 0x28
	private EnvZoneEventType[] _eventTypeList; // 0x30
	private SimpleSafeUInt32 taskContentTypeRawNum; // 0x38
	private RandTaskContentType _taskType; // 0x3C
	private SimpleSafeUInt32[] _taskIdList; // 0x40
	private Point2D _center; // 0x48
	private SimpleSafeUInt32 levelRawNum; // 0x50
	private SimpleSafeUInt32 zoneBitTypeRawNum; // 0x54
	private bool _choosePossiblePoint; // 0x58
	private MoleMole.Config.Vector[] _possiblePointVec; // 0x60

	// Properties
	public uint areaId { /* [XID] */ /* 0x000000018970BE10-0x000000018970BE30 */ get => default; /* [XID] */ /* 0x0000000189713720-0x0000000189713740 */ private set {} } // 0x0000000182D75E50-0x0000000182D75F20 0x0000000182D74850-0x0000000182D74930
	public EnvironmentType envType { /* [XID] */ /* 0x000000018971AF00-0x000000018971AF20 */ get => default; /* [XID] */ /* 0x00000001897222C0-0x00000001897222E0 */ private set {} } // 0x0000000182D77E30-0x0000000182D77ED0 0x0000000182D76BB0-0x0000000182D76C60
	public Point2D[] pointVec { /* [XID] */ /* 0x0000000189729A20-0x0000000189729A40 */ get => default; /* [XID] */ /* 0x0000000189731120-0x0000000189731140 */ private set {} } // 0x0000000182D74AE0-0x0000000182D74B80 0x0000000182D767C0-0x0000000182D76870
	public uint animalMaxNum { /* [XID] */ /* 0x0000000189738A30-0x0000000189738A50 */ get => default; /* [XID] */ /* 0x00000001897407C0-0x00000001897407E0 */ private set {} } // 0x0000000182D76E50-0x0000000182D76F20 0x0000000182D757C0-0x0000000182D758A0
	public uint refreshTime { /* [XID] */ /* 0x0000000189747AD0-0x0000000189747AF0 */ get => default; /* [XID] */ /* 0x000000018974F2F0-0x000000018974F310 */ private set {} } // 0x0000000182D74930-0x0000000182D74A00 0x0000000182D76870-0x0000000182D76950
	public uint index { /* [XID] */ /* 0x00000001897569A0-0x00000001897569C0 */ get => default; /* [XID] */ /* 0x000000018975DE30-0x000000018975DE50 */ private set {} } // 0x0000000182D761B0-0x0000000182D76280 0x0000000182D76630-0x0000000182D76710
	public EnvZoneEventType[] eventTypeList { /* [XID] */ /* 0x0000000189765430-0x0000000189765450 */ get => default; /* [XID] */ /* 0x000000018976CE80-0x000000018976CEA0 */ private set {} } // 0x0000000182D745B0-0x0000000182D74650 0x0000000182D75DA0-0x0000000182D75E50
	public uint taskContentType { /* [XID] */ /* 0x00000001897742F0-0x0000000189774310 */ get => default; /* [XID] */ /* 0x000000018977BB60-0x000000018977BB80 */ private set {} } // 0x0000000182D75950-0x0000000182D75A20 0x0000000182D74A00-0x0000000182D74AE0
	public RandTaskContentType taskType { /* [XID] */ /* 0x0000000189783530-0x0000000189783550 */ get => default; /* [XID] */ /* 0x000000018978ABE0-0x000000018978AC00 */ private set {} } // 0x0000000182D74B80-0x0000000182D74C20 0x0000000182D76DA0-0x0000000182D76E50
	public SimpleSafeUInt32[] taskIdList { /* [XID] */ /* 0x0000000189792200-0x0000000189792220 */ get => default; /* [XID] */ /* 0x0000000189799790-0x00000001897997B0 */ private set {} } // 0x0000000182D76C60-0x0000000182D76D00 0x0000000182D76710-0x0000000182D767C0
	public Point2D center { /* [XID] */ /* 0x00000001897A15C0-0x00000001897A15E0 */ get => default; /* [XID] */ /* 0x00000001897A8EC0-0x00000001897A8EE0 */ private set {} } // 0x0000000182D76D00-0x0000000182D76DA0 0x0000000182D758A0-0x0000000182D75950
	public uint level { /* [XID] */ /* 0x00000001897B0760-0x00000001897B0780 */ get => default; /* [XID] */ /* 0x00000001897B84E0-0x00000001897B8500 */ private set {} } // 0x0000000182D76A30-0x0000000182D76B00 0x0000000182D76950-0x0000000182D76A30
	public uint zoneBitType { /* [XID] */ /* 0x00000001897C05C0-0x00000001897C05E0 */ get => default; /* [XID] */ /* 0x00000001897C7E50-0x00000001897C7E70 */ private set {} } // 0x0000000182D74C20-0x0000000182D74CF0 0x0000000182D75F20-0x0000000182D76000
	public bool choosePossiblePoint { /* [XID] */ /* 0x00000001897CF170-0x00000001897CF190 */ get => default; /* [XID] */ /* 0x00000001897D6960-0x00000001897D6980 */ private set {} } // 0x0000000182D73290-0x0000000182D73330 0x0000000182D76B00-0x0000000182D76BB0
	public MoleMole.Config.Vector[] possiblePointVec { /* [XID] */ /* 0x00000001897DE150-0x00000001897DE170 */ get => default; /* [XID] */ /* 0x00000001897E5B50-0x00000001897E5B70 */ private set {} } // 0x0000000182D73330-0x0000000182D733D0 0x0000000182D76580-0x0000000182D76630

	// Constructors
	public ConfigEnvironmentZone() {} // 0x0000000182D77F70-0x0000000182D77FD0

	// Methods
	// [XID] // 0x00000001897ED590-0x00000001897ED5B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D77A90-0x0000000182D77CF0
	// [XID] // 0x00000001897F4D50-0x00000001897F4D70
	public void InitEmpty() {} // 0x0000000182D76000-0x0000000182D761B0
	[BlackList] // 0x00000001897FC7E0-0x00000001897FC820
	// [XID] // 0x00000001897FC7E0-0x00000001897FC820
	public bool FromJson(JSONNode node) => default; // 0x0000000182D75A20-0x0000000182D75DA0
	// [XID] // 0x0000000189806C10-0x0000000189806C30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D733D0-0x0000000182D742E0
	// [XID] // 0x000000018980E330-0x000000018980E350
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB44F */, bool useObjectPool = false /* Metadata: 0x00AFB453 */) => default; // 0x0000000182D76280-0x0000000182D76580
	// [XID] // 0x0000000189815A30-0x0000000189815A50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB454 */, bool useObjectPool = false /* Metadata: 0x00AFB458 */) => default; // 0x0000000182D74CF0-0x0000000182D757C0
	[BlackList] // 0x000000018981D430-0x000000018981D470
	// [XID] // 0x000000018981D430-0x000000018981D470
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D742E0-0x0000000182D745B0
	// [XID] // 0x0000000189827BC0-0x0000000189827BE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D76F20-0x0000000182D77A90
	[BlackList] // 0x000000018982EE60-0x000000018982EEA0
	// [XID] // 0x000000018982EE60-0x000000018982EEA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D74650-0x0000000182D746F0
	[BlackList] // 0x00000001898395A0-0x00000001898395E0
	// [XID] // 0x00000001898395A0-0x00000001898395E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D746F0-0x0000000182D74850
	[BlackList] // 0x0000000189843C40-0x0000000189843C80
	// [XID] // 0x0000000189843C40-0x0000000189843C80
	public virtual void ReturnToObjectPool() {} // 0x0000000182D77ED0-0x0000000182D77F70
	[BlackList] // 0x000000018984E160-0x000000018984E1A0
	// [XID] // 0x000000018984E160-0x000000018984E1A0
	public virtual void OnPoolAllocated() {} // 0x0000000182D77D90-0x0000000182D77E30
	[BlackList] // 0x0000000189858500-0x0000000189858540
	// [XID] // 0x0000000189858500-0x0000000189858540
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D77CF0-0x0000000182D77D90
}

