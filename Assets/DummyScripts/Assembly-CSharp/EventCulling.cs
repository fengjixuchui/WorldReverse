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

public class EventCulling // TypeDefIndex: 11289
{
	// Fields
	private readonly WorkerThreadContext _context; // 0x10
	private readonly Dictionary<uint, EventCullingRuleList> _cullingRuleDict; // 0x18
	private readonly EventCullingGlobalRuleList _globalCullingRuleList; // 0x20
	private readonly EventCullingRuleFactory _factory; // 0x28
	private bool _configDataloaded; // 0x30

	// Constructors
	public EventCulling() {} // Dummy constructor
	public EventCulling(WorkerThreadContext context) {} // 0x00000001814DDD00-0x00000001814DDDD0

	// Methods
	// [XID] // 0x0000000189A16820-0x0000000189A16840
	public EventCullingResult CheckEvent(uint eventId, SyncId syncId) => default; // 0x00000001814DD1A0-0x00000001814DD340
	// [XID] // 0x0000000189A1DCC0-0x0000000189A1DCE0
	public void OnEventSuccessPost(uint eventId, SyncId syncId) {} // 0x00000001814DDB80-0x00000001814DDD00
	// [XID] // 0x00000001897693D0-0x00000001897693F0
	public void Clear() {} // 0x00000001814DD7C0-0x00000001814DD9A0
	// [XID] // 0x000000018990F360-0x000000018990F380
	public void Reload() {} // 0x00000001814DD340-0x00000001814DD3F0
	// [XID] // 0x0000000189952780-0x00000001899527A0
	private void LoadData() {} // 0x00000001814DD3F0-0x00000001814DD7C0
	// [XID] // 0x00000001898BADB0-0x00000001898BADD0
	public void AddRuleCullingNameContain(string pattern) {} // 0x00000001814DD9A0-0x00000001814DDA90
	// [XID] // 0x0000000189A432E0-0x0000000189A43300
	public void AddRuleCullingNameNotContain(string pattern) {} // 0x00000001814DDA90-0x00000001814DDB80
}

