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
public class ConfigPickup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17991
{
	// Fields
	private PickType _pickType; // 0x10
	private bool _isStatic; // 0x14
	private SimpleSafeFloat dropPointMaxYawRawNum; // 0x18
	private SimpleSafeFloat dropPointMinSpeedRawNum; // 0x1C
	private SimpleSafeFloat dropPointMaxSpeedRawNum; // 0x20
	private string _bornEffect; // 0x28
	private string _dropEffect; // 0x30
	private MoleMole.Config.Vector _dropOffset; // 0x38
	private bool _enableScan; // 0x44
	private bool _lockYmove; // 0x45
	private SimpleSafeFloat suspendHeightRawNum; // 0x48
	private SimpleSafeFloat suspendSpeedRawNum; // 0x4C
	private SimpleSafeFloat suspendAmplitudeRawNum; // 0x50
	private SimpleSafeFloat rotateSpeedRawNum; // 0x54
	private MoleMole.Config.Vector _rotateVec; // 0x58
	private SimpleSafeFloat attractDelayTimeRawNum; // 0x64
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPickupMulti _multi; // 0x68
	private MoleMole.Config.Vector _dirVec; // 0x70
	private SimpleSafeFloat gravityRationRawNum; // 0x7C
	private bool _disableInitJump; // 0x80
	private SimpleSafeFloat initBackSpeedRawNum; // 0x84
	private SimpleSafeFloat backDecelerateRawNum; // 0x88
	private SimpleSafeFloat backFanAngleRawNum; // 0x8C
	private SimpleSafeFloat backFanStartAngleRawNum; // 0x90
	private SimpleSafeInt32 reboundTimesRawNum; // 0x94
	private SimpleSafeFloat reboundRationRawNum; // 0x98
	private SimpleSafeFloat attractAccelerateRawNum; // 0x9C
	private SimpleSafeFloat attractMaxDistanceRawNum; // 0xA0
	private SimpleSafeFloat heightOffsetRawNum; // 0xA4
	private MoleMole.Config.Vector _rotateDecelerate; // 0xA8
	private string _attractAudio; // 0xB8

