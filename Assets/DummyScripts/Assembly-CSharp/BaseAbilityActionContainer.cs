/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseAbilityActionContainer : IAbilityActionContainer // TypeDefIndex: 20566
{
	// Fields
	protected List<Tuple<int, string>> _attachedPatternIndices; // 0x10
	protected float _duration; // 0x18
	protected float _durationCnt; // 0x1C
	protected bool _attached; // 0x20

	// Properties
	public bool isAttached { /* [XID] */ /* 0x00000001897F7B90-0x00000001897F7BB0 */ get => default; } // 0x00000001812BC100-0x00000001812BC1A0 

	// Constructors
	public BaseAbilityActionContainer() {} // 0x00000001812BC760-0x00000001812BC7D0

	// Methods
	// [XID] // 0x00000001897F0440-0x00000001897F0460
	public virtual BaseEntity GetOwner() => default; // 0x00000001812BC060-0x00000001812BC100
	// [XID] // 0x00000001897FF250-0x00000001897FF270
	public virtual void Attach() {} // 0x00000001812BC490-0x00000001812BC530
	// [XID] // 0x00000001898069B0-0x00000001898069D0
	protected virtual void OnAttached() {} // 0x00000001812BC6C0-0x00000001812BC760
	// [XID] // 0x000000018980E170-0x000000018980E190
	public virtual bool Detach() => default; // 0x00000001812BC600-0x00000001812BC6C0
	// [XID] // 0x0000000189815870-0x0000000189815890
	public virtual void DetachFlush() {} // 0x00000001812BC2E0-0x00000001812BC490
	// [XID] // 0x000000018981D240-0x000000018981D260
	public void AttachEffectPatternIndex(int patternIx, string effectPattern) {} // 0x00000001812BC1A0-0x00000001812BC2E0
	// [XID] // 0x00000001898246C0-0x00000001898246E0
	public virtual bool Tick(float deltaTime) => default; // 0x00000001812BC530-0x00000001812BC600
}

