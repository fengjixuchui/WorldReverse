/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class CameraStateFactory // TypeDefIndex: 32074
{
	// Fields
	private const int STATE_TYPE_BITS = 5; // Metadata: 0x00B13C7A
	private const int SEQUENCE_BITS = 27; // Metadata: 0x00B13C7E
	private const int STATE_TYPE_SHIFT = 27; // Metadata: 0x00B13C82
	private const int SEQUENCE_SHIFT = 0; // Metadata: 0x00B13C86
	private const int MAX_STATE_ID = 134217727; // Metadata: 0x00B13C8A
	private static int _currStateId; // 0x00

	// Constructors
	static CameraStateFactory() {} // 0x00000001812BFF30-0x00000001812BFF90

	// Methods
	// [XID] // 0x0000000189BC6990-0x0000000189BC69B0
	public static void ResetStateId() {} // 0x00000001812BFB30-0x00000001812BFBF0
	// [XID] // 0x0000000189BCE6E0-0x0000000189BCE700
	private static int GetNextStateId(int stateType) => default; // 0x00000001812BF9F0-0x00000001812BFB30
	// [XID] // 0x000000018991F730-0x000000018991F750
	public static SCameraNormalState CreateNormalState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BF350-0x00000001812BF4F0
	// [XID] // 0x0000000189BDD520-0x0000000189BDD540
	public static SCameraLockingState CreateLockingState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BF1B0-0x00000001812BF350
	// [XID] // 0x00000001895EA0D0-0x00000001895EA0F0
	public static SCameraGiantBossAdjustState CreateGiantBossAdjustState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BFBF0-0x00000001812BFD90
	// [XID] // 0x00000001895F1600-0x00000001895F1620
	public static SCameraPhotographState CreatePhotographState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BF850-0x00000001812BF9F0
	// [XID] // 0x000000018992E930-0x000000018992E950
	public static SCameraFirstPersonState CreateFirstPersonState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BEE70-0x00000001812BF010
	// [XID] // 0x0000000189600660-0x0000000189600680
	public static SCameraCineState CreateCineState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc, SCineType cineType) => default; // 0x00000001812BF4F0-0x00000001812BF6B0
	// [XID] // 0x0000000189944CF0-0x0000000189944D10
	public static SCameraStoryState CreateStoryState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BF6B0-0x00000001812BF850
	// [XID] // 0x00000001899539D0-0x00000001899539F0
	public static SCameraFocusState CreateFocusState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BFD90-0x00000001812BFF30
	// [XID] // 0x000000018995B210-0x000000018995B230
	public static SCameraHomeWorldState CreateHomeworldState(VCStackCamera vcCamera, int priority, string stateName, string stateDesc) => default; // 0x00000001812BF010-0x00000001812BF1B0
}

