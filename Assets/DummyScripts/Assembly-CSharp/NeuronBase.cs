/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public abstract class NeuronBase : IAutoAllocRecycle // TypeDefIndex: 20217
{
	// Fields
	public NeuronName neuronName; // 0x10
	public bool mute; // 0x14
	public float decayTime; // 0x18
	public static float FLT_MAX; // 0x00
	public static Dictionary<NeuronName, NeuronAttr> LayerMapping; // 0x08

	// Constructors
	protected NeuronBase() {} // 0x00000001846D42D0-0x00000001846D4340
	static NeuronBase() {} // 0x00000001846D3C90-0x00000001846D42D0

	// Methods
	[BlackList] // 0x000000018974C490-0x000000018974C4D0
	// [XID] // 0x000000018974C490-0x000000018974C4D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001846D35E0-0x00000001846D3680
	[BlackList] // 0x0000000189756840-0x0000000189756880
	// [XID] // 0x0000000189756840-0x0000000189756880
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846D3680-0x00000001846D3720
	[BlackList] // 0x0000000189761150-0x0000000189761190
	// [XID] // 0x0000000189761150-0x0000000189761190
	public virtual void ReturnToObjectPool() {} // 0x00000001846D3BF0-0x00000001846D3C90
	[BlackList] // 0x000000018976B5A0-0x000000018976B5E0
	// [XID] // 0x000000018976B5A0-0x000000018976B5E0
	public virtual void OnPoolAllocated() {} // 0x00000001846D3A90-0x00000001846D3B30
	[BlackList] // 0x0000000189775AC0-0x0000000189775B00
	// [XID] // 0x0000000189775AC0-0x0000000189775B00
	public virtual void OnBeforePoolRecycled() {} // 0x00000001846D39F0-0x00000001846D3A90
	// [XID] // 0x00000001899030D0-0x00000001899030F0
	public void InitNeuron(NeuronName name, float decay = 0f /* Metadata: 0x00AFD3BE */) {} // 0x00000001846D3920-0x00000001846D39F0
	// [XID] // 0x00000001895E8590-0x00000001895E85B0
	public virtual bool IsStimulated(float currentTime) => default; // 0x00000001846D3720-0x00000001846D37D0
	// [XID] // 0x0000000189BD5780-0x0000000189BD57A0
	public virtual void SetStimulate(bool stimulate, float currentTime) {} // 0x00000001846D3B30-0x00000001846D3BF0
	// [XID] // 0x00000001897968F0-0x0000000189796910
	public virtual float GetChangeTime() => default; // 0x00000001846D37D0-0x00000001846D3880
	// [XID] // 0x00000001896D0030-0x00000001896D0050
	public virtual void Reset() {} // 0x00000001846D3880-0x00000001846D3920
}

