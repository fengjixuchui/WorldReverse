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
public class ConfigAIPoseControlItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17403
{
	// Fields
	private SimpleSafeFloat minTimeRawNum; // 0x10
	private SimpleSafeFloat maxTimeRawNum; // 0x14
	private SimpleSafeInt32 poseIDRawNum; // 0x18
	private SimpleSafeInt32[] _RandomPose; // 0x20
	private bool _switchOnlyInCanDoSkillState; // 0x28

	// Properties
	public float minTime { /* [XID] */ /* 0x000000018988BE80-0x000000018988BEA0 */ get => default; /* [XID] */ /* 0x0000000189893510-0x0000000189893530 */ private set {} } // 0x00000001841344B0-0x0000000184134590 0x0000000184134590-0x0000000184134670
	public float maxTime { /* [XID] */ /* 0x000000018989AC10-0x000000018989AC30 */ get => default; /* [XID] */ /* 0x00000001898A1EC0-0x00000001898A1EE0 */ private set {} } // 0x00000001841339A0-0x0000000184133A80 0x0000000184133EE0-0x0000000184133FC0
	public int poseID { /* [XID] */ /* 0x0000000189AA02D0-0x0000000189AA02F0 */ get => default; /* [XID] */ /* 0x00000001898B0F00-0x00000001898B0F20 */ private set {} } // 0x0000000184134AB0-0x0000000184134B80 0x0000000184133E00-0x0000000184133EE0
	public SimpleSafeInt32[] RandomPose { /* [XID] */ /* 0x00000001898B86A0-0x00000001898B86C0 */ get => default; /* [XID] */ /* 0x00000001898BFE60-0x00000001898BFE80 */ private set {} } // 0x0000000184133900-0x00000001841339A0 0x0000000184134400-0x00000001841344B0
	public bool switchOnlyInCanDoSkillState { /* [XID] */ /* 0x0000000189B827A0-0x0000000189B827C0 */ get => default; /* [XID] */ /* 0x00000001898CED30-0x00000001898CED50 */ private set {} } // 0x0000000184133180-0x0000000184133220 0x00000001841333E0-0x0000000184133490

	// Constructors
	public ConfigAIPoseControlItem() {} // 0x0000000184134EC0-0x0000000184135010

	// Methods
	// [XID] // 0x00000001898D6740-0x00000001898D6760
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184134B80-0x0000000184134CE0
	// [XID] // 0x00000001898DE3C0-0x00000001898DE3E0
	public void InitEmpty() {} // 0x0000000184133FC0-0x0000000184134100
	[BlackList] // 0x00000001898E5BE0-0x00000001898E5C20
	// [XID] // 0x00000001898E5BE0-0x00000001898E5C20
	public bool FromJson(JSONNode node) => default; // 0x0000000184133A80-0x0000000184133E00
	// [XID] // 0x00000001898F0500-0x00000001898F0520
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841328C0-0x0000000184132EB0
	// [XID] // 0x00000001898F7F50-0x00000001898F7F70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D69 */, bool useObjectPool = false /* Metadata: 0x00AF6D6D */) => default; // 0x0000000184134100-0x0000000184134400
	// [XID] // 0x00000001898FF5D0-0x00000001898FF5F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D6E */, bool useObjectPool = false /* Metadata: 0x00AF6D72 */) => default; // 0x0000000184133490-0x0000000184133900
	[BlackList] // 0x0000000189906D70-0x0000000189906DB0
	// [XID] // 0x0000000189906D70-0x0000000189906DB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184132EB0-0x0000000184133180
	// [XID] // 0x0000000189911540-0x0000000189911560
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184134670-0x0000000184134AB0
	[BlackList] // 0x00000001899190E0-0x0000000189919120
	// [XID] // 0x00000001899190E0-0x0000000189919120
	public virtual void AutoAllocTypeFields() {} // 0x0000000184133220-0x00000001841332C0
	[BlackList] // 0x00000001899238E0-0x0000000189923920
	// [XID] // 0x00000001899238E0-0x0000000189923920
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841332C0-0x00000001841333E0
	[BlackList] // 0x000000018992DFB0-0x000000018992DFF0
	// [XID] // 0x000000018992DFB0-0x000000018992DFF0
	public virtual void ReturnToObjectPool() {} // 0x0000000184134E20-0x0000000184134EC0
	[BlackList] // 0x0000000189938330-0x0000000189938370
	// [XID] // 0x0000000189938330-0x0000000189938370
	public virtual void OnPoolAllocated() {} // 0x0000000184134D80-0x0000000184134E20
	[BlackList] // 0x0000000189942A50-0x0000000189942A90
	// [XID] // 0x0000000189942A50-0x0000000189942A90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184134CE0-0x0000000184134D80
}

