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

public class VoiceIdRegistration // TypeDefIndex: 11543
{
	// Fields
	private readonly Dictionary<VoiceIdentity, IVoiceIdPossessor> _possessors; // 0x10
	private readonly Dictionary<VoiceIdentity, RecycledLinkedList<IVoiceIdPossessor>> _requestors; // 0x18

	// Constructors
	public VoiceIdRegistration() {} // 0x00000001813E7D00-0x00000001813E7DE0

	// Methods
	// [XID] // 0x0000000189619DB0-0x0000000189619DD0
	public VoiceIdentityRequestResult RequestId(uint voiceId, IVoiceIdPossessor requestor) => default; // 0x00000001813E76B0-0x00000001813E7AD0
	// [XID] // 0x000000018979C570-0x000000018979C590
	public void ReleaseId(uint voiceId, IVoiceIdPossessor possessor) {} // 0x00000001813E6690-0x00000001813E6A50
	// [XID] // 0x00000001897A3AB0-0x00000001897A3AD0
	public void CancelRequest(uint voiceId, IVoiceIdPossessor requestor) {} // 0x00000001813E73C0-0x00000001813E7560
	// [XID] // 0x00000001897AAEE0-0x00000001897AAF00
	public bool TryRelinquishId(uint voiceId, IVoiceIdPossessor possessor) => default; // 0x00000001813E6A50-0x00000001813E6E40
	// [XID] // 0x00000001897B2AD0-0x00000001897B2AF0
	public void StopAll(bool dropRemaining) {} // 0x00000001813E6E40-0x00000001813E73C0
	// [XID] // 0x00000001897BA5C0-0x00000001897BA5E0
	private bool VerifyIsCurrentPossessor(VoiceIdentity voiceIdentity, IVoiceIdPossessor possessor) => default; // 0x00000001813E7560-0x00000001813E76B0
	// [IDTag] // 0x00000001897C24C0-0x00000001897C2500
	// [XID] // 0x00000001897C24C0-0x00000001897C2500
	private RecycledLinkedList<IVoiceIdPossessor> GetMostPotentialRequestorNode(VoiceIdentity voiceIdentity) => default; // 0x00000001813E7AD0-0x00000001813E7C00
	// [IDTag] // 0x00000001897CCE00-0x00000001897CCE40
	// [XID] // 0x00000001897CCE00-0x00000001897CCE40
	private RecycledLinkedList<IVoiceIdPossessor> GetMostPotentialRequestorNode(RecycledLinkedList<IVoiceIdPossessor> requestorList) => default; // 0x00000001813E7C00-0x00000001813E7D00
}

