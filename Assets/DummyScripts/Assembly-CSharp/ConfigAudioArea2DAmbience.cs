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
public class ConfigAudioArea2DAmbience : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17553
{
	// Fields
	private string _areaName; // 0x10
	private MoleMole.Config.Vector[] _areaPoints; // 0x18
	private SimpleSafeFloat yZeroAnchorRawNum; // 0x20
	private bool _enableHeightCheck; // 0x24
	private SimpleSafeFloat topRawNum; // 0x28
	private SimpleSafeFloat bottomRawNum; // 0x2C
	private bool _isAmbience; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _enterEvent; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _leaveEvent; // 0x40
	private bool _isReverb; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _auxBusName; // 0x50
	private SimpleSafeInt32 priorityRawNum; // 0x58
	private bool _excludeOther; // 0x5C
	private bool _enableChangeStates; // 0x5D
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _enterStates; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _leaveStates; // 0x68

	// Properties
	public string areaName { /* [XID] */ /* 0x00000001897053B0-0x00000001897053D0 */ get => default; /* [XID] */ /* 0x0000000189B49460-0x0000000189B49480 */ private set {} } // 0x00000001830001D0-0x0000000183000270 0x0000000183000320-0x00000001830003D0
	public MoleMole.Config.Vector[] areaPoints { /* [XID] */ /* 0x0000000189B50AE0-0x0000000189B50B00 */ get => default; /* [XID] */ /* 0x0000000189B58340-0x0000000189B58360 */ private set {} } // 0x00000001830012F0-0x0000000183001390 0x00000001830005C0-0x0000000183000670
	public float yZeroAnchor { /* [XID] */ /* 0x00000001896D2C10-0x00000001896D2C30 */ get => default; /* [XID] */ /* 0x0000000189B67300-0x0000000189B67320 */ private set {} } // 0x0000000183001C30-0x0000000183001D10 0x0000000183002870-0x0000000183002950
	public bool enableHeightCheck { /* [XID] */ /* 0x00000001896CB660-0x00000001896CB680 */ get => default; /* [XID] */ /* 0x0000000189B75DB0-0x0000000189B75DD0 */ private set {} } // 0x0000000183000480-0x0000000183000520 0x0000000182FFFAF0-0x0000000182FFFBA0
	public float top { /* [XID] */ /* 0x0000000189B7D260-0x0000000189B7D280 */ get => default; /* [XID] */ /* 0x0000000189B85090-0x0000000189B850B0 */ private set {} } // 0x0000000183002790-0x0000000183002870 0x0000000183002600-0x00000001830026E0
	public float bottom { /* [XID] */ /* 0x0000000189B8BE80-0x0000000189B8BEA0 */ get => default; /* [XID] */ /* 0x0000000189B93650-0x0000000189B93670 */ private set {} } // 0x0000000183001390-0x0000000183001470 0x0000000183001550-0x0000000183001630
	public bool isAmbience { /* [XID] */ /* 0x0000000189631AA0-0x0000000189631AC0 */ get => default; /* [XID] */ /* 0x0000000189BA23B0-0x0000000189BA23D0 */ private set {} } // 0x0000000183001A50-0x0000000183001AF0 0x0000000183000270-0x0000000183000320
	public ConfigWwiseString enterEvent { /* [XID] */ /* 0x000000018961B460-0x000000018961B480 */ get => default; /* [XID] */ /* 0x0000000189BB10D0-0x0000000189BB10F0 */ private set {} } // 0x0000000183000520-0x00000001830005C0 0x0000000183002030-0x00000001830020E0
	public ConfigWwiseString leaveEvent { /* [XID] */ /* 0x0000000189BB8240-0x0000000189BB8260 */ get => default; /* [XID] */ /* 0x0000000189BBF930-0x0000000189BBF950 */ private set {} } // 0x0000000183001AF0-0x0000000183001B90 0x00000001830003D0-0x0000000183000480
	public bool isReverb { /* [XID] */ /* 0x0000000189640AB0-0x0000000189640AD0 */ get => default; /* [XID] */ /* 0x0000000189BCF2B0-0x0000000189BCF2D0 */ private set {} } // 0x00000001830029F0-0x0000000183002A90 0x0000000183001D10-0x0000000183001DC0
	public ConfigWwiseString auxBusName { /* [XID] */ /* 0x000000018964FA30-0x000000018964FA50 */ get => default; /* [XID] */ /* 0x0000000189BDE1C0-0x0000000189BDE1E0 */ private set {} } // 0x00000001830019B0-0x0000000183001A50 0x00000001830026E0-0x0000000183002790
	public int priority { /* [XID] */ /* 0x000000018967CE80-0x000000018967CEA0 */ get => default; /* [XID] */ /* 0x00000001895F2150-0x00000001895F2170 */ private set {} } // 0x0000000183002480-0x0000000183002550 0x0000000183001470-0x0000000183001550
	public bool excludeOther { /* [XID] */ /* 0x00000001895F9A80-0x00000001895F9AA0 */ get => default; /* [XID] */ /* 0x0000000189601200-0x0000000189601220 */ private set {} } // 0x00000001830020E0-0x0000000183002180 0x0000000183001240-0x00000001830012F0
	public bool enableChangeStates { /* [XID] */ /* 0x0000000189608C30-0x0000000189608C50 */ get => default; /* [XID] */ /* 0x00000001896103F0-0x0000000189610410 */ private set {} } // 0x0000000183002950-0x00000001830029F0 0x0000000183002550-0x0000000183002600
	public AudioStateOp[] enterStates { /* [XID] */ /* 0x00000001896176D0-0x00000001896176F0 */ get => default; /* [XID] */ /* 0x000000018961F280-0x000000018961F2A0 */ private set {} } // 0x00000001830039A0-0x0000000183003A40 0x0000000182FFEAE0-0x0000000182FFEB90
	public AudioStateOp[] leaveStates { /* [XID] */ /* 0x0000000189626680-0x00000001896266A0 */ get => default; /* [XID] */ /* 0x000000018962DF70-0x000000018962DF90 */ private set {} } // 0x0000000183001B90-0x0000000183001C30 0x0000000183001F80-0x0000000183002030

