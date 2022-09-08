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

public class FurnitureParentshipSet // TypeDefIndex: 20833
{
	// Fields
	protected GadgetEntity _rootEntity; // 0x10
	protected HashSet<GadgetEntity> _loadingGadgets; // 0x18
	protected Dictionary<GadgetEntity, GadgetEntity> _entity2ParentEntityMap; // 0x20
	protected HomeworldManager _homeworldManager; // 0x28
	protected bool _verifyNextFrame; // 0x30
	protected float _startTimeStamp; // 0x34

	// Constructors
	public FurnitureParentshipSet() {} // Dummy constructor
	public FurnitureParentshipSet(GadgetEntity rootEntity, HomeworldManager homeworldManager) {} // 0x000000018166A640-0x000000018166A720

	// Methods
	// [XID] // 0x0000000189A12CF0-0x0000000189A12D10
	public void RegisterLoadingGadget(GadgetEntity entity, GadgetEntity parentEntity) {} // 0x000000018166A260-0x000000018166A370
	// [XID] // 0x0000000189A1A0B0-0x0000000189A1A0D0
	public void GadgetLoaded(GadgetEntity entity) {} // 0x000000018166A080-0x000000018166A260
	// [XID] // 0x0000000189A215F0-0x0000000189A21610
	protected void VerifyParentship() {} // 0x0000000181669C60-0x000000018166A080
	// [XID] // 0x0000000189A28BF0-0x0000000189A28C10
	public string DumpParentshipContent() => default; // 0x000000018166A370-0x000000018166A640
}

