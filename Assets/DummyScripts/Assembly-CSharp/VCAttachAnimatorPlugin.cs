/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCAttachAnimatorPlugin : VCAttachBasePlugin // TypeDefIndex: 12155
{
	// Fields
	private Animator _attachAnim; // 0x60
	private Animator _ownerAnim; // 0x68
	private List<int> _paramBindKeys; // 0x70
	private Dictionary<int, int> _paramBindDic; // 0x78
	private Dictionary<int, Action<int, int>> _paramBindFunc; // 0x80
	private bool _isManekinFlycloak; // 0x88

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899A39E0-0x00000001899A3A00 */ get => default; } // 0x0000000182DED190-0x0000000182DED230 
	protected override bool IsInValid { /* [XID] */ /* 0x0000000189A4EF70-0x0000000189A4EF90 */ get => default; } // 0x0000000182DEBA80-0x0000000182DEBB60 

	// Constructors
	public VCAttachAnimatorPlugin() {} // 0x0000000182DED0A0-0x0000000182DED190

	// Methods
	// [XID] // 0x0000000189919AC0-0x0000000189919AE0
	public void BindParam(string ownerParam, string attachParam, AnimatorControllerParameterType paramType) {} // 0x0000000182DECB00-0x0000000182DECD80
	// [XID] // 0x00000001899289F0-0x0000000189928A10
	private void UpdateParamInt(int ownerParamHash, int attachParamHash) {} // 0x0000000182DEB3F0-0x0000000182DEB4F0
	// [XID] // 0x00000001899BA0D0-0x00000001899BA0F0
	private void UpdateParamFloat(int ownerParamHash, int attachParamHash) {} // 0x0000000182DECD80-0x0000000182DECE80
	// [XID] // 0x00000001899C1C20-0x00000001899C1C40
	private void UpdateParamBool(int ownerParamHash, int attachParamHash) {} // 0x0000000182DEB710-0x0000000182DEB810
	// [XID] // 0x000000018995CA60-0x000000018995CA80
	private void UpdateParamTrigger(int ownerParamHash, int attachParamHash) {} // 0x0000000182DECA10-0x0000000182DECB00
	// [IDTag] // 0x00000001899D0B80-0x00000001899D0BC0
	// [XID] // 0x00000001899D0B80-0x00000001899D0BC0
	public void SetParamInt(int paramNameHash, int value) {} // 0x0000000182DEBF10-0x0000000182DEC040
	// [IDTag] // 0x00000001899DAF80-0x00000001899DAFC0
	// [XID] // 0x00000001899DAF80-0x00000001899DAFC0
	public int GetParamInt(int paramNameHash) => default; // 0x0000000182DEB230-0x0000000182DEB340
	// [IDTag] // 0x00000001899E5BB0-0x00000001899E5BF0
	// [XID] // 0x00000001899E5BB0-0x00000001899E5BF0
	public void SetParamInt(string paramName, int value) {} // 0x0000000182DEC040-0x0000000182DEC180
	// [IDTag] // 0x00000001899F00E0-0x00000001899F0120
	// [XID] // 0x00000001899F00E0-0x00000001899F0120
	public int GetParamInt(string paramName) => default; // 0x0000000182DEB120-0x0000000182DEB230
	// [IDTag] // 0x00000001899FA6F0-0x00000001899FA730
	// [XID] // 0x00000001899FA6F0-0x00000001899FA730
	public void SetParamFloat(int paramNameHash, float value) {} // 0x0000000182DEB950-0x0000000182DEBA80
	// [IDTag] // 0x0000000189A718F0-0x0000000189A71930
	// [XID] // 0x0000000189A718F0-0x0000000189A71930
	public float GetParamFloat(int paramNameHash) => default; // 0x0000000182DEAEE0-0x0000000182DEB000
	// [IDTag] // 0x0000000189A0F080-0x0000000189A0F0C0
	// [XID] // 0x0000000189A0F080-0x0000000189A0F0C0
	public void SetParamFloat(string paramName, float value) {} // 0x0000000182DEB810-0x0000000182DEB950
	// [IDTag] // 0x0000000189A19690-0x0000000189A196D0
	// [XID] // 0x0000000189A19690-0x0000000189A196D0
	public float GetParamFloat(string paramName) => default; // 0x0000000182DEB000-0x0000000182DEB120
	// [IDTag] // 0x0000000189A23D70-0x0000000189A23DB0
	// [XID] // 0x0000000189A23D70-0x0000000189A23DB0
	public void SetParamBool(int paramNameHash, bool value) {} // 0x0000000182DEC790-0x0000000182DEC8D0
	// [IDTag] // 0x0000000189A2DFA0-0x0000000189A2DFE0
	// [XID] // 0x0000000189A2DFA0-0x0000000189A2DFE0
	public void SetParamBool(string paramName, bool value) {} // 0x0000000182DEC8D0-0x0000000182DECA10
	// [XID] // 0x0000000189AAA6B0-0x0000000189AAA6D0
	public void ForceJumpToState(string paramName) {} // 0x0000000182DEB4F0-0x0000000182DEB610
	// [XID] // 0x0000000189A400C0-0x0000000189A400E0
	public void SetIsManekinFlycloak(bool isManekin) {} // 0x0000000182DEB340-0x0000000182DEB3F0
	// [XID] // 0x0000000189A47760-0x0000000189A47780
	public override void Init() {} // 0x0000000182DEC180-0x0000000182DEC4D0
	// [XID] // 0x0000000189A565A0-0x0000000189A565C0
	public void RefreshView() {} // 0x0000000182DEBDC0-0x0000000182DEBF10
	// [XID] // 0x0000000189A5E1B0-0x0000000189A5E1D0
	public override void Tick(float inDeltaTime) {} // 0x0000000182DECF80-0x0000000182DED0A0
	// [XID] // 0x0000000189A65920-0x0000000189A65940
	private void TickBindParam() {} // 0x0000000182DEC530-0x0000000182DEC6A0
	// [XID] // 0x0000000189A6D070-0x0000000189A6D090
	public override void Destroy() {} // 0x0000000182DEB610-0x0000000182DEB710
	// [XID] // 0x0000000189A74760-0x0000000189A74780
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182DEBBE0-0x0000000182DEBCC0
	// [XID] // 0x0000000189A7C2A0-0x0000000189A7C2C0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182DECE80-0x0000000182DECF80
	// [XID] // 0x0000000189A83C60-0x0000000189A83C80
	private bool OnEvtAttachAnimatorParam(EvtAttachAnimatorParam evt) => default; // 0x0000000182DEBCC0-0x0000000182DEBDC0
}

