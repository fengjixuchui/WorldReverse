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
public class ConfigVideo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17784
{
	// Fields
	private bool _heroDiff; // 0x10
	private string _videoName; // 0x18
	private string _videoNameOther; // 0x20
	private SimpleSafeUInt32 subtitleIdRawNum; // 0x28
	private SimpleSafeUInt32 subtitleIdOtherRawNum; // 0x2C
	private bool _canSkip; // 0x30
	private ColorVector _bgColor; // 0x34
	private SimpleSafeFloat fadeInDurationRawNum; // 0x44
	private SimpleSafeFloat fadeOutDurationRawNum; // 0x48

	// Properties
	public bool heroDiff { /* [XID] */ /* 0x00000001898CBC70-0x00000001898CBC90 */ get => default; /* [XID] */ /* 0x00000001898D34F0-0x00000001898D3510 */ private set {} } // 0x000000018417ACB0-0x000000018417AD50 0x000000018417A900-0x000000018417A9B0
	public string videoName { /* [XID] */ /* 0x00000001898DAC40-0x00000001898DAC60 */ get => default; /* [XID] */ /* 0x00000001898E2AE0-0x00000001898E2B00 */ private set {} } // 0x000000018417AD50-0x000000018417ADF0 0x000000018417AEA0-0x000000018417AF50
	public string videoNameOther { /* [XID] */ /* 0x00000001898EA650-0x00000001898EA670 */ get => default; /* [XID] */ /* 0x00000001898F1D10-0x00000001898F1D30 */ private set {} } // 0x000000018417BD30-0x000000018417BDD0 0x000000018417ADF0-0x000000018417AEA0
	public uint subtitleId { /* [XID] */ /* 0x00000001898F9590-0x00000001898F95B0 */ get => default; /* [XID] */ /* 0x0000000189900F10-0x0000000189900F30 */ private set {} } // 0x000000018417BC60-0x000000018417BD30 0x000000018417A6B0-0x000000018417A790
	public uint subtitleIdOther { /* [XID] */ /* 0x00000001899086B0-0x00000001899086D0 */ get => default; /* [XID] */ /* 0x000000018990FD50-0x000000018990FD70 */ private set {} } // 0x000000018417AF50-0x000000018417B020 0x0000000184178A00-0x0000000184178AE0
	public bool canSkip { /* [XID] */ /* 0x00000001899178E0-0x0000000189917900 */ get => default; /* [XID] */ /* 0x000000018991EEA0-0x000000018991EEC0 */ private set {} } // 0x000000018417A010-0x000000018417A0B0 0x00000001841798C0-0x0000000184179970
	public ColorVector bgColor { /* [XID] */ /* 0x00000001899268C0-0x00000001899268E0 */ get => default; /* [XID] */ /* 0x000000018992DE10-0x000000018992DE30 */ private set {} } // 0x000000018417B870-0x000000018417B940 0x000000018417A0B0-0x000000018417A170
	public float fadeInDuration { /* [XID] */ /* 0x0000000189935290-0x00000001899352B0 */ get => default; /* [XID] */ /* 0x000000018993CDB0-0x000000018993CDD0 */ private set {} } // 0x000000018417A5D0-0x000000018417A6B0 0x000000018417B020-0x000000018417B100
	public float fadeOutDuration { /* [XID] */ /* 0x0000000189944480-0x00000001899444A0 */ get => default; /* [XID] */ /* 0x000000018994BA80-0x000000018994BAA0 */ private set {} } // 0x000000018417B100-0x000000018417B1E0 0x000000018417A170-0x000000018417A250

	// Constructors
	public ConfigVideo() {} // 0x000000018417BE70-0x000000018417BF10

	// Methods
	// [XID] // 0x0000000189953250-0x0000000189953270
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018417B940-0x000000018417BB20
	// [XID] // 0x000000018995A970-0x000000018995A990
	public void InitEmpty() {} // 0x000000018417A790-0x000000018417A900
	[BlackList] // 0x00000001899624B0-0x00000001899624F0
	// [XID] // 0x00000001899624B0-0x00000001899624F0
	public bool FromJson(JSONNode node) => default; // 0x000000018417A250-0x000000018417A5D0
	// [XID] // 0x000000018996C850-0x000000018996C870
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184178AE0-0x0000000184179410
	// [XID] // 0x00000001899742B0-0x00000001899742D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C0B */, bool useObjectPool = false /* Metadata: 0x00AF7C0F */) => default; // 0x000000018417A9B0-0x000000018417ACB0
	// [XID] // 0x000000018997B9C0-0x000000018997B9E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C10 */, bool useObjectPool = false /* Metadata: 0x00AF7C14 */) => default; // 0x0000000184179970-0x000000018417A010
	[BlackList] // 0x0000000189983550-0x0000000189983590
	// [XID] // 0x0000000189983550-0x0000000189983590
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184179410-0x00000001841796E0
	// [XID] // 0x000000018998DCC0-0x000000018998DCE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018417B1E0-0x000000018417B870
	[BlackList] // 0x0000000189995730-0x0000000189995770
	// [XID] // 0x0000000189995730-0x0000000189995770
	public virtual void AutoAllocTypeFields() {} // 0x00000001841796E0-0x0000000184179780
	[BlackList] // 0x00000001899A0090-0x00000001899A00D0
	// [XID] // 0x00000001899A0090-0x00000001899A00D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184179780-0x00000001841798C0
	[BlackList] // 0x00000001899AAB20-0x00000001899AAB60
	// [XID] // 0x00000001899AAB20-0x00000001899AAB60
	public virtual void ReturnToObjectPool() {} // 0x000000018417BDD0-0x000000018417BE70
	[BlackList] // 0x00000001899B5360-0x00000001899B53A0
	// [XID] // 0x00000001899B5360-0x00000001899B53A0
	public virtual void OnPoolAllocated() {} // 0x000000018417BBC0-0x000000018417BC60
	[BlackList] // 0x00000001899BFBF0-0x00000001899BFC30
	// [XID] // 0x00000001899BFBF0-0x00000001899BFC30
	public virtual void OnBeforePoolRecycled() {} // 0x000000018417BB20-0x000000018417BBC0
}