	// Constructors
	public ConfigAudioArea2DAmbience() {} // 0x0000000183003AE0-0x0000000183003B40

	// Methods
	// [XID] // 0x0000000189635C30-0x0000000189635C50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830035A0-0x0000000183003860
	// [XID] // 0x000000018963D330-0x000000018963D350
	public void InitEmpty() {} // 0x0000000183001DC0-0x0000000183001F80
	[BlackList] // 0x0000000189644850-0x0000000189644890
	// [XID] // 0x0000000189644850-0x0000000189644890
	public bool FromJson(JSONNode node) => default; // 0x0000000183001630-0x00000001830019B0
	// [XID] // 0x000000018964EE80-0x000000018964EEA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182FFEB90-0x0000000182FFFAF0
	// [XID] // 0x00000001896566D0-0x00000001896566F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72B1 */, bool useObjectPool = false /* Metadata: 0x00AF72B5 */) => default; // 0x0000000183002180-0x0000000183002480
	// [XID] // 0x0000000189775110-0x0000000189775130
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72B6 */, bool useObjectPool = false /* Metadata: 0x00AF72BA */) => default; // 0x0000000183000670-0x0000000183001240
	[BlackList] // 0x0000000189665590-0x00000001896655D0
	// [XID] // 0x0000000189665590-0x00000001896655D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FFFBA0-0x0000000182FFFE70
	// [XID] // 0x0000000189670310-0x0000000189670330
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183002A90-0x00000001830035A0
	[BlackList] // 0x0000000189677B50-0x0000000189677B90
	// [XID] // 0x0000000189677B50-0x0000000189677B90
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FFFE70-0x0000000182FFFF10
	[BlackList] // 0x00000001896821B0-0x00000001896821F0
	// [XID] // 0x00000001896821B0-0x00000001896821F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FFFF10-0x00000001830001D0
	[BlackList] // 0x000000018968CC60-0x000000018968CCA0
	// [XID] // 0x000000018968CC60-0x000000018968CCA0
	public virtual void ReturnToObjectPool() {} // 0x0000000183003A40-0x0000000183003AE0
	[BlackList] // 0x00000001896979A0-0x00000001896979E0
	// [XID] // 0x00000001896979A0-0x00000001896979E0
	public virtual void OnPoolAllocated() {} // 0x0000000183003900-0x00000001830039A0
	[BlackList] // 0x00000001896A1EA0-0x00000001896A1EE0
	// [XID] // 0x00000001896A1EA0-0x00000001896A1EE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183003860-0x0000000183003900
}

