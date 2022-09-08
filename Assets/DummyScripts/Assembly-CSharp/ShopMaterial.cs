/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ShopMaterial // TypeDefIndex: 21685
{
	// Fields
	public const uint HCOIN_ITEM_ID = 201; // Metadata: 0x00AFFC08
	public const uint SCOIN_ITEM_ID = 202; // Metadata: 0x00AFFC0C
	public const uint MCOIN_ITEM_ID = 203; // Metadata: 0x00AFFC10
	public const uint HOME_COIN_ITEM_ID = 204; // Metadata: 0x00AFFC14
	public const uint RESIN_ITEM_ID = 106; // Metadata: 0x00AFFC18
	public const uint STAR_GLITTER_ITEM_ID = 221; // Metadata: 0x00AFFC1C
	public const uint STAR_DUST_ITEM_ID = 222; // Metadata: 0x00AFFC20
	private uint _costItemID; // 0x00
	private uint _costCount; // 0x04

	// Properties
	public uint costItemID { /* [XID] */ /* 0x000000018988A110-0x000000018988A130 */ get => default; } // 0x000000018273FCF0-0x000000018273FD70 
	public uint costCount { /* [XID] */ /* 0x0000000189891600-0x0000000189891620 */ get => default; } // 0x000000018273ED80-0x000000018273ED90 
	public bool isEnough { /* [XID] */ /* 0x000000018989FF50-0x000000018989FF70 */ get => default; } // 0x000000018273F8E0-0x000000018273F990 
	public long realItemCount { /* [XID] */ /* 0x00000001898C5770-0x00000001898C5790 */ get => default; } // 0x000000018273FC40-0x000000018273FCF0 
	public ItemConfig itemConfig { /* [XID] */ /* 0x00000001898CCE50-0x00000001898CCE70 */ get => default; } // 0x000000018273F5A0-0x000000018273F690 
	public bool isValid { /* [XID] */ /* 0x00000001898D47B0-0x00000001898D47D0 */ get => default; } // 0x000000018273F990-0x000000018273F9A0 

	// Constructors
	public ShopMaterial(uint itemID, uint count) : this() {
		_costItemID = default;
		_costCount = default;
	} // 0x000000018273FD70-0x000000018273FF10

	// Methods
	// [XID] // 0x0000000189898DD0-0x0000000189898DF0
	public bool IsEnough(uint count) => default; // 0x000000018273F760-0x000000018273F770
	// [XID] // 0x00000001898A77F0-0x00000001898A7810
	public uint LackCount(uint count) => default; // 0x000000018273F690-0x000000018273F760
	// [XID] // 0x00000001898AF250-0x00000001898AF270
	private static uint GetItemCount(uint itemId) => default; // 0x000000018273ED90-0x000000018273F5A0
	// [XID] // 0x00000001898B6690-0x00000001898B66B0
	private static uint GetSubItemCount(uint itemId) => default; // 0x000000018273F9A0-0x000000018273FC40
	// [XID] // 0x00000001898BDEE0-0x00000001898BDF00
	public static long GetRealItemCount(uint itemId) => default; // 0x000000018273F770-0x000000018273F8E0
}

