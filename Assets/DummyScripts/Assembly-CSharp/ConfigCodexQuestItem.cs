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
public class ConfigCodexQuestItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17663
{
	// Fields
	private SimpleSafeUInt32 itemIdRawNum; // 0x10
	private CodexQuestItemType _itemType; // 0x14
	private SimpleSafeUInt32 nextItemIdRawNum; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _speakerText; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _speakerText2; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCodexQuestText[] _texts; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCodexQuestDialogSingle[] _dialogs; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCodexQuestDialogSingle[] _dialogs2; // 0x40

	// Properties
	public uint itemId { /* [XID] */ /* 0x0000000189B5C9F0-0x0000000189B5CA10 */ get => default; /* [XID] */ /* 0x0000000189B640B0-0x0000000189B640D0 */ private set {} } // 0x0000000180F77EF0-0x0000000180F77FC0 0x0000000180F78740-0x0000000180F78820
	public CodexQuestItemType itemType { /* [XID] */ /* 0x0000000189B6B810-0x0000000189B6B830 */ get => default; /* [XID] */ /* 0x0000000189B72ED0-0x0000000189B72EF0 */ private set {} } // 0x0000000180F77DB0-0x0000000180F77E50 0x0000000180F79390-0x0000000180F79440
	public uint nextItemId { /* [XID] */ /* 0x0000000189B7A3F0-0x0000000189B7A410 */ get => default; /* [XID] */ /* 0x0000000189B81BF0-0x0000000189B81C10 */ private set {} } // 0x0000000180F77CE0-0x0000000180F77DB0 0x0000000180F78CF0-0x0000000180F78DD0
	public ConfigCodexQuestText speakerText { /* [XID] */ /* 0x0000000189B89310-0x0000000189B89330 */ get => default; /* [XID] */ /* 0x0000000189B90870-0x0000000189B90890 */ private set {} } // 0x0000000180F77E50-0x0000000180F77EF0 0x0000000180F78C40-0x0000000180F78CF0
	public ConfigCodexQuestText speakerText2 { /* [XID] */ /* 0x0000000189B97D40-0x0000000189B97D60 */ get => default; /* [XID] */ /* 0x0000000189B9F110-0x0000000189B9F130 */ private set {} } // 0x0000000180F76D90-0x0000000180F76E30 0x0000000180F79230-0x0000000180F792E0
	public ConfigCodexQuestText[] texts { /* [XID] */ /* 0x0000000189BA6980-0x0000000189BA69A0 */ get => default; /* [XID] */ /* 0x0000000189BADBC0-0x0000000189BADBE0 */ private set {} } // 0x0000000180F77C40-0x0000000180F77CE0 0x0000000180F78690-0x0000000180F78740
	public ConfigCodexQuestDialogSingle[] dialogs { /* [XID] */ /* 0x0000000189BB5370-0x0000000189BB5390 */ get => default; /* [XID] */ /* 0x0000000189BBCA90-0x0000000189BBCAB0 */ private set {} } // 0x0000000180F78BA0-0x0000000180F78C40 0x0000000180F792E0-0x0000000180F79390
	public ConfigCodexQuestDialogSingle[] dialogs2 { /* [XID] */ /* 0x0000000189BC4760-0x0000000189BC4780 */ get => default; /* [XID] */ /* 0x0000000189BCC0C0-0x0000000189BCC0E0 */ private set {} } // 0x0000000180F79AD0-0x0000000180F79B70 0x0000000180F79E80-0x0000000180F79F30

	// Constructors
	public ConfigCodexQuestItem() {} // 0x0000000180F79FD0-0x0000000180F7A030

	// Methods
	// [XID] // 0x0000000189BD36F0-0x0000000189BD3710
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F79B70-0x0000000180F79D40
	// [XID] // 0x0000000189BDB000-0x0000000189BDB020
	public void InitEmpty() {} // 0x0000000180F78DD0-0x0000000180F78F30
	[BlackList] // 0x00000001895E7930-0x00000001895E7970
	// [XID] // 0x00000001895E7930-0x00000001895E7970
	public bool FromJson(JSONNode node) => default; // 0x0000000180F78820-0x0000000180F78BA0
	// [XID] // 0x00000001895F20F0-0x00000001895F2110
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180F76E30-0x0000000180F776C0
	// [XID] // 0x00000001895F9A00-0x00000001895F9A20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76CB */, bool useObjectPool = false /* Metadata: 0x00AF76CF */) => default; // 0x0000000180F78F30-0x0000000180F79230
	// [XID] // 0x0000000189601180-0x00000001896011A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76D0 */, bool useObjectPool = false /* Metadata: 0x00AF76D4 */) => default; // 0x0000000180F77FC0-0x0000000180F78690
	[BlackList] // 0x0000000189608B90-0x0000000189608BD0
	// [XID] // 0x0000000189608B90-0x0000000189608BD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F776C0-0x0000000180F77990
	// [XID] // 0x00000001896130C0-0x00000001896130E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F79440-0x0000000180F79AD0
	[BlackList] // 0x000000018961A8C0-0x000000018961A900
	// [XID] // 0x000000018961A8C0-0x000000018961A900
	public virtual void AutoAllocTypeFields() {} // 0x0000000180F77990-0x0000000180F77A30
	[BlackList] // 0x0000000189624D30-0x0000000189624D70
	// [XID] // 0x0000000189624D30-0x0000000189624D70
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180F77A30-0x0000000180F77C40
	[BlackList] // 0x000000018962F780-0x000000018962F7C0
	// [XID] // 0x000000018962F780-0x000000018962F7C0
	public virtual void ReturnToObjectPool() {} // 0x0000000180F79F30-0x0000000180F79FD0
	[BlackList] // 0x000000018963A1B0-0x000000018963A1F0
	// [XID] // 0x000000018963A1B0-0x000000018963A1F0
	public virtual void OnPoolAllocated() {} // 0x0000000180F79DE0-0x0000000180F79E80
	[BlackList] // 0x00000001896447B0-0x00000001896447F0
	// [XID] // 0x00000001896447B0-0x00000001896447F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180F79D40-0x0000000180F79DE0
}

