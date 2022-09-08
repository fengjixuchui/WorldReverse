/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseEquipControllerPlugin : BaseComponentPlugin // TypeDefIndex: 12035
{
	// Fields
	protected VCAvatarEquipController _vcEquipController; // 0x58
	protected ConfigCharacter _config; // 0x60
	private VCAnimatorEvent _vcAnimator; // 0x68
	protected HashSet<int> _configedStateIDs; // 0x70
	protected int _lastAnimStateLayerIndex; // 0x78
	protected int _lastAnimStateID; // 0x7C
	protected float _lastAnimNormTime; // 0x80
	protected int _currentAnimStateLayerIndex; // 0x84
	protected int _currentAnimStateID; // 0x88
	protected float _currentAnimNormTime; // 0x8C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018999AB90-0x000000018999ABB0 */ get => default; } // 0x0000000184037DD0-0x0000000184037E70 

	// Constructors
	public BaseEquipControllerPlugin() {} // Dummy constructor
	protected BaseEquipControllerPlugin(VCAvatarEquipController vcEquipController, ConfigCharacter config) {} // 0x0000000184037D40-0x0000000184037DD0

	// Methods
	// [XID] // 0x00000001899A2310-0x00000001899A2330
	public override void Init() {} // 0x00000001840376D0-0x0000000184037840
	// [XID] // 0x00000001899A9B20-0x00000001899A9B40
	public override void Destroy() {} // 0x0000000184037480-0x0000000184037590
	// [XID] // 0x00000001899B1520-0x00000001899B1540
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x0000000184037840-0x0000000184037B00
	// [XID] // 0x00000001899B89A0-0x00000001899B89C0
	public override void LateTick(float deltaTime) {} // 0x0000000184037B60-0x0000000184037CD0
	// [XID] // 0x00000001899C0270-0x00000001899C0290
	protected virtual void OnAnimatorChanged() {} // 0x0000000184037630-0x00000001840376D0
	// [XID] // 0x00000001899C7AF0-0x00000001899C7B10
	protected virtual void UpdateEquipController() {} // 0x0000000184037590-0x0000000184037630
}

