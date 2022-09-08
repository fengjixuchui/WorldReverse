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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MatchingTimeComponent : BaseContextComponent // TypeDefIndex: 30021
{
	// Fields
	private Transform _matchingView; // 0x30
	private uint _playId; // 0x38
	private bool _isMatching; // 0x3C
	private UnityEngine.UI.Text _matchingTime; // 0x40
	private Action<bool> _stateChangeCallBack; // 0x48
	private float _lastUpdateTime; // 0x50

	// Constructors
	public MatchingTimeComponent() {} // 0x00000001824EBEA0-0x00000001824EBF20

	// Methods
	// [XID] // 0x0000000189782F40-0x0000000189782F60
	public override void Init(GameObject view) {} // 0x00000001824EB510-0x00000001824EB5D0
	// [XID] // 0x000000018978A3D0-0x000000018978A3F0
	public void SetComponentData(Transform view, UnityEngine.UI.Text time, uint playID, Action<bool> callBack = null) {} // 0x00000001824EBA10-0x00000001824EBB20
	// [XID] // 0x0000000189791BF0-0x0000000189791C10
	private void RefreshMatchingData() {} // 0x00000001824EB630-0x00000001824EB730
	// [XID] // 0x00000001897991F0-0x0000000189799210
	private void RefreshMatchingView() {} // 0x00000001824EB420-0x00000001824EB510
	// [XID] // 0x00000001897A10F0-0x00000001897A1110
	private void RefreshMatchTimeView() {} // 0x00000001824EB730-0x00000001824EBA10
	// [XID] // 0x00000001897A8760-0x00000001897A8780
	public override void UpdateView() {} // 0x00000001824EBDD0-0x00000001824EBEA0
	// [XID] // 0x00000001897B0180-0x00000001897B01A0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001824EBBB0-0x00000001824EBDD0
}

