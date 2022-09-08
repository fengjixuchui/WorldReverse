/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct RewardTransformConfig // TypeDefIndex: 14881
{
	// Fields
	public uint id; // 0x00
	private uint lower; // 0x04
	private uint upper; // 0x08
	private bool invalid; // 0x0C

	// Constructors
	public RewardTransformConfig(uint id) {
		this.id = default;
		lower = default;
		upper = default;
		invalid = default;
	} // 0x0000000182480C40-0x0000000182480D40
	public RewardTransformConfig(uint id, uint value) {
		this.id = default;
		lower = default;
		upper = default;
		invalid = default;
	} // 0x0000000182480DD0-0x0000000182480E70
	public RewardTransformConfig(uint id, uint lower, uint upper) {
		this.id = default;
		this.lower = default;
		this.upper = default;
		invalid = default;
	} // 0x0000000182480D40-0x0000000182480DD0

	// Methods
	// [XID] // 0x000000018974CD80-0x000000018974CDA0
	public void Combine(RewardTransformConfig other) {} // 0x00000001824806F0-0x00000001824809D0
	// [XID] // 0x0000000189754100-0x0000000189754120
	public IdCountStrConfig ToIdCountStrConfig() => default; // 0x0000000182480BA0-0x0000000182480C40
	// [XID] // 0x000000018975B500-0x000000018975B520
	public RewardItemConfig ToRewardItemConfig() => default; // 0x00000001824804A0-0x0000000182480600
	// [XID] // 0x0000000189762FD0-0x0000000189762FF0
	public BagItem ToBagItem() => default; // 0x0000000182480600-0x00000001824806F0
	// [XID] // 0x000000018976A5D0-0x000000018976A5F0
	public bool TryTransform(out List<RewardTransformConfig> transformList) {
		transformList = default;
		return default;
	} // 0x00000001824809D0-0x0000000182480BA0
}

