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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class AINerveKnowledge : IAutoAllocRecycle // TypeDefIndex: 19958
{
	// Fields
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private Dictionary<NeuronLayer, List<NeuronBase>> _neurons; // 0x10
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<NeuronBase> _neuronRoutineSubset; // 0x18

	// Constructors
	public AINerveKnowledge() {} // 0x0000000185091F50-0x0000000185091FB0

	// Methods
	[BlackList] // 0x00000001898ED0A0-0x00000001898ED0E0
	// [XID] // 0x00000001898ED0A0-0x00000001898ED0E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001850903A0-0x0000000185090480
	[BlackList] // 0x00000001898F7B90-0x00000001898F7BD0
	// [XID] // 0x00000001898F7B90-0x00000001898F7BD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185090480-0x0000000185090540
	[BlackList] // 0x0000000189902310-0x0000000189902350
	// [XID] // 0x0000000189902310-0x0000000189902350
	public virtual void ReturnToObjectPool() {} // 0x0000000185091EB0-0x0000000185091F50
	// [XID] // 0x000000018990CBB0-0x000000018990CBD0
	public virtual void OnPoolAllocated() {} // 0x0000000185091E10-0x0000000185091EB0
	// [XID] // 0x00000001899142C0-0x00000001899142E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185091BC0-0x0000000185091E10
	// [XID] // 0x00000001896C8640-0x00000001896C8660
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x00000001850919B0-0x0000000185091BC0
	// [XID] // 0x0000000189923440-0x0000000189923460
	public void InitNerve(Dictionary<string, NeuronName[]> nerveSettings, string nerveSettingName) {} // 0x0000000185090A10-0x0000000185090D50
	// [XID] // 0x000000018992AB80-0x000000018992ABA0
	private NeuronBase Fetch(NeuronName neuronName) => default; // 0x0000000185091670-0x00000001850918C0
	// [XID] // 0x0000000189932160-0x0000000189932180
	public bool HasNeuron(NeuronName neuronName) => default; // 0x0000000185090620-0x00000001850906E0
	// [XID] // 0x0000000189939B70-0x0000000189939B90
	public float GetStimulateChangeTime(NeuronName neuronName) => default; // 0x0000000185090D50-0x0000000185090E30
	// [IDTag] // 0x0000000189940D80-0x0000000189940DC0
	// [XID] // 0x0000000189940D80-0x0000000189940DC0
	public bool CheckStimulated(NeuronName neuronName, float currentTime) => default; // 0x00000001850906E0-0x00000001850907E0
	// [IDTag] // 0x000000018994B760-0x000000018994B7A0
	// [XID] // 0x000000018994B760-0x000000018994B7A0
	public bool CheckStimulated(NeuronLayer layer, float currentTime) => default; // 0x00000001850907E0-0x0000000185090A10
	// [XID] // 0x0000000189BCE480-0x0000000189BCE4A0
	public void StimulateNeuron(NeuronName neuronName, float currentTime) {} // 0x00000001850918C0-0x00000001850919B0
	// [XID] // 0x000000018995D870-0x000000018995D890
	public void DeactivateNeuron(NeuronName neuronName, float currentTime) {} // 0x00000001850914C0-0x00000001850915B0
	// [XID] // 0x0000000189964F70-0x0000000189964F90
	public void MuteNeuron(NeuronName neuronName) {} // 0x0000000185090540-0x0000000185090620
	// [XID] // 0x000000018996C4F0-0x000000018996C510
	public void UnmuteNeuron(NeuronName neuronName) {} // 0x00000001850915B0-0x0000000185091670
	// [XID] // 0x0000000189973F90-0x0000000189973FB0
	public void StimulateRoutineSubset(float currentTime) {} // 0x0000000185091310-0x00000001850914C0
	// [XID] // 0x000000018997B770-0x000000018997B790
	public void DeactivateRoutineSubset() {} // 0x0000000185091160-0x0000000185091310
	// [XID] // 0x0000000189BDBBE0-0x0000000189BDBC00
	public List<NeuronBase> GetAllStimulatedNeurons(float currentTime) => default; // 0x0000000185090E30-0x0000000185091160
}