	// Properties
	public PickType pickType { /* [XID] */ /* 0x0000000189735A40-0x0000000189735A60 */ get => default; /* [XID] */ /* 0x000000018973D610-0x000000018973D630 */ private set {} } // 0x0000000184CB5770-0x0000000184CB5810 0x0000000184CB1060-0x0000000184CB1110
	public bool isStatic { /* [XID] */ /* 0x0000000189ACD860-0x0000000189ACD880 */ get => default; /* [XID] */ /* 0x000000018974C7E0-0x000000018974C800 */ private set {} } // 0x0000000184CB11F0-0x0000000184CB1290 0x0000000184CB4940-0x0000000184CB49F0
	public float dropPointMaxYaw { /* [XID] */ /* 0x0000000189ABB7B0-0x0000000189ABB7D0 */ get => default; /* [XID] */ /* 0x000000018975B060-0x000000018975B080 */ private set {} } // 0x0000000184CB4B50-0x0000000184CB4C30 0x0000000184CB1F60-0x0000000184CB2040
	public float dropPointMinSpeed { /* [XID] */ /* 0x0000000189762990-0x00000001897629B0 */ get => default; /* [XID] */ /* 0x0000000189769FD0-0x0000000189769FF0 */ private set {} } // 0x0000000184CAF260-0x0000000184CAF340 0x0000000184CAF3E0-0x0000000184CAF4C0
	public float dropPointMaxSpeed { /* [XID] */ /* 0x0000000189ACA590-0x0000000189ACA5B0 */ get => default; /* [XID] */ /* 0x0000000189778F40-0x0000000189778F60 */ private set {} } // 0x0000000184CB1110-0x0000000184CB11F0 0x0000000184CB3120-0x0000000184CB3200
	public string bornEffect { /* [XID] */ /* 0x0000000189780640-0x0000000189780660 */ get => default; /* [XID] */ /* 0x0000000189787E20-0x0000000189787E40 */ private set {} } // 0x0000000184CB5620-0x0000000184CB56C0 0x0000000184CB56C0-0x0000000184CB5770
	public string dropEffect { /* [XID] */ /* 0x000000018978F3A0-0x000000018978F3C0 */ get => default; /* [XID] */ /* 0x0000000189796B50-0x0000000189796B70 */ private set {} } // 0x0000000184CB1A60-0x0000000184CB1B00 0x0000000184CB49F0-0x0000000184CB4AA0
	public MoleMole.Config.Vector dropOffset { /* [XID] */ /* 0x000000018964CD00-0x000000018964CD20 */ get => default; /* [XID] */ /* 0x00000001897A62E0-0x00000001897A6300 */ private set {} } // 0x0000000184CAFAF0-0x0000000184CAFBD0 0x0000000184CB3200-0x0000000184CB32D0
	public bool enableScan { /* [XID] */ /* 0x00000001897AD7D0-0x00000001897AD7F0 */ get => default; /* [XID] */ /* 0x00000001897B58B0-0x00000001897B58D0 */ private set {} } // 0x0000000184CB4D10-0x0000000184CB4DB0 0x0000000184CAFA40-0x0000000184CAFAF0
	public bool lockYmove { /* [XID] */ /* 0x0000000189A68F70-0x0000000189A68F90 */ get => default; /* [XID] */ /* 0x00000001897C49E0-0x00000001897C4A00 */ private set {} } // 0x0000000184CAF340-0x0000000184CAF3E0 0x0000000184CB47B0-0x0000000184CB4860
	public float suspendHeight { /* [XID] */ /* 0x0000000189A70220-0x0000000189A70240 */ get => default; /* [XID] */ /* 0x00000001897D3B60-0x00000001897D3B80 */ private set {} } // 0x0000000184CB5380-0x0000000184CB5460 0x0000000184CAF8B0-0x0000000184CAF990
	public float suspendSpeed { /* [XID] */ /* 0x0000000189AF9940-0x0000000189AF9960 */ get => default; /* [XID] */ /* 0x00000001897E2C80-0x00000001897E2CA0 */ private set {} } // 0x0000000184CB2690-0x0000000184CB2770 0x0000000184CB32D0-0x0000000184CB33B0
	public float suspendAmplitude { /* [XID] */ /* 0x00000001897EA4E0-0x00000001897EA500 */ get => default; /* [XID] */ /* 0x00000001897F2290-0x00000001897F22B0 */ private set {} } // 0x0000000184CB46D0-0x0000000184CB47B0 0x0000000184CB2E80-0x0000000184CB2F60
	public float rotateSpeed { /* [XID] */ /* 0x0000000189A77AA0-0x0000000189A77AC0 */ get => default; /* [XID] */ /* 0x0000000189800DE0-0x0000000189800E00 */ private set {} } // 0x0000000184CB1520-0x0000000184CB1600 0x0000000184CB1DA0-0x0000000184CB1E80
	public MoleMole.Config.Vector rotateVec { /* [XID] */ /* 0x0000000189AD9A30-0x0000000189AD9A50 */ get => default; /* [XID] */ /* 0x000000018980FDB0-0x000000018980FDD0 */ private set {} } // 0x0000000184CB1600-0x0000000184CB16E0 0x0000000184CAF730-0x0000000184CAF800
	public float attractDelayTime { /* [XID] */ /* 0x00000001898173C0-0x00000001898173E0 */ get => default; /* [XID] */ /* 0x000000018981ED20-0x000000018981ED40 */ private set {} } // 0x0000000184CB1BE0-0x0000000184CB1CC0 0x0000000184CB5540-0x0000000184CB5620
	public ConfigPickupMulti multi { /* [XID] */ /* 0x00000001897CCEC0-0x00000001897CCEE0 */ get => default; /* [XID] */ /* 0x000000018982D840-0x000000018982D860 */ private set {} } // 0x0000000184CB2DE0-0x0000000184CB2E80 0x0000000184CB2040-0x0000000184CB20F0
	public MoleMole.Config.Vector dirVec { /* [XID] */ /* 0x0000000189A4D950-0x0000000189A4D970 */ get => default; /* [XID] */ /* 0x000000018983C6F0-0x000000018983C710 */ private set {} } // 0x0000000184CB1CC0-0x0000000184CB1DA0 0x0000000184CB24E0-0x0000000184CB25B0
	public float gravityRation { /* [XID] */ /* 0x0000000189843E60-0x0000000189843E80 */ get => default; /* [XID] */ /* 0x000000018984B310-0x000000018984B330 */ private set {} } // 0x0000000184CB2C20-0x0000000184CB2D00 0x0000000184CB1E80-0x0000000184CB1F60
	public bool disableInitJump { /* [XID] */ /* 0x0000000189AE46E0-0x0000000189AE4700 */ get => default; /* [XID] */ /* 0x0000000189859E90-0x0000000189859EB0 */ private set {} } // 0x0000000184CAF990-0x0000000184CAFA40 0x0000000184CAF800-0x0000000184CAF8B0
	public float initBackSpeed { /* [XID] */ /* 0x0000000189860FB0-0x0000000189860FD0 */ get => default; /* [XID] */ /* 0x00000001898687D0-0x00000001898687F0 */ private set {} } // 0x0000000184CB2770-0x0000000184CB2850 0x0000000184CB4860-0x0000000184CB4940
	public float backDecelerate { /* [XID] */ /* 0x000000018986FC20-0x000000018986FC40 */ get => default; /* [XID] */ /* 0x0000000189877330-0x0000000189877350 */ private set {} } // 0x0000000184CB0F80-0x0000000184CB1060 0x0000000184CB5460-0x0000000184CB5540
	public float backFanAngle { /* [XID] */ /* 0x000000018987EC60-0x000000018987EC80 */ get => default; /* [XID] */ /* 0x0000000189886100-0x0000000189886120 */ private set {} } // 0x0000000184CB1440-0x0000000184CB1520 0x0000000184CB2400-0x0000000184CB24E0
	public float backFanStartAngle { /* [XID] */ /* 0x0000000189AE7520-0x0000000189AE7540 */ get => default; /* [XID] */ /* 0x0000000189894A50-0x0000000189894A70 */ private set {} } // 0x0000000184CB2F60-0x0000000184CB3040 0x0000000184CB3040-0x0000000184CB3120
	public int reboundTimes { /* [XID] */ /* 0x000000018989BFC0-0x000000018989BFE0 */ get => default; /* [XID] */ /* 0x00000001898A36A0-0x00000001898A36C0 */ private set {} } // 0x0000000184CB2B50-0x0000000184CB2C20 0x0000000184CAED90-0x0000000184CAEE70
	public float reboundRation { /* [XID] */ /* 0x00000001898AA9C0-0x00000001898AA9E0 */ get => default; /* [XID] */ /* 0x00000001898B2390-0x00000001898B23B0 */ private set {} } // 0x0000000184CB0EA0-0x0000000184CB0F80 0x0000000184CAF650-0x0000000184CAF730
	public float attractAccelerate { /* [XID] */ /* 0x0000000189B72320-0x0000000189B72340 */ get => default; /* [XID] */ /* 0x00000001898C14E0-0x00000001898C1500 */ private set {} } // 0x0000000184CB0DC0-0x0000000184CB0EA0 0x0000000184CB25B0-0x0000000184CB2690
	public float attractMaxDistance { /* [XID] */ /* 0x00000001898C8E60-0x00000001898C8E80 */ get => default; /* [XID] */ /* 0x00000001898D0660-0x00000001898D0680 */ private set {} } // 0x0000000184CB2D00-0x0000000184CB2DE0 0x0000000184CB1290-0x0000000184CB1370
	public float heightOffset { /* [XID] */ /* 0x0000000189B082F0-0x0000000189B08310 */ get => default; /* [XID] */ /* 0x00000001898DFA20-0x00000001898DFA40 */ private set {} } // 0x0000000184CAF4C0-0x0000000184CAF5A0 0x0000000184CB1B00-0x0000000184CB1BE0
	public MoleMole.Config.Vector rotateDecelerate { /* [XID] */ /* 0x00000001898E74D0-0x00000001898E74F0 */ get => default; /* [XID] */ /* 0x00000001898EED40-0x00000001898EED60 */ private set {} } // 0x0000000184CB4C30-0x0000000184CB4D10 0x0000000184CB1370-0x0000000184CB1440
	public string attractAudio { /* [XID] */ /* 0x0000000189BA4380-0x0000000189BA43A0 */ get => default; /* [XID] */ /* 0x00000001898FDCE0-0x00000001898FDD00 */ private set {} } // 0x0000000184CB4AA0-0x0000000184CB4B50 0x0000000184CAF5A0-0x0000000184CAF650

