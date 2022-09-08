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

public sealed class VCStateLayerController : VCBase // TypeDefIndex: 11964
{
	// Fields
	[NonSerialized]
	private VCAnimatorEvent _animatorComponent; // 0x108
	[NonSerialized]
	private Dictionary<int, ConfigBaseStateLayer> _stateLayers; // 0x110
	private Dictionary<int, Dictionary<int, Dictionary<int, int>>> _multiAnimatorStateToStateIDMap; // 0x118
	private Dictionary<int, ConfigNormalStateIDInfo> curStateIDConfigs; // 0x120
	private Dictionary<int, int> curStateIDs; // 0x128
	private int _lastStateID; // 0x130
	private int _lastStateLayer; // 0x134
	private bool _destroyed; // 0x138
	private bool _doStateChangeCB; // 0x139
	private List<int> _cacheAnimStates; // 0x140
	private HashSet<int> _triggersSetInCurrentStateId; // 0x148
	private static HashSet<int> _resetTriggerWhiteList; // 0x00
	private List<int> _attachStateLayerPatternIndexes; // 0x150
	private List<int> _attachAnimatorStatePatternIndexes; // 0x158

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189798BF0-0x0000000189798C10 */ get => default; } // 0x00000001839ECF60-0x00000001839ED000 

	// Constructors
	public VCStateLayerController() {} // 0x00000001839ECE40-0x00000001839ECF60
	static VCStateLayerController() {} // 0x00000001839ECD40-0x00000001839ECE40

	// Methods
	// [XID] // 0x00000001895F7690-0x00000001895F76B0
	public ConfigNormalStateIDInfo GetCurStateIDConfigs(bool printErrorLog = false /* Metadata: 0x00AEB002 */) => default; // 0x00000001839E9DD0-0x00000001839E9F00
	// [XID] // 0x00000001895FEA30-0x00000001895FEA50
	private void GetCurStateIDConfigsPrintErrorLog() {} // 0x00000001839EC5D0-0x00000001839ECA30
	// [XID] // 0x00000001897AFB90-0x00000001897AFBB0
	public int GetCurStateID() => default; // 0x00000001839EC4C0-0x00000001839EC560
	// [XID] // 0x0000000189968B10-0x0000000189968B30
	public void SetStateLayers(Dictionary<string, ConfigBaseStateLayer> layers) {} // 0x00000001839EBDD0-0x00000001839EC030
	// [XID] // 0x00000001897BF860-0x00000001897BF880
	public override void Init() {} // 0x00000001839EB1A0-0x00000001839EB380
	// [XID] // 0x00000001897C6FF0-0x00000001897C7010
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001839E9D10-0x00000001839E9DD0
	// [XID] // 0x00000001897CE5C0-0x00000001897CE5E0
	public override void Destroy() {} // 0x00000001839EA1C0-0x00000001839EA780
	// [XID] // 0x00000001897D5CB0-0x00000001897D5CD0
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x00000001839EB430-0x00000001839EB810
	// [XID] // 0x00000001897DD430-0x00000001897DD450
	private void OnAnimatorNormalizedAction(int layerIndex, float normalizedTime) {} // 0x00000001839EA9F0-0x00000001839EAB60
	// [XID] // 0x00000001897E4D30-0x00000001897E4D50
	public List<int> GetAnimStates(string state) => default; // 0x00000001839EB870-0x00000001839EBDD0
	// [XID] // 0x00000001897EC970-0x00000001897EC990
	public int GetAnimShortNameHash(string state) => default; // 0x00000001839EB380-0x00000001839EB430
	// [XID] // 0x00000001897F41C0-0x00000001897F41E0
	public void OnAnimatorSetTrigger(int paramId) {} // 0x00000001839EA080-0x00000001839EA1C0
	// [XID] // 0x00000001897FBC20-0x00000001897FBC40
	public override void OnDisable() {} // 0x00000001839ECAF0-0x00000001839ECBC0
	// [XID] // 0x0000000189803130-0x0000000189803150
	private void InitStateToAnimatorStateIDMap() {} // 0x00000001839EC0A0-0x00000001839EC4C0
	// [XID] // 0x000000018980A5A0-0x000000018980A5C0
	private void StateIDChanged(ConfigBaseStateLayer stateLayer, int fromStateID, int toStateID) {} // 0x00000001839EAB60-0x00000001839EB0F0
	// [XID] // 0x0000000189811D00-0x0000000189811D20
	private int GetTopLayerState() => default; // 0x00000001839EA7E0-0x00000001839EA9F0
	// [XID] // 0x0000000189819990-0x00000001898199B0
	public void AttachEffectToStateLayer(string effectPatternName) {} // 0x00000001839ECA30-0x00000001839ECAF0
	// [XID] // 0x00000001898210D0-0x00000001898210F0
	public void AttachEffectToAnimatorState(string effectPatternName) {} // 0x00000001839E9B40-0x00000001839E9C00
	// [XID] // 0x0000000189828680-0x00000001898286A0
	private void DetachEffectsFromStateLayer() {} // 0x00000001839EB0F0-0x00000001839EB1A0
	// [XID] // 0x000000018982F910-0x000000018982F930
	private void DetachEffectsFromAnimatorState() {} // 0x00000001839E9C60-0x00000001839E9D10
	// [XID] // 0x00000001898371F0-0x0000000189837210
	private void AttachEffect(ref List<int> indexes, string effectPatternName) {} // 0x00000001839E9F00-0x00000001839EA080
	// [XID] // 0x000000018983E790-0x000000018983E7B0
	private void DetachEffects(ref List<int> indexes) {} // 0x00000001839ECBC0-0x00000001839ECD40
}

