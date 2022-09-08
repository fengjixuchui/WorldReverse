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
public class ConfigRecordAnimatorInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18869
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AnimatorParameters _animatorParameter; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AnimatorRecordState _currentState; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AnimatorRecordState _nextState; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AnimatorRecordTransitionInfo _transitionInfo; // 0x28

	// Properties
	public AnimatorParameters animatorParameter { /* [XID] */ /* 0x00000001896DDD80-0x00000001896DDDA0 */ get => default; /* [XID] */ /* 0x00000001896E5390-0x00000001896E53B0 */ private set {} } // 0x0000000181EC7160-0x0000000181EC7200 0x0000000181EC72A0-0x0000000181EC7350
	public AnimatorRecordState currentState { /* [XID] */ /* 0x00000001896EC960-0x00000001896EC980 */ get => default; /* [XID] */ /* 0x00000001896F4180-0x00000001896F41A0 */ private set {} } // 0x0000000181EC70C0-0x0000000181EC7160 0x0000000181EC61C0-0x0000000181EC6270
	public AnimatorRecordState nextState { /* [XID] */ /* 0x00000001896FB9D0-0x00000001896FB9F0 */ get => default; /* [XID] */ /* 0x0000000189702FB0-0x0000000189702FD0 */ private set {} } // 0x0000000181EC6C10-0x0000000181EC6CB0 0x0000000181EC6B60-0x0000000181EC6C10
	public AnimatorRecordTransitionInfo transitionInfo { /* [XID] */ /* 0x000000018970A680-0x000000018970A6A0 */ get => default; /* [XID] */ /* 0x0000000189712110-0x0000000189712130 */ private set {} } // 0x0000000181EC7200-0x0000000181EC72A0 0x0000000181EC6730-0x0000000181EC67E0

	// Constructors
	public ConfigRecordAnimatorInfo() {} // 0x0000000181EC7A60-0x0000000181EC7AC0

	// Methods
	// [XID] // 0x00000001897197D0-0x00000001897197F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181EC7720-0x0000000181EC7880
	// [XID] // 0x0000000189720D50-0x0000000189720D70
	public void InitEmpty() {} // 0x0000000181EC6CB0-0x0000000181EC6DC0
	[BlackList] // 0x0000000189728390-0x00000001897283D0
	// [XID] // 0x0000000189728390-0x00000001897283D0
	public bool FromJson(JSONNode node) => default; // 0x0000000181EC67E0-0x0000000181EC6B60
	// [XID] // 0x0000000189732960-0x0000000189732980
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181EC5700-0x0000000181EC5BE0
	// [XID] // 0x000000018973A130-0x000000018973A150
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1B7 */, bool useObjectPool = false /* Metadata: 0x00AFB1BB */) => default; // 0x0000000181EC6DC0-0x0000000181EC70C0
	// [XID] // 0x0000000189741C60-0x0000000189741C80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1BC */, bool useObjectPool = false /* Metadata: 0x00AFB1C0 */) => default; // 0x0000000181EC6270-0x0000000181EC6730
	[BlackList] // 0x0000000189749560-0x00000001897495A0
	// [XID] // 0x0000000189749560-0x00000001897495A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181EC5BE0-0x0000000181EC5EB0
	// [XID] // 0x00000001897538E0-0x0000000189753900
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181EC7350-0x0000000181EC7720
	[BlackList] // 0x000000018975ADE0-0x000000018975AE20
	// [XID] // 0x000000018975ADE0-0x000000018975AE20
	public virtual void AutoAllocTypeFields() {} // 0x0000000181EC5EB0-0x0000000181EC5F50
	[BlackList] // 0x0000000189765490-0x00000001897654D0
	// [XID] // 0x0000000189765490-0x00000001897654D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181EC5F50-0x0000000181EC61C0
	[BlackList] // 0x000000018976FC90-0x000000018976FCD0
	// [XID] // 0x000000018976FC90-0x000000018976FCD0
	public virtual void ReturnToObjectPool() {} // 0x0000000181EC79C0-0x0000000181EC7A60
	[BlackList] // 0x000000018977A340-0x000000018977A380
	// [XID] // 0x000000018977A340-0x000000018977A380
	public virtual void OnPoolAllocated() {} // 0x0000000181EC7920-0x0000000181EC79C0
	[BlackList] // 0x0000000189784DE0-0x0000000189784E20
	// [XID] // 0x0000000189784DE0-0x0000000189784E20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181EC7880-0x0000000181EC7920
}