	// Constructors
	public ConfigPickup() {} // 0x0000000184CB58B0-0x0000000184CB5AE0

	// Methods
	// [XID] // 0x0000000189905520-0x0000000189905540
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184CB4DB0-0x0000000184CB5240
	// [XID] // 0x000000018990CD90-0x000000018990CDB0
	public void InitEmpty() {} // 0x0000000184CB20F0-0x0000000184CB2400
	[BlackList] // 0x0000000189914560-0x00000001899145A0
	// [XID] // 0x0000000189914560-0x00000001899145A0
	public bool FromJson(JSONNode node) => default; // 0x0000000184CB16E0-0x0000000184CB1A60
	// [XID] // 0x000000018991EE20-0x000000018991EE40
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184CACD90-0x0000000184CAEAC0
	// [XID] // 0x0000000189926840-0x0000000189926860
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85E9 */, bool useObjectPool = false /* Metadata: 0x00AF85ED */) => default; // 0x0000000184CB2850-0x0000000184CB2B50
	// [XID] // 0x000000018992DDD0-0x000000018992DDF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85EE */, bool useObjectPool = false /* Metadata: 0x00AF85F2 */) => default; // 0x0000000184CAFBD0-0x0000000184CB0DC0
	[BlackList] // 0x00000001899351F0-0x0000000189935230
	// [XID] // 0x00000001899351F0-0x0000000189935230
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184CAEAC0-0x0000000184CAED90
	// [XID] // 0x000000018993FBA0-0x000000018993FBC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184CB33B0-0x0000000184CB46D0
	[BlackList] // 0x00000001899472A0-0x00000001899472E0
	// [XID] // 0x00000001899472A0-0x00000001899472E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184CAEE70-0x0000000184CAEF10
	[BlackList] // 0x0000000189951BD0-0x0000000189951C10
	// [XID] // 0x0000000189951BD0-0x0000000189951C10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184CAEF10-0x0000000184CAF260
	[BlackList] // 0x000000018995C040-0x000000018995C080
	// [XID] // 0x000000018995C040-0x000000018995C080
	public virtual void ReturnToObjectPool() {} // 0x0000000184CB5810-0x0000000184CB58B0
	[BlackList] // 0x0000000189966A50-0x0000000189966A90
	// [XID] // 0x0000000189966A50-0x0000000189966A90
	public virtual void OnPoolAllocated() {} // 0x0000000184CB52E0-0x0000000184CB5380
	[BlackList] // 0x0000000189971620-0x0000000189971660
	// [XID] // 0x0000000189971620-0x0000000189971660
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184CB5240-0x0000000184CB52E0
}

