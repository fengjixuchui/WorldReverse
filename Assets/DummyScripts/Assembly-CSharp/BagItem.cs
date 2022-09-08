/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BagItem : IReusable // TypeDefIndex: 20664
{
	// Fields
	protected ItemParam _itemParam; // 0x10
	protected bool _beforeGetShow; // 0x60

	// Properties
	public bool isEquip { /* [XID] */ /* 0x0000000189869BA0-0x0000000189869BC0 */ get; } // 0x00000001843012E0-0x00000001843013A0 
	public ulong guid { /* [XID] */ /* 0x0000000189870F40-0x0000000189870F60 */ get; } // 0x0000000184301910-0x00000001843019B0 
	public uint item_id { /* [XID] */ /* 0x00000001898788F0-0x0000000189878910 */ get; } // 0x0000000184301B90-0x0000000184301C30 
	public ItemType itemType { /* [XID] */ /* 0x000000018987FEC0-0x000000018987FEE0 */ get; } // 0x00000001843010D0-0x0000000184301170 
	public uint cur_count { /* [XID] */ /* 0x00000001898874C0-0x00000001898874E0 */ get; /* [XID] */ /* 0x000000018988E680-0x000000018988E6A0 */ set; } // 0x0000000184301AF0-0x0000000184301B90 0x0000000184301230-0x00000001843012E0
	public virtual ulong cdTime { /* [XID] */ /* 0x0000000189895C60-0x0000000189895C80 */ get; } // 0x00000001843019B0-0x0000000184301A50 
	public ItemConfig itemConfig { /* [XID] */ /* 0x000000018989D2A0-0x000000018989D2C0 */ get; } // 0x00000001843013A0-0x0000000184301440 
	public ItemLockState lockState { /* [XID] */ /* 0x00000001898A4C20-0x00000001898A4C40 */ get; } // 0x0000000184301870-0x0000000184301910 
	public virtual uint rankLevel { /* [XID] */ /* 0x00000001898B3840-0x00000001898B3860 */ get; } // 0x0000000184301720-0x00000001843017C0 
	public virtual bool beforeGetShow { /* [XID] */ /* 0x00000001898DF770-0x00000001898DF790 */ get; /* [XID] */ /* 0x00000001898D7AA0-0x00000001898D7AC0 */ set; } // 0x0000000184301C30-0x0000000184301CD0 0x00000001843017C0-0x0000000184301870

	// Constructors
	protected BagItem() {} // 0x0000000184301CD0-0x0000000184301D40

	// Methods
	protected abstract void Recycle();
	// [IDTag] // 0x000000018984DF60-0x000000018984DFA0
	// [XID] // 0x000000018984DF60-0x000000018984DFA0
	public static BagItem Create(ItemParam itemParam) => default; // 0x0000000184301590-0x0000000184301720
	// [IDTag] // 0x0000000189858240-0x0000000189858280
	// [XID] // 0x0000000189858240-0x0000000189858280
	public static BagItem Create(Item item) => default; // 0x0000000184301440-0x0000000184301590
	// [XID] // 0x00000001898627B0-0x00000001898627D0
	public void Destroy() {} // 0x0000000184301170-0x0000000184301230
	// [XID] // 0x00000001898AC100-0x00000001898AC120
	public void ResetLockState() {} // 0x0000000184301A50-0x0000000184301AF0
	// [IDTag] // 0x00000001898BB610-0x00000001898BB650
	// [XID] // 0x00000001898BB610-0x00000001898BB650
	public virtual void Refresh(ItemParam itemParam) {} // 0x0000000184300F20-0x0000000184301030
	// [IDTag] // 0x00000001898C5890-0x00000001898C58D0
	// [XID] // 0x00000001898C5890-0x00000001898C58D0
	public virtual void Refresh(Item item) {} // 0x0000000184300E00-0x0000000184300F20
	// [XID] // 0x00000001898D04A0-0x00000001898D04C0
	public virtual void BeforeRecycle() {} // 0x0000000184301030-0x00000001843010D0
}

