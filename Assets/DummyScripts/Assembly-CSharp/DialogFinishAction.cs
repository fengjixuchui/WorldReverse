/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DialogFinishAction : BaseInterAction // TypeDefIndex: 20629
{
	// Fields
	public const uint FINAL_CODE = 0; // Metadata: 0x00AFDEDB
	public const uint EDT_TALK_FINAL_CODE = 1; // Metadata: 0x00AFDEDF
	public const uint TRY_FINISH_CODE = 2; // Metadata: 0x00AFDEE3
	public const uint COOP_FINISH_CODE = 3; // Metadata: 0x00AFDEE7
	private uint _finalCode; // 0x48
	private uint _currTalkID; // 0x4C
	private Coroutine _finishCoroutine; // 0x50

	// Properties
	public uint currTalkID { /* [XID] */ /* 0x000000018996F1A0-0x000000018996F1C0 */ get => default; } // 0x0000000183CDE760-0x0000000183CDE800 
	public uint finalCode { /* [XID] */ /* 0x0000000189976D50-0x0000000189976D70 */ get => default; /* [XID] */ /* 0x000000018997E120-0x000000018997E140 */ set {} } // 0x0000000183CDEA50-0x0000000183CDEAF0 0x0000000183CDEC20-0x0000000183CDECD0

	// Constructors
	public DialogFinishAction() {} // 0x0000000183CDEE80-0x0000000183CDEEF0

	// Methods
	// [XID] // 0x00000001896C58D0-0x00000001896C58F0
	public void SetCurrTalkID(uint currTalkID) {} // 0x0000000183CDE9A0-0x0000000183CDEA50
	// [XID] // 0x000000018998D880-0x000000018998D8A0
	public void StartFinishCoroutine() {} // 0x0000000183CDEAF0-0x0000000183CDEC20
	// [XID] // 0x0000000189995330-0x0000000189995350
	public void FinishCoroutine() {} // 0x0000000183CDE800-0x0000000183CDE8F0
	// [XID] // 0x000000018999CDF0-0x000000018999CE10
	public override void Finish() {} // 0x0000000183CDE8F0-0x0000000183CDE9A0
}

